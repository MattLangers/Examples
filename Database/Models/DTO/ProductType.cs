using System.Text.Json.Serialization;

namespace Database.Models.DTO
{
    public sealed class ProductType : ProductTypeDto
    {
        public DateTime CreationDate { get; set; }
    }
}
