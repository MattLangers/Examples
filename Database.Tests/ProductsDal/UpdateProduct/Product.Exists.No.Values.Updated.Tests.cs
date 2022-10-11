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
    public sealed class ProductsDal_UpdateProduct_Product_Exists_No_Values_Updated_Tests
    {
        private const string Name = "Name";

        private const string Description = "Description";

        private const float Price = 0.1f;

        private const byte Ranking = 1;

        private static readonly Guid guid = Guid.NewGuid();

        private readonly AutoMocker autoMocker = new AutoMocker();

        private readonly InMemoryDatabaseContextFactory databaseContextFactory = new InMemoryDatabaseContextFactory();

        private DatabaseContext databaseContext;

        [OneTimeSetUp]
        public async Task SetupAsync()
        {
            databaseContextFactory.WithProduct(new Models.Product() { Id = guid, Name = Name, Price = new ProductPrice() { Price = Price }, Description = new ProductDescription() { Description = Description }, Ranking = new ProductRanking() { Rank = Ranking } });

            databaseContext = databaseContextFactory.GetContext();

            autoMocker.Use(databaseContext);

            await autoMocker.CreateInstance<ProductsDAL>().UpdateProduct(new API.Models.InputModels.Product(), guid);
        }

        [Test]
        public void Expect_Product_Price_To_Be_Same()
        {
            Assert.That(databaseContext.ProductPrice.Single().Price, Is.EqualTo(Price));
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
