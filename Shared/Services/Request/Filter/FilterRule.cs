namespace Shared.Services.Request.Filter;
public class FilterRule
{
    public string PropertyName { get; set; }
    public FilterOperation Operation { get; set; }
    public object Value { get; set; }


    public FilterRule(string propertyName, string symbol, object value)
    {
        PropertyName = propertyName;
        Operation = FilterOperation.GetOperation(symbol: symbol);
        Value = value;
    }

}