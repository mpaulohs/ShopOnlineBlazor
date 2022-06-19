using System;

namespace FilterExpression.Tokens
{
    public class ParameterToken : Token
    {
        public string ParameterName { get; set; }
        public Type Type { get; set; }

        public ParameterToken(string name, Type type)
        {
            ParameterName = name;
            Type = type;
        }

        public override string ToString()
        {
            return "Parameter token:\t\t" + ParameterName;
        }
    }
}
