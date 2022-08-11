using System.Linq.Expressions;

namespace Shared.Services.Request.Filter;
class FilterParameter<T>
{
    public static ParameterExpression GetParameter()
    {
        return Expression.Parameter(typeof(T), "entity");
    }

    public static ParameterExpression? GetParameter(string propertyName)
    {
        var properties = typeof(T).GetProperties();
        var propertyInfo = properties.FirstOrDefault(p => p.Name.Equals(propertyName, StringComparison.OrdinalIgnoreCase));
        if (propertyInfo != default)
        {
            return Expression.Parameter(propertyInfo.PropertyType, "entity");
        }
        return null;
    }
}