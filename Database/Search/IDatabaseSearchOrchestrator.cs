using API.Models.InputModels;
using Database.Models.DTO;

namespace Database.Search
{
    public interface IDatabaseSearchOrchestrator
    {
        IList<ProductDto> SearchProducts(ProductSearchInputModel productSearchInputModel);
    }
}
