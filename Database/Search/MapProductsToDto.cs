using Database.Factories;
using Database.Models;
using Database.Models.DTO;

namespace Database.Search
{
    public sealed class MapProductsToDto : IMapProductsToDto
    {
        private readonly IProductDtoFactory productDtoFactory;

        public MapProductsToDto(IProductDtoFactory productDtoFactory)
        {
            this.productDtoFactory = productDtoFactory;
        }

        public IList<ProductDto> Map(IQueryable<Product> products)
        {
            var result = new List<ProductDto>();

            foreach (var product in products)
            {
                result.Add(productDtoFactory.Create(product.Id, product.Name, product.CreationDate, product.ProductType.Id, product.ProductType.Name));
            }

            return result;
        }
    }
}
