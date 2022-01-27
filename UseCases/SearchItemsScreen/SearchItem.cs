using ShopOnline.Shared.Models.Documents;
using ShopOnline.Shared.Services;

namespace ShopOnline.UseCases.SearchItemsScreen
{
    public class SearchItem
    {
        private readonly IRepository<DocumentSale, Guid> repository;

        public SearchItem(IRepository<DocumentSale, Guid> repository)
        {
            this.repository=repository;
        }

        public async Task<IEnumerable<DocumentSale>> Execute(string filter)
        {
            return await repository.GetByFiltersAsync();
        }
    }
}
