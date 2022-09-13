using Database.Models.DTO;
using System.Text.Json;

namespace Publisher.Logic.Factories
{
    internal class JsonFactory : IJsonFactory
    {
        public string CreateJson(ProductDtoForPublishing productDto)
        {
            return JsonSerializer.Serialize(productDto);
        }
    }
}
