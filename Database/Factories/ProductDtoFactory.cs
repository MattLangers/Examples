using Database.Models.DTO;

namespace Database.Factories
{
    public sealed class ProductDtoFactory : IProductDtoFactory
    {
        public ProductDto Create(Guid id, string Name, DateTime creationDate, int productTypeId, string productTypeName)
        {
            return new ProductDto()
            {
                Id = id,
                CreationDate = creationDate,
                Name = Name,
                ProductType = new ProductTypeDto() { Id = productTypeId, Name = productTypeName }
            };
        }
    }
}
