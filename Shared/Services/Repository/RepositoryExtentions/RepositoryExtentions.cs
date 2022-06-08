using Shared.Models;
using Shared.Models.Catalogs;
using System.Linq.Expressions;

namespace Shared.Services.Repository.RepositoryExtentions
{

    //ToDo repear this function
    public static class RepositoryExtentions
    {
        public static IQueryable<TEntity> Search<TEntity, TKey>(this IQueryable<TEntity> source, string searchTerm)
        where TEntity : class, IApplicationEntity<TKey>
        where TKey : IEquatable<TKey>

        {               
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return source;
            }

            var search = searchTerm.ToLower();

            //var result = source.Where(delegate (TEntity e)
            //{

            // var val = e.ToString().ToLower();

            // var res = val.Contains("11");

            // return res;
            //});

            //Func<TEntity, bool> predicate = delegate(TEntity entity) {

            //    var name = entity.ToString();
            //    var lName = name.ToLower();
            //    var res =lName.Contains(search);
            //    return res;
            //};

            //Expression<Func<TEntity, bool>> filter = e => e.ToString().ToLower().Contains(search);

            Expression<Func<TEntity, bool>> filter = e => e.Id.ToString().Contains(search);

            Expression <Action<TEntity>> action = e => Console.WriteLine(e.ToString());

            //Expression<Func<TEntity, bool>> filter = e => e.ToString().Contains(search);

            Expression<Func<TEntity, bool>> filter2 = e => e.ToString().Contains(search);

            //Expression<Func<TEntity, bool>> filter = new Expression<predicate>();

            //Func<TEntity, bool> predicate = e => e.ToString().ToLower().Contains(search);

            //source.For

            var res = source.Where(filter);

           return res;

            //return result;

            //Predicate<TEntity> filter = delegate (TEntity e)
            //{

            // var val = e.ToString().ToLower();

            // var res = val.Contains("11");

            // return res;
            //};

            //// source = IQueryable <TEntity as CatalogBase<TKey>> source;

            //Type type = typeof(TEntity);

            //PropertyInfo prop = type.GetProperty("Name");

            //var lowerCaseSearchTerm = searchTerm.Trim().ToLower();

            //var filter = delegate (TEntity entity)
            //{
            // //var val = prop.GetValue(entity).ToString().ToLower();

            // //var res = val.Contains(lowerCaseSearchTerm);

            // //return res;

            // return entity.ToString().Contains("11");

            //};

            //if (typeof(TEntity).IsSubclassOf(typeof(CatalogBase<TKey>)))
            //{

            // //return source.Where(e => prop
            // // .GetValue(e)
            // // .ToString()
            // // .ToLower()
            // // .Contains(lowerCaseSearchTerm)
            // //);

            // var filteredsource = source.Where(e => filter(e));
            // return filteredsource;
            //}

            //return source;




        }
    }
}
