namespace Shared.Views.Pagination
{
    public static class PaginationConverter
    {
        public static PaginationPagesMetaData ToPaginationPagesMetaData(PaginationEntitiesMetaData paginationEntitiesMetaData)
        {
            return new PaginationPagesMetaData(
                curentPage: paginationEntitiesMetaData.Offset/paginationEntitiesMetaData.Limit + 1,
                count: paginationEntitiesMetaData.Count,
                pageSize: paginationEntitiesMetaData.Limit
                );
        }


        public static PaginationEntitiesMetaData ToPaginationEntitiesMetaData(PaginationPagesMetaData paginationPagesMetaData)
        {
            return new PaginationEntitiesMetaData(
                count: paginationPagesMetaData.Count,
                limit: paginationPagesMetaData.PageSize,
                offset: paginationPagesMetaData.PageSize * paginationPagesMetaData.CurrentPage - 1)
                ;
        }
    }
}
