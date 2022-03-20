using SharedLib.Models.Catalogs;

namespace SharedLib.Services.Repository.RepositoryExtentions
{
    public static class RepositoryExtentions
    {
        public static IQueryable<TResult> Search<TSource, TResult>(this IQueryable<TSource> source, string searchTerm)
           where TSource : CatalogBase<Guid>
           where TResult : CatalogBase<Guid>
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return (IQueryable<TResult>)source;
            }

            var lowerCaseSearchTerm = searchTerm.Trim().ToLower();
            return (IQueryable<TResult>)source.Where(e => e.Name.ToLower().Contains(lowerCaseSearchTerm));
        }
    }
}
