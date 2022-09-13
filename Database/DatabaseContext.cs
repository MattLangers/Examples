﻿using Database.Enums;
using Database.Factories;
using Database.Models;
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

        public DbSet<Models.ProductType> ProductType { get; set; } = default!;

        public DbSet<ProductPublished> ProductPublished { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.ProductType>().HasData(databaseSeedingFactory.CreateProductTypes());

            modelBuilder.Entity<Product>().HasData(databaseSeedingFactory.CreateProducts());

            modelBuilder.Entity<Product>().HasOne(p => p.ProductPublished).WithOne(p => p.Product).HasForeignKey<ProductPublished>(p => p.Id);
        }
    }
}
