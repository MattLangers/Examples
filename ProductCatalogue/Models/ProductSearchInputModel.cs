using Microsoft.AspNetCore.Mvc;

namespace ProductCatalogue.Models
{
    public class ProductSearchInputModel
    {
        [FromQuery(Name = "id")]
        public Guid Id { get; set; }

        [FromQuery(Name = "product-type")]
        public string ProductTypeId { get; set; }

        [FromQuery(Name = "name")]
        public string Name { get; set; }
    }
}
