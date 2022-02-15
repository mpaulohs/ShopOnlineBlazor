using ShopOnline.Shared.Models.Documents;
using ShopOnline.Shared.Services;

namespace ShopOnline.UseCases.SearchProductsScreen
{
    public class SearchProduct<TKey>
        where TKey : IEquatable<TKey>
    {
        private readonly IRepository<DocumentSale<TKey>, TKey> repository;

        public SearchProduct(IRepository<DocumentSale<TKey>, TKey> repository)
        {
            this.repository=repository;
        }

        public async Task<IEnumerable<DocumentSale<TKey>>> Execute(string filter)
        {
            return await repository.GetByFiltersAsync();
        }
    }
}
