namespace Shared.Services.Request.Filter;
public class FilterRule
{
    public string PropertyName { get; set; }
    public FilterOperation Operation { get; set; }
    public object Value { get; set; }

}