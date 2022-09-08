using Database.Models.DTO;

namespace Database.Search
{
    public interface IProductsToDtoMapper
    {
        IList<ProductDto> Map(IQueryable<Models.Product> products);
    }
}
