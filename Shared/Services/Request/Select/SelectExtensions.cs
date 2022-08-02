
using System.Linq.Expressions;
using Shared.Models;

namespace Shared.Services.Request.Select;

public static class SelectExtensions
{


    public static IQueryable<TEntity> Select<TEntity, TKey>(
                this IQueryable<TEntity> queryable,
                string fields)
                where TEntity : class, IApplicationEntity<TKey>
                where TKey : IEquatable<TKey>
    {
        var selector = SelectExpressionGenerator<TEntity>(fields);
        return queryable.Select<TEntity, TEntity>(selector);
    }


    // public static Func<T, T> SelectExpressionGenerator<T>(string fields = default)
    public static Expression<Func<T, T>> SelectExpressionGenerator<T>(string fields = default)
    {
        string[] fildsList;
        if (fields == default)
            // get Properties of the T
            fildsList = typeof(T).GetProperties().Select(propertyInfo => propertyInfo.Name).ToArray();
        else
        {
            fildsList = fields.Split(',', StringSplitOptions.RemoveEmptyEntries);
        }

        // input parameter "o"
        var parameterExpression = Expression.Parameter(typeof(T), "entity");

        // new statement "new Data()"
        var newExpression = Expression.New(typeof(T));

        // create initializers
        var bindings = fildsList.Select(entity =>
            {
                var propertyName = entity.Trim();
                var properties = typeof(T).GetProperties().ToList();
                var propertyInfo = properties.Find(p => p.Name.Equals(propertyName, StringComparison.OrdinalIgnoreCase));

                // original value "o.Field1"
                var memberExpression = Expression.Property(parameterExpression, propertyInfo);
                // set value "Field1 = o.Field1"
                return Expression.Bind(propertyInfo, memberExpression);
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
    private static Expression<Func<TEntity, TModel>> MakeExpression<TEntity, TModel>(params Expression<Func<TEntity, object>>[] select)
    {
        var param = Expression.Parameter(typeof(TEntity));

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

        return Expression.Lambda<Func<TEntity, TModel>>(body, param);
    }

    // Replace parameter from given expression with param
    // All expressions must have same MyEntity parameter
    private static Expression MakeParam<TEntity>(ParameterExpression param, Expression<Func<TEntity, object>> select)
    {
        Expression body = select.Body;

        return new ParamVisitor<TEntity>(param).Visit(body);
    }
}

class ParamVisitor<TEntity> : ExpressionVisitor
{
    private readonly ParameterExpression _param;

    public ParamVisitor(ParameterExpression param)
    {
        this._param = param;
    }

    protected override Expression VisitParameter(ParameterExpression node)
    {
        if (node.Type == typeof(TEntity))
        {
            return this._param;
        }

        return base.VisitParameter(node);
    }
}
