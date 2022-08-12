using System.Linq.Expressions;

namespace Shared.Services.Request.OrderBy;

public static class OrderByExtensions
{
    public static IQueryable<T> OrderByPropertyOrField<T>(this IQueryable<T> queryable, string orderBy)
    {
        var orderBys = orderBy.Split(":", StringSplitOptions.RemoveEmptyEntries);
        string orderByMethodName = default;

        foreach (var order in orderBys)
        {
            var propertyOrFieldName = order.Trim();

            if (propertyOrFieldName.StartsWith("-"))
            {
                orderByMethodName = orderByMethodName == default ? "OrderByDescending" : "ThenByDescending";
                propertyOrFieldName = propertyOrFieldName.Substring(1).Trim();
            }
            else
            {
                orderByMethodName = orderByMethodName == default ? "OrderBy" : "ThenBy";
            }
            var elementType = typeof(T);
            var parameter = Expression.Parameter(elementType);
            var property = Expression.PropertyOrField(parameter, propertyOrFieldName);
            var selector = Expression.Lambda(property, parameter);
            var orderByExpression = Expression.Call(
                typeof(Queryable),
                orderByMethodName,
                new[] { elementType, property.Type },
                queryable.Expression,
                selector
            );
            queryable = queryable.Provider.CreateQuery<T>(orderByExpression);
        }
        return queryable;
    }
}

