using System.Linq.Expressions;

namespace Shared.Services.Request.Filter;

class FilterOperator
{
    public ExpressionType ExpressionType { get; set; }
    public string Name { get; set; }
    public string ShortName { get; set; }
    public string Symbol { get; set; }
    public string Description { get; set; }

    public FilterOperator(ExpressionType expressionType, string name, string shortName, string symbol, string description)
    {
        ExpressionType = expressionType;
        Name = name;
        ShortName = shortName;
        Symbol = symbol;
        Description = description;
    }

    private static IEnumerable<FilterOperator> filterOperators = generate();

    public static IEnumerable<FilterOperator> GetGetFilterOperators(ExpressionType expressionType = default, string name = default, string shortName = default, string symbol = default)
    {
        var result = filterOperators;
        if (expressionType != default)
        {
            result = result.Where(f => f.Equals(expressionType));
        }
        if (name != default)
        {
            result = result.Where(f => f.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
        }
        if (shortName != default)
        {
            result = result.Where(f => f.ShortName.Equals(shortName, StringComparison.CurrentCultureIgnoreCase));
        }
        if (symbol != default)
        {
            result = result.Where(f => f.Symbol.Equals(symbol));
        }
        return result;
    }
    private static IEnumerable<FilterOperator> generate()
    {
        var filterOperators = new List<FilterOperator>();
        filterOperators.Add(new FilterOperator(ExpressionType.Equal, "Equal", "eg", "=", "represent equal operator"));
        filterOperators.Add(new FilterOperator(ExpressionType.NotEqual, "Not equal", "neg", "!=", "represent not equal operator"));
        filterOperators.Add(new FilterOperator(ExpressionType.GreaterThan, "Greater than", "gt", ">", "represent greater than operator"));
        filterOperators.Add(new FilterOperator(ExpressionType.GreaterThanOrEqual, "Greater than or equal", "gte", ">=", "rgepresent greater than or equal operator"));
        filterOperators.Add(new FilterOperator(ExpressionType.LessThan, "Less than", "lt", "<", "rgepresent less than operator"));
        filterOperators.Add(new FilterOperator(ExpressionType.LessThanOrEqual, "Less than or equal", "lte", "<=", "rgepresent less than or equal operator"));
        return filterOperators;
    }
}