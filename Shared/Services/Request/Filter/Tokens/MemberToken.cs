using System;

namespace FilterExpression.Tokens
{
    public class MemberToken : Token
    {
        public Type Type { get; set; }

        public string MemberName { get; set; }

        public MemberToken(string memberName, Type type)
        {
            MemberName = memberName;
            Type = type;
        }

        public override string ToString()
        {
            return "Member token:\t\t" + MemberName;
        }
    }
}
