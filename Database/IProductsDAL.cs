using API.Models.InputModels;
using Database.Models.DTO;

namespace Database
{
    public interface IProductsDAL
    {
        Task<Guid> CreateProduct(Product inputModel);

        Task UpdateProduct(Product inputModel, Guid id);

        Task ArchiveProduct(Guid id);

        Task<List<ProductType>> GetProductTypeDtos();

        Task<List<ProductDtoForPublishing>> GetUnPublishedProducts();

        Task ProductsPublished(List<Guid> publishedProductIds);
    }
}
