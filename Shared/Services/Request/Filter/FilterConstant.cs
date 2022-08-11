using System.Linq.Expressions;

namespace Shared.Services.Request.Filter;

class FilterConstant<T>
{
    public static ConstantExpression GetExecutionContext(T value)
    {
        return Expression.Constant(value, typeof(T));
    }
}