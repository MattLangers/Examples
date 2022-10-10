using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models.Hitory
{
    public sealed class ProductRankingHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "smallint")]
        public byte From { get; set; }

        public byte To { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.UtcNow;

        public Product Product { get; set; } = default!;
    }
}
