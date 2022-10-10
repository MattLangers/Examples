using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public sealed class ProductRanking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "smallint")]
        public int Rank { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.UtcNow;

        public Product Product { get; set; } = default!;
    }
}
