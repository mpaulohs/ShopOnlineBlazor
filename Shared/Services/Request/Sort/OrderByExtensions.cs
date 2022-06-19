using Shared.Models;

namespace Shared.Services.Request.Sort
{
    public static class OrderByExtensions
    {
        public static IQueryable<TEntity> OrderBy<TEntity, TKey>(
            this IQueryable<TEntity> queryable,
            string sorts)
            where TEntity : class, IApplicationEntity<TKey>
            where TKey : IEquatable<TKey>

        {
            var sort = new SortCollection<TEntity>(sorts);
            return sort.Apply(queryable);
        }

        public static IQueryable<TEntity> OrderBy<TEntity, TKey>(
            this IQueryable<TEntity> queryable,
            params string[] sorts)
             where TEntity : class, IApplicationEntity<TKey>
            where TKey : IEquatable<TKey>
        {
            var sort = new SortCollection<TEntity>(sorts);
            return sort.Apply(queryable);
        }

        public static IQueryable<TEntity> OrderBy<TEntity, TKey>(
            this IQueryable<TEntity> queryable,
            string sorts,
            out SortCollection<TEntity> sortCollection)
             where TEntity : class, IApplicationEntity<TKey>
            where TKey : IEquatable<TKey>
        {
            sortCollection = new SortCollection<TEntity>(sorts);
            return sortCollection.Apply(queryable);
        }
    }
}
