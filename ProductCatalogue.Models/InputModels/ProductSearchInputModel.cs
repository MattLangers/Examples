using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace ProductCatalogue.Models.InputModels
{
    public class ProductSearchInputModel
    {
        [FromQuery(Name = "id")]
        public Guid? Id { get; init; }

        [FromQuery(Name = "product-type")]
        public int ProductTypeId { get; init; }

        [FromQuery(Name = "name")]
        public string? Name { get; init; }

        public bool HasSearchPropertiesDefined { get; init; } = false;

        public static ValueTask<ProductSearchInputModel?> BindAsync(
            HttpContext context,
            ParameterInfo parameter)
        {
            var hasProductType = int.TryParse(context.Request.Query["product-type"], out var productTypeId);

            var hasGuild = Guid.TryParse(context.Request.Query["id"], out var guidResult);

            var name = context.Request.Query["name"];

            var hasSearchPropertiesDefined = false;

            if (hasProductType || hasGuild || !string.IsNullOrWhiteSpace(name))
            {
                hasSearchPropertiesDefined = true;
            }

            var result = new ProductSearchInputModel
            {
                Id = hasGuild ? guidResult : null,
                ProductTypeId = productTypeId,
                Name = name,
                HasSearchPropertiesDefined = hasSearchPropertiesDefined
            };

            return ValueTask.FromResult<ProductSearchInputModel?>(result);
        }
    }
}
