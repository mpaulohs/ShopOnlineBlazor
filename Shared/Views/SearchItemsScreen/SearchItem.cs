using ShopOnline.Shared.Models.Documents;
using ShopOnline.Shared.Services;

namespace ShopOnline.UseCases.SearchProductsScreen
{
    public class SearchProduct

   
 
    {
        private readonly IRepository<DocumentSale, Guid> repository;
      

        public SearchProduct(IRepository<DocumentSale, Guid> repository)
        {
            this.repository=repository;
        }

        public async Task< (IEnumerable<DocumentSale>, int)?> Execute(string filter)
        {
         
            return await repository.GetByFiltersAsync();
        }
    }
}
