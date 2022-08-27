using API.Models.InputModels;
using Database.Models;

namespace Database.Search
{
    public interface IDatabaseSearchOrchestrator
    {
        List<Product> SearchProducts(ProductSearchInputModel productSearchInputModel);
    }
}
