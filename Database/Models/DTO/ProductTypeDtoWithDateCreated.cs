namespace Database.Models.DTO
{
    public sealed class ProductTypeDtoWithDateCreated : ProductTypeDto
    {
        public DateTime CreationDate { get; set; }
    }
}
