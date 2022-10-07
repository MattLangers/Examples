using API.Models.InputModels;
using Database.Factories;
using Database.Models;
using Database.Models.DTO;
using Database.Search;
using Database.SpecificationPattern.Specifications.Product;
using Moq;
using Moq.AutoMock;

namespace Database.Tests.ProductsDal.UpdateProduct
{
    public sealed class ProductsDal_UpdateProduct_Product_Exists_Tests
    {
        private const string ProductName = "Snickers";

        private static readonly Guid guid = Guid.NewGuid();

        private readonly AutoMocker autoMocker = new AutoMocker();

        private readonly InMemoryDatabaseContextFactory databaseContextFactory = new InMemoryDatabaseContextFactory();

        private DatabaseContext databaseContext;

        [OneTimeSetUp]
        public async Task SetupAsync()
        {
            databaseContextFactory.WithProduct(new Models.Product() { Id = guid, Name = "Something" });

            databaseContext = databaseContextFactory.GetContext();

            autoMocker.Use(databaseContext);

            await autoMocker.CreateInstance<ProductsDAL>().UpdateProduct(new API.Models.InputModels.Product() { Id = guid, Name = ProductName });
        }

        [Test]
        public void Expect_Product_Name_To_Be_Updated()
        {
            Assert.That(databaseContext.Product.Single().Name, Is.EqualTo(ProductName));
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            databaseContext.Dispose();
        }
    }
}
