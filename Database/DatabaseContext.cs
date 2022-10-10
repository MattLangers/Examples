using Database.Enums;
using Database.Factories;
using Database.Models;
using Database.Models.Hitory;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public sealed class DatabaseContext : DbContext
    {
        /* TODO: Can these dependencies be satisfied via dependency injection rather than newing up? */
        private readonly IDatabaseSeedingFactory databaseSeedingFactory = new DatabaseSeedingFactory(new MapEnumToEnum());

        public DatabaseContext(
            DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; } = default!;

        public DbSet<ProductDescription> ProductDescription { get; set; } = default!;

        public DbSet<ProductDescriptionHistory> ProductDescriptionHistory { get; set; } = default!;

        public DbSet<ProductNameHistory> ProductNameHistory { get; set; } = default!;

        public DbSet<ProductPrice> ProductPrice { get; set; } = default!;

        public DbSet<ProductPriceHistory> ProductPriceHistory { get; set; } = default!;

        public DbSet<ProductRanking> ProductRanking { get; set; } = default!;

        public DbSet<ProductRankingHistory> ProductRankingHistory { get; set; } = default!;

        public DbSet<Models.ProductType> ProductType { get; set; } = default!;

        public DbSet<ProductPublished> ProductPublished { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.ProductType>().HasData(databaseSeedingFactory.CreateProductTypes());

            modelBuilder.Entity<Product>().HasData(databaseSeedingFactory.CreateProducts());

            modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductPublished)
                .WithOne(p => p.Product)
                .HasForeignKey<ProductPublished>(p => p.Id);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Description)
                .WithOne(p => p.Product)
                .HasForeignKey<ProductDescription>(p => p.Id);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Price)
                .WithOne(p => p.Product)
                .HasForeignKey<ProductPrice>(p => p.Id);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Ranking)
                .WithOne(p => p.Product)
                .HasForeignKey<ProductRanking>(p => p.Id);

            modelBuilder.Entity<ProductDescription>().HasData(databaseSeedingFactory.CreateProductDescriptions());

            modelBuilder.Entity<ProductPrice>().HasData(databaseSeedingFactory.CreateProductPrices());

            modelBuilder.Entity<ProductRanking>().HasData(databaseSeedingFactory.CreateProductRankings());
        }
    }
}
