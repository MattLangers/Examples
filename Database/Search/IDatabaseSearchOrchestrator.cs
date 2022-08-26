using Database.Models;
using ProductCatalogue.Models.InputModels;

namespace Database.Search
{
    public interface IDatabaseSearchOrchestrator
    {
        List<Product> SearchProducts(ProductSearchInputModel productSearchInputModel);
    }
}
