namespace Shared.Services.Request.Pagination.Tokens
{
    public class ConstantToken : Token
    {
        public object Value { get; set; }

        public ConstantToken(object value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return "Constant token:\t\t" + Value.ToString();
        }
    }
}
