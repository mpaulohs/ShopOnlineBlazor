
using System.Linq.Expressions;
using Shared.Models;

namespace Shared.Services.Request.Select;

public static class SelectExtensions
{


    public static IQueryable<T> Select<T>(
                this IQueryable<T> queryable,
                string fields)

    {
        var selector = SelectExpressionGenerator<T>(fields);
        return queryable.Select<T, T>(selector);
    }


    // public static Func<T, T> SelectExpressionGenerator<T>(string fields = default)
    public static Expression<Func<T, T>> SelectExpressionGenerator<T>(string fields = default)
    {
        string[] fieldsArr = default;
        if (fields == default)
            // get Properties of the T
            fieldsArr = typeof(T).GetProperties().Select(propertyInfo => propertyInfo.Name).ToArray();
        else
        {
            fieldsArr = fields.Split(',', StringSplitOptions.RemoveEmptyEntries);
        }

        // input parameter "entity"
        var parameterExpression = Expression.Parameter(typeof(T), "entity");

        // new statement "new Data()"
        var newExpression = Expression.New(typeof(T));

        var properties = typeof(T).GetProperties().ToList();
        // create initializers
        var bindings = fieldsArr.Select(propertyName =>
            {
                propertyName = propertyName.Trim();
                var propertyInfo = properties.Find(p => p.Name.Equals(propertyName, StringComparison.OrdinalIgnoreCase));

                if (propertyInfo != default)
                {
                    // original value "o.Field1"
                    var memberExpression = Expression.Property(parameterExpression, propertyInfo);

                    // set value "Field1 = o.Field1"
                    return Expression.Bind(propertyInfo, memberExpression);
                }

                return null;
            }
        );

        // initialization "new Data { Field1 = o.Field1, Field2 = o.Field2 }"
        var memberInitExpression = Expression.MemberInit(newExpression, bindings);

        // expression "o => new Data { Field1 = o.Field1, Field2 = o.Field2 }"
        var expression = Expression.Lambda<Func<T, T>>(memberInitExpression, parameterExpression);

        // compile to Func<Data, Data>
        // return expression.Compile();

        return expression;
    }



    // Create lambda expression 
    private static Expression<Func<T, TModel>> MakeExpression<T, TModel>(params Expression<Func<T, object>>[] select)
    {
        var param = Expression.Parameter(typeof(T));

        // Map expressions [select1, ..., selectN] with properties
        // For keeping things simple I map nth expression with nth property
        // eg. select1 with first property from MyClass
        var body = Expression.MemberInit(
            Expression.New(typeof(TModel)),
            typeof(TModel)
                .GetProperties()
                .Select((p, i) => Expression.Bind(p, MakeParam(param, select[i])))
                .ToArray()
        );

        return Expression.Lambda<Func<T, TModel>>(body, param);
    }

    // Replace parameter from given expression with param
    // All expressions must have same MyEntity parameter
    private static Expression MakeParam<T>(ParameterExpression param, Expression<Func<T, object>> select)
    {
        Expression body = select.Body;

        return new ParamVisitor<T>(param).Visit(body);
    }
}

class ParamVisitor<T> : ExpressionVisitor
{
    private readonly ParameterExpression _param;

    public ParamVisitor(ParameterExpression param)
    {
        this._param = param;
    }

    protected override Expression VisitParameter(ParameterExpression node)
    {
        if (node.Type == typeof(T))
        {
            return this._param;
        }

        return base.VisitParameter(node);
    }
}
