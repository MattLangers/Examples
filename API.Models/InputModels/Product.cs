namespace API.Models.InputModels
{
    public sealed class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = default!;

        public int ProductTypeId { get; set; } = default!;

        public override string ToString()
        {
            return $"Id: {Id} | Name: {Name} | ProductTypeId: {ProductTypeId}";
        }
    }
}
