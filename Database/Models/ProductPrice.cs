using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public sealed class ProductPrice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "smallmoney")]
        public float Price { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.UtcNow;

        [ForeignKey("Id")]
        public Product Product { get; set; } = default!;
    }
}
