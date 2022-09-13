using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public sealed class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(250)]
        public string Name { get; set; } = default!;

        public DateTime CreationDate { get; set; } = DateTime.UtcNow;

        public int ProductTypeId { get; set; }

        public ProductType ProductType { get; set; } = default!;

        public ProductPublished ProductPublished { get; set; } = default!;
    }
}
