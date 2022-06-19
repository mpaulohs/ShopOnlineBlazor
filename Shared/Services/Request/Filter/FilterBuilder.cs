using FilterExpression.Tokens;
using FilterExpression.Tokens.Common.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FilterExpression
{
    public class FilterBuilder : ExpressionVisitor
    {
        private List<Token> _tokens = new List<Token>();

       

        // for demo purposes
        public List<Token> Tokens => _tokens;

        public FilterBuilder(Expression expression)
        {
            var fixer = new BooleanVisitor();
            var fixedExpression = fixer.Visit(expression);
            base.Visit(fixedExpression);
        }

        public IEnumerable<FilterNode> Build()
        {
            var filters = new Stack<FilterNode>();

            for (var i = 0; i < _tokens.Count; i++)
            {
                var token = _tokens[i];

                switch (token)
                {
                    case ParameterToken p:
                        var f = getFilter();
                        f.FieldName = p.ParameterName;
                        filters.Push(f);
                        break;

                    case BinaryOperatorToken b:
                        var f1 = getFilter();

                        switch (b.Operator)
                        {
                            case FilterOperator.and:
                            case FilterOperator.or:
                                var ff = filters.Pop();
                                ff.CompositionOperator = b.Operator;
                                filters.Push(ff);
                                break;

                            case FilterOperator.eq:
                            case FilterOperator.neq:
                            case FilterOperator.lt:
                            case FilterOperator.lte:
                            case FilterOperator.gt:
                            case FilterOperator.gte:
                                f1.Operator = b.Operator;
                                filters.Push(f1);
                                break;
                        }

                        break;

                    case ConstantToken c:
                        var f2 = getFilter();
                        f2.Value = c.Value;
                        filters.Push(f2);
                        break;

                    case MemberToken m:
                        var f3 = getFilter();
                        f3.FieldName = m.MemberName.Split('.').Last<string>().ToString();
                        filters.Push(f3);
                        break;

                    case UnaryOperatorToken u:
                        var f4 = getFilter();
                        f4.Operator = u.Operator;
                        f4.Value = true;
                        filters.Push(f4);
                        break;

                    case MethodCallToken mc:
                        var f5 = getFilter();
                        f5.Operator = FilterExtensions._methodCallMap[mc.MethodName];
                        //f5.Value = mc.Args[0];
                        filters.Push(f5);
                        break;
                }
            }

            var output = new Stack<FilterNode>();

            while (filters.Any())
            {
                output.Push(filters.Pop());
            }

            return output;

            FilterNode getFilter()
            {
                if (filters.Any())
                {
                    var f = filters.First();

                    var incomplete = f.Operator == default ||
                                     f.CompositionOperator == default ||
                                     f.FieldName == default ||
                                     f.Value == default;

                    if (incomplete)
                        return filters.Pop();

                    return new FilterNode();
                }

                return new FilterNode();
            }
        }

        #region Overrides

        protected override Expression VisitBinary(BinaryExpression node)
        {
            base.Visit(node.Left);
            base.Visit(node.Right);

            switch (node.NodeType)
            {
                case ExpressionType.OrElse:
                case ExpressionType.AndAlso:
                case ExpressionType.Equal:
                case ExpressionType.NotEqual:
                case ExpressionType.LessThanOrEqual:
                case ExpressionType.LessThan:
                case ExpressionType.GreaterThan:
                case ExpressionType.GreaterThanOrEqual:
                    _tokens.Add(new BinaryOperatorToken(FilterExtensions._operatorMap[node.NodeType]));
                    break;
            }

            return node;
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            _tokens.Add(new ConstantToken(node.Value));
            return node;
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            if (node.Type == typeof(DateTime))
            {
                if (node.Expression == null)
                {
                    var lambda = Expression.Lambda<Func<DateTime>>(node);
                    var dateTime = lambda.Compile()();
                    base.Visit(Expression.Constant(dateTime.Ticks));
                    return node;
                }
                else
                {
                    switch (node.Expression.NodeType)
                    {
                        case ExpressionType.New:
                            var lambda = Expression.Lambda<Func<DateTime>>(node.Expression);
                            var dateTime = lambda.Compile()();
                            base.Visit(Expression.Constant(dateTime.Ticks));
                            return node;

                        case ExpressionType.MemberAccess:                            
                            if (node.Member.Name != ((MemberExpression)node.Expression).Member.Name)
                            {
                                var lambda2 = Expression.Lambda<Func<DateTime>>(node);
                                var dateTime2 = lambda2.Compile()();
                                base.Visit(Expression.Constant(dateTime2.Ticks));
                                return node;
                            }
                            break;
                    }
                }
            }

            _tokens.Add(new MemberToken(node.Expression + "." + node.Member.Name, node.Type));
            return node;
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            if (!FilterExtensions._supprtedMethodNames.Contains(node.Method.Name))
                throw new NotSupportedException($"{node.Method.Name} method is not supported.");

            base.Visit(node.Object);
            base.Visit(node.Arguments);
            _tokens.Add(new MethodCallToken(node.Method.Name));
            return node;
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            base.Visit(node.Operand);

            if (node.NodeType == ExpressionType.Not)
            {
                var token = _tokens.Last();

                if (token is BinaryOperatorToken binaryToken)
                {
                    switch (binaryToken.Operator)
                    {
                        case FilterOperator.eq:
                            binaryToken.Operator = FilterOperator.neq;
                            break;

                        case FilterOperator.neq:
                            binaryToken.Operator = FilterOperator.eq;
                            break;

                        case FilterOperator.lt:
                            binaryToken.Operator = FilterOperator.gte;
                            break;

                        case FilterOperator.lte:
                            binaryToken.Operator = FilterOperator.gt;
                            break;

                        case FilterOperator.gt:
                            binaryToken.Operator = FilterOperator.lte;
                            break;

                        case FilterOperator.gte:
                            binaryToken.Operator = FilterOperator.lt;
                            break;
                    }
                }
                else if (token is MethodCallToken callToken)
                {
                    switch (callToken.MethodName)
                    {
                        case nameof(FilterOperator.bw):
                            callToken.MethodName = nameof(FilterOperator.nbw);
                            break;

                        case nameof(FilterOperator.ct):
                            callToken.MethodName = nameof(FilterOperator.nct);
                            break;

                        case nameof(FilterOperator.ev):
                            callToken.MethodName = nameof(FilterOperator.nev);
                            break;
                    }
                }
            }

            return node;
        }

        protected override Expression VisitNew(NewExpression node)
        {
            if (node.Type == typeof(DateTime))
            {
                var lambda = Expression.Lambda<Func<DateTime>>(node);
                var dateTime = lambda.Compile()();
                base.Visit(Expression.Constant(dateTime.Ticks));
                return node;
            }

            return base.VisitNew(node);
        }

        #endregion

        private class BooleanVisitor : ExpressionVisitor
        {
            protected override Expression VisitMember(MemberExpression node)
            {
                if (node.Type == typeof(bool))
                {
                    return Expression.MakeBinary(ExpressionType.Equal, node, Expression.Constant(true));
                }

                return base.VisitMember(node);
            }
        }
    }
}
