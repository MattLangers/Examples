using Database.Models.DTO;

namespace Database.Factories
{
    public interface IProductDtoFactory
    {
        public ProductDto Create(Guid id, string Name, DateTime creationDate, int productTypeId, string productTypeName);
    }
}
