using Shared.Models.Documents;
using Shared.Services.Repository;
using Shared.Services.Request.Pagination;


namespace Shared.Views.SearchItemsScreen
{
    public class SearchProduct



    {
        private readonly IRepository<DocumentSale, Guid> repository;


        public SearchProduct(IRepository<DocumentSale, Guid> repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<DocumentSale>> Execute(string filter, PaginationParameters paginationParameters)
        {

            return await repository.GetByFiltersAsync(paginationParameters);
        }
    }
}
