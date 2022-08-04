namespace Shared.Services.Request.Pagination.Tokens.Common.Tokens
{
    public class BinaryOperatorToken : Token
    {
        public FilterOperator Operator { get; set; }

        public BinaryOperatorToken(FilterOperator op)
        {
            Operator = op;
        }

        public override string ToString()
        {
            return "Binary operator token:\t" + Operator.ToString();
        }
    }
}
