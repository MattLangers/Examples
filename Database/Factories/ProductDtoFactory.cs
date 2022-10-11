using Database.Models;
using Database.Models.DTO;

namespace Database.Factories
{
    public sealed class ProductDtoFactory : IProductDtoFactory
    {
        public ProductDto Create(Product product)
        {
            return new ProductDto()
            {
                Id = product.Id,
                CreationDate = product.CreationDate,
                Name = product.Name,
                ProductType = new ProductTypeDto() { Id = product.ProductType.Id, Name = product.ProductType.Name },
                Description = product.Description.Description,
                Price = product.Price.Price,
                Ranking = product.Ranking.Rank
            };
        }
    }
}
