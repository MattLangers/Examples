namespace API.Models.InputModels
{
    public sealed class Product
    {
        public string? Name { get; set; } = default!;

        public string? Description { get; set; } = default!;

        public float? Price { get; set; }

        public byte? Ranking { get; set; }

        public int ProductTypeId { get; set; } = default!;

        public override string ToString()
        {
            return $"Name: {Name} | ProductTypeId: {ProductTypeId}";
        }
    }
}
