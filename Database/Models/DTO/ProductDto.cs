namespace Database.Models.DTO
{
    public class ProductDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = default!;

        public int ProductTypeId { get; set; }

        public DateTime CreationDate { get; set; }

        public ProductTypeDto ProductType { get; set; } = default!;
    }
}
