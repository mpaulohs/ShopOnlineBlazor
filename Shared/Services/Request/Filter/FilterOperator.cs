using System.Linq.Expressions;
namespace Shared.Services.Request.Filter;
public class FilterOperation
{
    public ExpressionType ExpressionType { get; set; }
    public string Name { get; set; }
    public string ShortName { get; set; }
    public string Symbol { get; set; }
    public string Description { get; set; }
    public FilterOperation(ExpressionType expressionType, string name, string shortName, string symbol, string description)
    {
        ExpressionType = expressionType;
        Name = name;
        ShortName = shortName;
        Symbol = symbol;
        Description = description;
    }
    public static FilterOperation GetOperation(ExpressionType expressionType = default, string name = default, string shortName = default, string symbol = default)
    {
        if (expressionType != default)
        {
            return operations.FirstOrDefault(f => f.ExpressionType.Equals(expressionType));
        }
        if (name != default)
        {
            return operations.FirstOrDefault(f => f.Name.Equals(name));
        }
        if (shortName != default)
        {
            return operations.FirstOrDefault(f => f.ShortName.Equals(shortName));
        }
        if (symbol != default)
        {
            return operations.FirstOrDefault(f => f.Symbol.Equals(symbol));
        }
        return default;
    }
    private readonly static FilterOperation[] operations = new[]
    {
        new FilterOperation(ExpressionType.Equal, "Equal", "eq", "=", "represent equal operator"),
        new FilterOperation(ExpressionType.NotEqual, "Not equal", "neq", "!=", "represent not equal operator"),
        new FilterOperation(ExpressionType.GreaterThan, "Greater than", "gt", ">", "represent greater than operator"),
        new FilterOperation(ExpressionType.GreaterThanOrEqual, "Greater than or equal", "gte", ">=", "rgepresent greater than or equal operator"),
        new FilterOperation(ExpressionType.LessThan, "Less than", "lt", "<", "rgepresent less than operator"),
        new FilterOperation(ExpressionType.LessThanOrEqual, "Less than or equal", "lte", "<=", "rgepresent less than or equal operator")
    };
}