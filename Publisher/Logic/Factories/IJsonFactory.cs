using Database.Models.DTO;

namespace Publisher.Logic.Factories
{
    public interface IJsonFactory
    {
        string CreateJson(ProductDtoForPublishing productDto);
    }
}
