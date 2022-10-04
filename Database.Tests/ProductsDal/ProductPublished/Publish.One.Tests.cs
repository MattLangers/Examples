using API.Models.InputModels;
using Database.Factories;
using Database.Models;
using Database.Models.DTO;
using Database.Search;
using Database.SpecificationPattern.Specifications.Product;
using Moq;
using Moq.AutoMock;

namespace Database.Tests.ProductsDal.ProductsPublished
{
    public sealed class ProductsDal_ProductsPublished_One_Published_Tests
    {
        private static readonly Guid guid = Guid.NewGuid();

        private readonly AutoMocker autoMocker = new AutoMocker();

        private readonly InMemoryDatabaseContextFactory databaseContextFactory = new InMemoryDatabaseContextFactory();

        private DatabaseContext databaseContext;

        [OneTimeSetUp]
        public async Task SetupAsync()
        {
            databaseContext = databaseContextFactory.GetContext();

            autoMocker.Use(databaseContext);

            await autoMocker.CreateInstance<ProductsDAL>().ProductsPublished(new List<Guid>() { guid });
        }

        [Test]
        public void Expect_ProductPublished_To_Contain_Elements()
        {
            Assert.That(databaseContext.ProductPublished.Single().Id, Is.EqualTo(guid));
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            databaseContext.Dispose();
        }
    }
}
