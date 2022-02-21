namespace Shared.Views.Pagination
{
    public class PaginationEntitiesMetaData
    {
        public int Count { get; set; }

        public int Limit { get; set; }

        public int Offset { get; set; }

        public PaginationEntitiesMetaData(int count, int limit = default, int offset = default)
        {


            if (count<0||limit<0||offset<0)
            {
                throw new ArgumentNullException();
            }

            Count   = count;

            Limit = limit;
            
            Offset = offset;

        }

        public static PaginationEntitiesMetaData ToPaginationEntitiesMetaData(PaginationPagesMetaData paginationPagesMetaData)
        {
            return new PaginationEntitiesMetaData(
                count: paginationPagesMetaData.TotalCount,
                limit: paginationPagesMetaData.PageSize,
                offset: paginationPagesMetaData.PageSize * paginationPagesMetaData.CurrentPage - 1)
                ;
        }
    }
}
