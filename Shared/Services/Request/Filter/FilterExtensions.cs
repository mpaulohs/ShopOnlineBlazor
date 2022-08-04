using System.Text;
using System.Collections.Generic;
using Shared.Services.Request.Pagination;
using System.Linq.Expressions;
using Shared.Models;
using System.Linq.Dynamic.Core;

namespace Shared.Services.Request.Pagination
{
    public static class FilterExtensions
    {
        public static string ToQueryString(this IList<FilterNode> filters)
        {
            var gueryString = new StringBuilder();

            for (var i = 0; i < filters.Count; i++)
            {
                gueryString.Append(
                    $"{filters[i].FieldName}:" +
                    $"{filters[i].Operator}:" +
                    $"{filters[i].Value};");
                if (i < filters.Count - 1)
                {
                    gueryString.Length--;
                    gueryString.Append("&");
                }
            }

            return gueryString.ToString();
        }

        public static Dictionary<ExpressionType, FilterOperator> _operatorMap = new Dictionary<ExpressionType, FilterOperator>
        {
            { ExpressionType.AndAlso           , FilterOperator.and },
            { ExpressionType.OrElse            , FilterOperator.or  },
            { ExpressionType.Not               , FilterOperator.not },
            { ExpressionType.Equal             , FilterOperator.eq  },
            { ExpressionType.NotEqual          , FilterOperator.neq },
            { ExpressionType.LessThan          , FilterOperator.lt  },
            { ExpressionType.LessThanOrEqual   , FilterOperator.lte },
            { ExpressionType.GreaterThan       , FilterOperator.gt  },
            { ExpressionType.GreaterThanOrEqual, FilterOperator.gte },
        };

        public static Dictionary<string, FilterOperator> _methodCallMap = new Dictionary<string, FilterOperator>
        {
            { "StartsWith"   , FilterOperator.bw },
            { "Contains"     , FilterOperator.ct   },
            { "EndsWith"     , FilterOperator.ev   },
            { "NotStartsWith", FilterOperator.nbw },
            { "NotContains"  , FilterOperator.nct   },
            { "NotEndsWith"  , FilterOperator.nev   }
        };

        public static string[] _supprtedMethodNames = new[]
        {
            nameof(string.StartsWith),
            nameof(string.Contains),
            nameof(string.EndsWith)
        };

        public static string QueryStringToString(string query)
        {
            var nodes = query.Split(';', StringSplitOptions.RemoveEmptyEntries);
            var result = new StringBuilder("(item)=>");
            foreach (var item in nodes)
            {
                var items = item.Split(':');
                if (items.Length == 3)
                {
                    result.Append("(item)." + items[0]).Append(items[1]).Append(items[2]);
                }
            }
            return result.ToString();
        }

        public class NodOparator
        {
            public string Name { get; set; }
            public System.Type Type { get; set; }
            public string ShorName { get; set; } = default;
            public string Symbol { get; set; } = default;
            public string Description { get; set; } = default;

            public NodOparator(string name, System.Type type, string shortName, string symbol, string destination)
            {
                this.Name = name;
                this.Type = type;
                this.ShorName = shortName;
                this.Symbol = symbol;
                this.Description = destination;
            }
        }

        public static List<NodOparator> NodOparatorsMap { get; } = new List<NodOparator>() {
            new NodOparator("AndAlso", typeof(ExpressionType),"and","&&","Logical and."),
            new NodOparator("OrElse", typeof(ExpressionType),"or","||","Logical or."),
            new NodOparator("Not", typeof(ExpressionType),"not","!","Logical not."),

            new NodOparator("Equal", typeof(ExpressionType),"eq","!=","Returns entries where the field is equal to the value."),
            new NodOparator("NotEqual", typeof(ExpressionType),"neq","!=","Returns entries where the field is not equal to the value."),
            new NodOparator("LessThan", typeof(ExpressionType),"lt","<","Returns entries where the field is lower than the value."),
            new NodOparator("LessThanOrEqual", typeof(ExpressionType),"lte","<=","Returns entries where the field is lower than or equal to the value."),
            new NodOparator("GreaterThan", typeof(ExpressionType),"gt",">","Returns entries where the field is greater than the value."),
            new NodOparator("GreaterThanOrEqual", typeof(ExpressionType),"gte",">=","Returns entries where the field is greater than or equal to the value."),

            new NodOparator("Contains", typeof(string),"ct","Contains","Returns entries where the field contains the value."),
            new NodOparator("NotContains", typeof(string),"nct","NotContains","Returns entries where the field does not contain the value."),
            new NodOparator("EndsWith", typeof(string),"e","EndsWith","Returns entries where the field ends with the value."),
            new NodOparator("NotEndsWith", typeof(string),"ne","NotEndsWith","Returns entries where the field does not end with the value."),
            new NodOparator("StartsWith", typeof(string),"bw","StartsWith","Returns entries where the field begins with the value."),
            new NodOparator("NotStartsWith", typeof(string),"nbw","NotStartsWith","Returns entries where the field does not begin with the value.")

    };

        public static Expression<Func<TEntity, bool>> ToExpression<TEntity, TKey>(string strExpression)
        {
            // strExpression = "x => x.Property0 == \"Z\" && old.Any(y => y.Key0 == x.Key0 && y.Property0 != x.Property0)";

            var parameterExpression = Expression<TEntity>.Parameter(typeof(TEntity), "Entity");

            var expression = DynamicExpressionParser.ParseLambda<TEntity, bool>(new ParsingConfig(), false, strExpression, new[] { parameterExpression });

            System.Console.WriteLine(expression.Body);

            var function = expression.Compile();

            return expression;
        }


        public static string ToExpressionString(string queryString)
        {
            var nodes = queryString.Split(';', StringSplitOptions.RemoveEmptyEntries);
            var result = new StringBuilder("(item)=>");
            foreach (var item in nodes)
            {
                var items = item.Split(':');
                if (items.Length == 3)
                {
                    result.Append("(item)." + items[0]).Append(" " + GetSymbol(items[1])).Append(" (item)." + items[2]).Append(" And ");
                }
            }
            result.Length = result.Length - 5;
            result.Append(";");
            return result.ToString();
        }

        public static string GetSymbol(string nodeElement)
        {
            var node = NodOparatorsMap.Find(e => e.Name == nodeElement);
            return node == default ? nodeElement : node.Symbol;
        }
    };
}
