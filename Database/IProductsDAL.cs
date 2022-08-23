using Database.Models;
using Database.Models.DTO;

namespace Database
{
    public interface IProductsDAL
    {
        Task<HashSet<ProductDto>> GetUnPublishedProducts();

        Task ProductPublished(ProductDto productGuid);
    }
}
