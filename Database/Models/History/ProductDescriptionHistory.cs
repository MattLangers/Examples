using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models.Hitory
{
    public sealed class ProductDescriptionHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string FromDescription { get; set; } = default!;

        public string ToDescription { get; set; } = default!;

        public DateTime CreationDate { get; set; } = DateTime.UtcNow;

        public Product Product { get; set; } = default!;
    }
}
