namespace API.Models.InputModels
{
    public sealed class CreateProductInputModel
    {
        public string Name { get; set; } = default!;

        public int ProductTypeId { get; set; } = default!;
    }
}
