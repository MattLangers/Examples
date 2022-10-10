using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models.Hitory
{
    public sealed class ProductPriceHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "smallmoney")]
        public float From { get; set; }

        [Column(TypeName = "smallmoney")]
        public float To { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.UtcNow;

        public Product Product { get; set; } = default!;
    }
}
