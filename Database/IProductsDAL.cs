using Database.Models.DTO;

namespace Database
{
    public interface IProductsDAL
    {
        Task<HashSet<ProductDtoForPublishing>> GetUnPublishedProducts();

        Task ProductPublished(ProductDtoForPublishing productGuid);
    }
}
