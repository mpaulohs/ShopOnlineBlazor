using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
public class SortCollection<T>
{
    private List<ISortProperty<T>> sortProperies { get; set; } = new List<ISortProperty<T>>();
    public IReadOnlyList<ISortProperty> SortProperties => sortProperies.AsReadOnly();
    public SortCollection() { }
    public SortCollection(string sortStrs) : this(sortStrs.Split(',', StringSplitOptions.RemoveEmptyEntries)) { }
    public SortCollection(IEnumerable<string> sortStrs)
    {
        if (sortStrs == null)
            return;
        foreach (var sortStr in sortStrs)
        {
            var sortProperie = Parse(sortStr);
            if (sortProperie is null) continue;
            sortProperies.Add(sortProperie);
        }
    }
    private static ISortProperty<T>? Parse(string propertyName)
    {
        propertyName = propertyName.Trim();
        var properties = typeof(T).GetProperties().ToList();
        var direction = ListSortDirection.Ascending;
        // direction Descending if prop starts with "-"
        if (propertyName.StartsWith("-"))
        {
            direction = ListSortDirection.Descending;
            propertyName = propertyName.Substring(1);
        }
        // property name cased properly
        var propertyInfo = properties.FirstOrDefault(p => p.Name.Equals(propertyName, StringComparison.OrdinalIgnoreCase));
        if (propertyInfo == default)
        {
            return null;
        }
        var type = typeof(SortProperyt<>);
        var sortElementType = type
            .MakeGenericType(
                typeof(T),
                propertyInfo.PropertyType
            );
        var ctorInfo = sortElementType
            .GetConstructor(new[] {
                typeof(PropertyInfo),
                typeof(ListSortDirection)
            });
        return ctorInfo?.Invoke(new object?[] {
            propertyInfo,
            direction
        }) as ISortProperty<T>;
    }
    //ToDo delete this method 
    public IQueryable<T> Apply(IQueryable<T> queryable)
    {
        var query = queryable;
        foreach (var sortPropertie in sortProperies)
        {
            query = sortPropertie.Apply(query);
        }
        return query;
    }
    public override string ToString()
    {
        return string.Join(",", sortProperies);
    }
    /// <summary>
    /// Creates a string with the Property Sort or Flips the direction if it exists
    /// </summary>
    /// <param name="sortProperieStr"></param>
    /// <returns></returns>
    public string AddOrUpdate(string sortProperieStr)
    {
        var sortProperie = Parse(sortProperieStr);
        if (sortProperie == default)
            return ToString();
        var sortCollection = new SortCollection<T>(ToString());
        var property = sortCollection
            .sortProperies
            .Find(x => x.PropertyName == sortProperie.PropertyName);
        if (property == null)
        {
            sortCollection.sortProperies.Add(sortProperie);
            return sortCollection.ToString();
        }
        property.SortDirection =
            property.SortDirection == ListSortDirection.Ascending
                ? ListSortDirection.Descending
                : ListSortDirection.Ascending;
        return sortCollection.ToString();
    }
    public string Remove(string element)
    {
        var parse = Parse(element);
        if (parse == null)
            return ToString();
        var sort = new SortCollection<T>(ToString());
        var property = sort
            .sortProperies
            .Find(x => x.PropertyName == parse.PropertyName);
        if (property != null)
        {
            sort.sortProperies.Remove(property);
        }
        return sort.ToString();
    }
    private class SortProperyt<TKey> : ISortProperty<T>
    {
        public SortProperyt(
            PropertyInfo propertyInfo,
            ListSortDirection direction)
        {
            PropertyName = propertyInfo.Name;
            SortDirection = direction;
            var source = Expression.Parameter(typeof(T), "entity");
            var member = Expression.Property(source, propertyInfo);
            Filter = Expression.Lambda<Func<T, TKey>>(member, source);
        }
        public string PropertyName { get; private set; }
        public ListSortDirection SortDirection { get; set; }
        public Expression<Func<T, TKey>> Filter { get; private set; }
        public IQueryable<T> Apply(IQueryable<T> queryable)
        {
            var visitor = new OrderingMethodFinder();
            visitor.Visit(queryable.Expression);
            if (visitor.OrderingMethodFound)
            {
                queryable = SortDirection == ListSortDirection.Ascending
                    ? ((IOrderedQueryable<T>)queryable).ThenBy(Filter)
                    : ((IOrderedQueryable<T>)queryable).ThenByDescending(Filter);
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
                var methodName = node.Method.Name;
                if (node.Method.DeclaringType == typeof(Queryable) && (
                    methodName.StartsWith("OrderBy", StringComparison.Ordinal) ||
                    methodName.StartsWith("ThenBy", StringComparison.Ordinal)))
                {
                    OrderingMethodFound = true;
                }
                return base.VisitMethodCall(node);
            }
        }
    }
    private interface ISortProperty<T> : ISortProperty
    {
        new ListSortDirection SortDirection { get; set; }
        IQueryable<T> Apply(IQueryable<T> queryable);
    }
    public interface ISortProperty
    {
        public string PropertyName { get; }
        public ListSortDirection SortDirection { get; }
    }
}