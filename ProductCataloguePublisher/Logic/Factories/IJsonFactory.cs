using Database.Models.DTO;

namespace Publisher.Logic.Factories
{
    internal interface IJsonFactory
    {
        string CreateJson(ProductDto productDto);
    }
}
