using System.Linq.Expressions;
using System.Reflection;
namespace Shared.Services.Request.Search
{
    public static class SearchExtensions
    {
        public static IQueryable<T> Search<T>(this IQueryable<T> queryable, string search)
        {
            Expression expression = default;
            var elementType = typeof(T);
            var propertyes = elementType.GetProperties();
            var parameter = Expression.Parameter(elementType);
            foreach (var property in propertyes)
            {
                try
                {
                    //ToDo check if can update this check
                    // var notHaveToString = property.GetType().GetMethod("ToString") == null;
                    // if (notHaveToString)
                    // {
                    //     continue;
                    // }
                    var member = Expression.PropertyOrField(parameter, property.Name);
                    MethodInfo method = typeof(string).GetMethod("Contains", new[] { typeof(string) });
                    var value = Expression.Constant(search, typeof(string));
                    var expressionContains = Expression.Call(member, method, value);
                    expression = expression == default ? expressionContains : Expression.MakeBinary(ExpressionType.OrElse, expression, expressionContains);
                }
                catch (Exception)
                {
                    continue;
                }
            }
            if (expression == default)
            {
                return queryable;
            }
            var expressionLambda = Expression.Lambda<Func<T, bool>>(expression, parameter);
            return queryable.Where(expressionLambda);
        }
    }
}
