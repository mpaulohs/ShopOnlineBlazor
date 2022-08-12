using System.Linq.Expressions;

namespace Shared.Services.Request.Filter;

public static class FilterExtensions
{
    public static IQueryable<T> FilterByRules<T>(this IQueryable<T> queryable, IEnumerable<FilterRule> rules)
    {
        var parameter = Expression.Parameter(typeof(T));
        BinaryExpression expression = default;
        foreach (var rule in rules)
        {
            var property = Expression.Property(parameter, rule.PropertyName);
            var value = Expression.Constant(rule.Value);
            var expressionNew = Expression.MakeBinary(rule.Operator.ExpressionType, property, value);
            expression = expression == default ? expressionNew : Expression.MakeBinary(ExpressionType.AndAlso, expression, expressionNew);
            queryable = queryable.Provider.CreateQuery<T>(expression);
        }
        return queryable;
    }
}