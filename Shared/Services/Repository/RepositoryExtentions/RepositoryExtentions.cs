using SharedLib.Models;
using SharedLib.Models.Catalogs;

namespace SharedLib.Services.Repository.RepositoryExtentions
{
    public static class RepositoryExtentions
    {
        public static IQueryable<TEntity> Search<TEntity, TKey>(this IQueryable<TEntity> source, string searchTerm)
        where TEntity : class, IApplicationEntity<TKey>
        where TKey : IEquatable<TKey>
            // where TEntity : CatalogBase<Guid>, IApplicationEntity<Guid>
            //where TKey : IEquatable<TKey>

        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return source;
            }



            // source = IQueryable <TEntity as CatalogBase<TKey>> source;

            if (typeof(TEntity).IsSubclassOf(typeof(CatalogBase<TKey>)))
            {
                var lowerCaseSearchTerm = searchTerm.Trim().ToLower();

                 return source.Where(e =>(e as CatalogBase<TEntity>).Name.ToLower().Contains(lowerCaseSearchTerm));
      
            }
            return source;
           
        }
    }
}
