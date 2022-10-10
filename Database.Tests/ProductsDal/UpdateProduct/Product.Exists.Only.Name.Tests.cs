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
        private const string OldProductName = "OldProductName";

        private const string NewProductName = "NewProductName";

        private static readonly Guid guid = Guid.NewGuid();

        private readonly AutoMocker autoMocker = new AutoMocker();

        private readonly InMemoryDatabaseContextFactory databaseContextFactory = new InMemoryDatabaseContextFactory();

        private DatabaseContext databaseContext;

        [OneTimeSetUp]
        public async Task SetupAsync()
        {
            databaseContextFactory.WithProduct(new Models.Product() { Id = guid, Name = OldProductName });

            databaseContext = databaseContextFactory.GetContext();

            autoMocker.Use(databaseContext);

            await autoMocker.CreateInstance<ProductsDAL>().UpdateProduct(new API.Models.InputModels.Product() { Name = NewProductName }, guid);
        }

        [Test]
        public void Expect_Product_Name_To_Be_Updated()
        {
            Assert.That(databaseContext.Product.Single().Name, Is.EqualTo(NewProductName));
        }

        [Test]
        public void Expect_Product_Name_History_Entry_Name_To()
        {
            Assert.That(databaseContext.ProductNameHistory.Single().To, Is.EqualTo(NewProductName));
        }

        [Test]
        public void Expect_Product_Name_History_Entry_Name_From()
        {
            Assert.That(databaseContext.ProductNameHistory.Single().From, Is.EqualTo(OldProductName));
        }

        [Test]
        public void Expect_ProductDescriptionHistory_To_Contain_No_Entries()
        {
            Assert.That(databaseContext.ProductDescriptionHistory.Any(), Is.False);
        }

        [Test]
        public void Expect_ProductPriceHistory_To_Contain_No_Entries()
        {
            Assert.That(databaseContext.ProductPriceHistory.Any(), Is.False);
        }

        [Test]
        public void Expect_ProductRankingHistory_To_Contain_No_Entries()
        {
            Assert.That(databaseContext.ProductRankingHistory.Any(), Is.False);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            databaseContext.Dispose();
        }
    }
}
