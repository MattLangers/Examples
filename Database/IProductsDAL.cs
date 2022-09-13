using Database.Models.DTO;

namespace Database
{
    public interface IProductsDAL
    {
        Task<List<ProductTypeDtoWithDateCreated>> GetProductTypeDtos();

        Task<HashSet<ProductDtoForPublishing>> GetUnPublishedProducts();

        Task ProductPublished(ProductDtoForPublishing productGuid);
    }
}
