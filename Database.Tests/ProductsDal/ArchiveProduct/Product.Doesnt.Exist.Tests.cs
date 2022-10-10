using API.Models.InputModels;
using Database.Factories;
using Database.Models;
using Database.Models.DTO;
using Database.Search;
using Database.SpecificationPattern.Specifications.Product;
using Moq;
using Moq.AutoMock;

namespace Database.Tests.ProductsDal.ArchiveProduct
{
    public sealed class ProductsDal_ArchiveProduct_Product_Doesnt_Exist_Archive_Tests
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

            await autoMocker.CreateInstance<ProductsDAL>().ArchiveProduct(guid);
        }

        [Test]
        public void Expect_Method_To_Complete_No_New_Products()
        {
            Assert.That(databaseContext.Product.Any(), Is.False);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            databaseContext.Dispose();
        }
    }
}
