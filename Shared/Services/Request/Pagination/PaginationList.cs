namespace Shared.Services.Request.Pagination
{
    public class PaginationList<TEntity> : List<TEntity>
    {
        public IEnumerable<TEntity> Entities { get; set; }
        public PaginationMetaData MetaData { get; set; }
        public PaginationList()
        {
        }
        public PaginationList(List<TEntity> items, int count, int curentPage, int pageSize)
        {
            MetaData = new PaginationMetaData
            {
                TotalCount = count,
                PageSize = pageSize,
                CurrentPage = curentPage,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize)
            };
            AddRange(items);
        }
        public static PaginationList<TEntity> ToPaginationList(IEnumerable<TEntity> source, int curentPage, int pageSize)
        {
            var count = source.Count();
            var items = source
              .Skip((curentPage - 1) * pageSize)
              .Take(pageSize).ToList();
            return new PaginationList<TEntity>(items, count, curentPage, pageSize);
        }
    }
}
