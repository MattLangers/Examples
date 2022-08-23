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

            modelBuilder.Entity<ProductPublished>().HasOne(p => p.Product).WithOne(p => p.ProductPublished).HasForeignKey<Product>(p => p.Id);
        }
    }
}
