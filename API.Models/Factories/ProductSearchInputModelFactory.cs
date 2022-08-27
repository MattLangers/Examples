using API.Models.InputModels;

namespace API.Models.Factories
{
    public class ProductSearchInputModelFactory : IProductSearchInputModelFactory
    {
        public ProductSearchInputModel Create(string id, int? productTypeId, string name)
        {
            var hasSearchPropertiesDefined = false;
            var hasGuild = Guid.TryParse(id, out var guidResult);

            if (hasGuild || productTypeId > 0 || !string.IsNullOrWhiteSpace(name))
            {
                hasSearchPropertiesDefined = true;
            }

            return new ProductSearchInputModel()
            {
                Id = hasGuild ? guidResult : null,
                ProductTypeId = productTypeId.GetValueOrDefault(),
                Name = name,
                HasSearchPropertiesDefined = hasSearchPropertiesDefined
            };
        }
    }
}
