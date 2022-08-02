using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

public class SortCollection<TSource>
{
    private List<IOrderByProperty<TSource>> sortProperties { get; set; }
        = new List<IOrderByProperty<TSource>>();

    public IReadOnlyList<IOrderByProperty> SortProperties => sortProperties.AsReadOnly();

    public SortCollection()
    { }

    public SortCollection(string value)
        : this(value?.Split(',', StringSplitOptions.RemoveEmptyEntries))
    {
    }

    public SortCollection(IEnumerable<string> elements)
    {
        if (elements == null)
            return;

        foreach (var element in elements)
        {
            var sortElement = Parse(element);

            // garbage property name, skip it
            if (sortElement is null) continue;

            sortProperties.Add(sortElement);
        }
    }

    private static IOrderByProperty<TSource>? Parse(string propertyName)
    {
        propertyName = propertyName.Trim();
        var properties = typeof(TSource).GetProperties().ToList();
        var direction = ListSortDirection.Ascending;

        if (propertyName.StartsWith("-"))
        {
            direction = ListSortDirection.Descending;
            propertyName = propertyName.Substring(1);
        }

        // property name cased properly
        var propertyInfo = properties.Find(p => p.Name.Equals(propertyName, StringComparison.OrdinalIgnoreCase));

        if (propertyInfo == null)
            return null;

        var type = typeof(SortProperty<>);
        var sortedElementType = type
            .MakeGenericType(
                typeof(TSource),
                propertyInfo.PropertyType
            );

        var ctor = sortedElementType
            .GetConstructor(new[] {
                typeof(PropertyInfo),
                typeof(ListSortDirection)
            });

        return ctor.Invoke(new object?[] {
            propertyInfo,
            direction
        }) as IOrderByProperty<TSource>;
    }

    public IQueryable<TSource> Apply(IQueryable<TSource> queryable)
    {
        var query = queryable;

        foreach (var element in sortProperties)
        {
            query = element.Apply(query);
        }

        return query;
    }

    public override string ToString()
    {
        return string.Join(",", sortProperties);
    }

    /// <summary>
    /// Creates a string with the Property Sort or Flips the direction if it exists
    /// </summary>
    /// <param name="element"></param>
    /// <returns></returns>
    public string AddOrUpdate(string element)
    {
        var parse = Parse(element);

        if (parse == null)
            return ToString();

        var sort = new SortCollection<TSource>(ToString());
        var property = sort
            .sortProperties
            .Find(x => x.PropertyName == parse.PropertyName);

        if (property == null)
        {
            sort.sortProperties.Add(parse);
            return sort.ToString();
        }

        property.SortDirection =
            property.SortDirection == ListSortDirection.Ascending
                ? ListSortDirection.Descending
                : ListSortDirection.Ascending;

        return sort.ToString();
    }

    public string Remove(string element)
    {
        var parse = Parse(element);

        if (parse == null)
            return ToString();

        var sort = new SortCollection<TSource>(ToString());
        var property = sort
            .sortProperties
            .Find(x => x.PropertyName == parse.PropertyName);

        if (property != null)
        {
            sort.sortProperties.Remove(property);
        }

        return sort.ToString();
    }

    private class SortProperty<TKey> : IOrderByProperty<TSource>
    {
        public SortProperty(
            PropertyInfo propertyInfo,
            ListSortDirection direction)
        {
            PropertyName = propertyInfo.Name;
            SortDirection = direction;

            var source = Expression.Parameter(typeof(TSource), "entity");
            var member = Expression.Property(source, propertyInfo);
            Filter = Expression.Lambda<Func<TSource, TKey>>(member, source);
        }

        public string PropertyName { get; private set; }
        public ListSortDirection SortDirection { get; set; }
        public Expression<Func<TSource, TKey>> Filter { get; private set; }

        public IQueryable<TSource> Apply(IQueryable<TSource> queryable)
        {
            var visitor = new OrderingMethodFinder();
            visitor.Visit(queryable.Expression);

            if (visitor.OrderingMethodFound)
            {
                queryable = SortDirection == ListSortDirection.Ascending
                    ? ((IOrderedQueryable<TSource>)queryable).ThenBy(Filter)
                    : ((IOrderedQueryable<TSource>)queryable).ThenByDescending(Filter);
            }
            else
            {
                queryable = SortDirection == ListSortDirection.Ascending
                    ? queryable.OrderBy(Filter)
                    : queryable.OrderByDescending(Filter);
            }
            return queryable;
        }

        public override string ToString()
        {
            return SortDirection == ListSortDirection.Ascending
                ? PropertyName
                : $"-{PropertyName}";
        }

        private class OrderingMethodFinder : ExpressionVisitor
        {
            public bool OrderingMethodFound { get; set; }

            protected override Expression VisitMethodCall(MethodCallExpression node)
            {
                var name = node.Method.Name;

                if (node.Method.DeclaringType == typeof(Queryable) && (
                    name.StartsWith("OrderBy", StringComparison.Ordinal) ||
                    name.StartsWith("ThenBy", StringComparison.Ordinal)))
                {
                    OrderingMethodFound = true;
                }
                return base.VisitMethodCall(node);
            }
        }
    }

    private interface IOrderByProperty<T> : IOrderByProperty
    {
        new ListSortDirection SortDirection { get; set; }
        IQueryable<T> Apply(IQueryable<T> queryable);
    }

    public interface IOrderByProperty
    {
        public string PropertyName { get; }
        public ListSortDirection SortDirection { get; }
    }
}