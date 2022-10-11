using Database.Models;
using Database.Models.DTO;

namespace Database.Factories
{
    public interface IProductDtoFactory
    {
        public ProductDto Create(Product product);
    }
}
