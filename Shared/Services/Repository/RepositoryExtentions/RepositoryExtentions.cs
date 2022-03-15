using SharedLib.Models.Catalogs;

namespace SharedLib.Services.Repository.RepositoryExtentions
{
    public static class RepositoryExtentions
    {
        public static IQueryable<TEntity>? Search<TEntity>(this IQueryable<TEntity> entities, string searchTerm) where TEntity : CatalogBase<Guid>
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return entities;
            var lowerCaseSearchTerm = searchTerm.Trim().ToLower();
            return entities.Where(e => e.CreatedAt.ToString().ToLower().Contains(lowerCaseSearchTerm));
        }
    }
}
