namespace FilterExpression.Tokens
{
    public class UnaryOperatorToken : Token
    {
        public FilterOperator Operator { get; set; }

        public UnaryOperatorToken(FilterOperator op)
        {
            Operator = op;
        }

        public override string ToString()
        {
            return "Unary operator token:\t\t" + Operator.ToString();
        }
    }
}
