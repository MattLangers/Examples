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
    public sealed class ProductsDal_UpdateProduct_Product_Exists_Only_Price_Tests
    {
        private const float OldPrice = 0.1f;
        private const float NewPrice = 0.2f;

        private static readonly Guid guid = Guid.NewGuid();

        private readonly AutoMocker autoMocker = new AutoMocker();

        private readonly InMemoryDatabaseContextFactory databaseContextFactory = new InMemoryDatabaseContextFactory();

        private DatabaseContext databaseContext;

        [OneTimeSetUp]
        public async Task SetupAsync()
        {
            databaseContextFactory.WithProduct(new Models.Product() { Id = guid, Name = "Something", Price = new ProductPrice() { Price = OldPrice } });

            databaseContext = databaseContextFactory.GetContext();

            autoMocker.Use(databaseContext);

            await autoMocker.CreateInstance<ProductsDAL>().UpdateProduct(new API.Models.InputModels.Product() { Price = NewPrice }, guid);
        }

        [Test]
        public void Expect_ProductPrice_To_Be_Updated()
        {
            Assert.That(databaseContext.ProductPrice.Single().Price, Is.EqualTo(NewPrice));
        }

        [Test]
        public void Expect_ProductPriceHistory_Entry_To()
        {
            Assert.That(databaseContext.ProductPriceHistory.Single().To, Is.EqualTo(NewPrice));
        }

        [Test]
        public void Expect_ProductPriceHistory_Entry_From()
        {
            Assert.That(databaseContext.ProductPriceHistory.Single().From, Is.EqualTo(OldPrice));
        }

        [Test]
        public void Expect_ProductRankingHistory_To_Contain_No_Entries()
        {
            Assert.That(databaseContext.ProductRankingHistory.Any(), Is.False);
        }

        [Test]
        public void Expect_ProductDescriptionHistory_To_Contain_No_Entries()
        {
            Assert.That(databaseContext.ProductDescriptionHistory.Any(), Is.False);
        }

        [Test]
        public void Expect_ProductNameHistory_To_Contain_No_Entries()
        {
            Assert.That(databaseContext.ProductNameHistory.Any(), Is.False);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            databaseContext.Dispose();
        }
    }
}
