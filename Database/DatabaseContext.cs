using Database.Factories;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class DatabaseContext : DbContext
    {
        private readonly IDatabaseSeedingFactory databaseSeedingFactory = new DatabaseSeedingFactory();

        public DatabaseContext(
            DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }

        public DbSet<ProductType> ProductType { get; set; }

        public DbSet<ProductPublished> ProductPublished { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductType>().HasData(databaseSeedingFactory.CreateProductTypes());

            modelBuilder.Entity<Product>().HasOne(p => p.ProductPublished).WithOne(p => p.Product).HasForeignKey<ProductPublished>(p => p.Id);
        }
    }
}
