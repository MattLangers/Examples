using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Database.Models.Hitory;

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

        [DefaultValue(false)]
        public bool Archived { get; set; }

        public ProductType ProductType { get; set; } = default!;

        public ProductPublished ProductPublished { get; set; } = default!;

        public ProductPrice Price { get; set; } = default!;

        public ProductDescription Description { get; set; } = default!;

        public ProductRanking Ranking { get; set; } = default!;

        public List<ProductDescriptionHistory> ProductDescriptionHistory { get; set; } = default!;

        public List<ProductNameHistory> ProductNameHistory { get; set; } = default!;

        public List<ProductPriceHistory> ProductPriceHistory { get; set; } = default!;

        public List<ProductRankingHistory> ProductRankingHistory { get; set; } = default!;
    }
}
