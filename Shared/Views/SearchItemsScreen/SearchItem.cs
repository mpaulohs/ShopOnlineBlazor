using Shared.Models.Documents;
using Shared.Services.Repository;
using Shared.Views.Pagination;

namespace Shared.Views.SearchItemsScreen
{
    public class SearchProduct



    {
        private readonly IRepository<DocumentSale, Guid> repository;


        public SearchProduct(IRepository<DocumentSale, Guid> repository)
        {
            this.repository = repository;
        }

        public async Task<(IEnumerable<DocumentSale>, PaginationEntitiesMetaData paginationEntitiesMetaData)?> Execute(string filter)
        {

            return await repository.GetByFiltersAsync();
        }
    }
}
