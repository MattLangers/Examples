using Database.Models.DTO;

namespace Database.Search
{
    public interface IMapProductsToDto
    {
        IList<ProductDto> Map(IQueryable<Models.Product> products);
    }
}
