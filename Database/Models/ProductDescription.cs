using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public sealed class ProductDescription
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        public string Description { get; set; } = default!;

        public DateTime CreationDate { get; set; } = DateTime.UtcNow;

        [ForeignKey("Id")]
        public Product Product { get; set; } = default!;
    }
}
