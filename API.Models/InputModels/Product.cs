namespace API.Models.InputModels
{
    public sealed class Product
    {
        public string Name { get; set; } = default!;

        public int ProductTypeId { get; set; } = default!;

        public override string ToString()
        {
            return $"Name: {Name} | ProductTypeId: {ProductTypeId}";
        }
    }
}
