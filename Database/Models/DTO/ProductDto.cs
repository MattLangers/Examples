namespace Database.Models.DTO
{
    public sealed class ProductDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public float Price { get; set; }

        public byte Ranking { get; set; }

        public DateTime CreationDate { get; set; }

        public ProductTypeDto ProductType { get; set; } = default!;
    }
}
