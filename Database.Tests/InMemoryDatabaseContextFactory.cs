﻿using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Tests
{
    public class InMemoryDatabaseContextFactory
    {
        private readonly static Guid guid = Guid.NewGuid();

        private readonly DbContextOptionsBuilder<DatabaseContext> dbContextOptionsBuilder = new DbContextOptionsBuilder<DatabaseContext>().UseInMemoryDatabase(guid.ToString("N"));

        private DatabaseContext databaseContext;

        public InMemoryDatabaseContextFactory()
        {
            databaseContext = new DatabaseContext(dbContextOptionsBuilder.Options);
        }

        public DatabaseContext GetContext()
        {
            databaseContext.SaveChanges();
            return databaseContext;
        }

        public void WithProductType(ProductType productType)
        {
            databaseContext.Add(productType);
        }

        public void WithProduct(Product product)
        {
            databaseContext.Add(product);
        }

        public void TearDown()
        {
            databaseContext.Dispose();
        }
    }
}
