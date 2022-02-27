namespace Shared.Services.Request.Pagination
{

    public class PaginationList<TEntity> : List<TEntity>
    {
        public IEnumerable<TEntity> Entities { get; set; }

        public PaginationMetaData MetaData { get; set; }

        public PaginationList()
        {

        }

        public PaginationList(List<TEntity> items, int count, int pageNumber, int pageSize)
        {
            MetaData = new PaginationMetaData
            {
                TotalCount = count,
                PageSize = pageSize,
                CurrentPage = pageNumber,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize)
            };
            AddRange(items);
        }

          public static PaginationList<TEntity> ToPaginationList(IEnumerable<TEntity> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var items = source
              .Skip((pageNumber - 1) * pageSize)
              .Take(pageSize).ToList();
            return new PaginationList<TEntity>(items, count, pageNumber, pageSize);
        }
    }

}
