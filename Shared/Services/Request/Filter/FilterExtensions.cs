using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace Shared.Services.Request.Filter;

public static class FilterExtensions
{

    public static IQueryable<T> FilterByRules<T>(this IQueryable<T> queryable, string rules)
    {
        var rulesArr = rules.Split(";", StringSplitOptions.RemoveEmptyEntries);
        var rulesList = new List<FilterRule>();
        foreach (var rule in rulesArr)
        {
            var nod = rule.Split(":", StringSplitOptions.RemoveEmptyEntries);
            if (nod.Length == 3)
            {

                rulesList.Add(new FilterRule(nod[0], nod[1], nod[2]));
            }
        }
        return queryable.FilterByRules(rulesList);
    }



    private static IQueryable<T> FilterByRules<T>(this IQueryable<T> queryable, IEnumerable<FilterRule> rules)
    {
        var parameter = Expression.Parameter(typeof(T));
        BinaryExpression expression = default;
        foreach (var rule in rules)
        {
            var property = Expression.Property(parameter, rule.PropertyName);
            var value = Expression.Constant(rule.Value);
            var expressionNew = Expression.MakeBinary(rule.Operation.ExpressionType, property, value);
            expression = expression == default ? expressionNew : Expression.MakeBinary(ExpressionType.AndAlso, expression, expressionNew);

        }
        var cookedExpression = Expression.Lambda<Func<T, bool>>(expression, parameter);
        return queryable.Where(cookedExpression);
    }

}