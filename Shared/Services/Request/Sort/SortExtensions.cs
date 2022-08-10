using Shared.Models;
namespace Shared.Services.Request.Sort
{
    public static class SortExtensions
    {
        public static IQueryable<TEntity> Sort<TEntity>(
            this IQueryable<TEntity> queryable,
            string sorts)
        {
            var sort = new SortCollection<TEntity>(sorts);
            return sort.Apply(queryable);
        }
        public static IQueryable<TEntity> Sort<TEntity>(
            this IQueryable<TEntity> queryable,
            params string[] sorts)
        {
            var sort = new SortCollection<TEntity>(sorts);
            return sort.Apply(queryable);
        }
        public static IQueryable<TEntity> Sort<TEntity>(
            this IQueryable<TEntity> queryable,
            string sorts,
            out SortCollection<TEntity> sortCollection)
        {
            sortCollection = new SortCollection<TEntity>(sorts);
            return sortCollection.Apply(queryable);
        }
    }
}
