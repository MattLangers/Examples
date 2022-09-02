using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public class ProductPublished
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Id")]
        public Product Product { get; set; } = default!;

        public DateTime PublishDate { get; set; } = DateTime.UtcNow;
    }
}
