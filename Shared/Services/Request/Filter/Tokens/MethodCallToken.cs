namespace Shared.Services.Request.Pagination.Tokens
{
    public class MethodCallToken : Token
    {
        public string MethodName { get; set; }

        public MethodCallToken(string methodName)
        {
            MethodName = methodName;
        }

        public override string ToString()
        {
            return "Method call token:\t" + MethodName;
        }
    }
}