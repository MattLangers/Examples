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
    public sealed class ProductsDal_UpdateProduct_Product_Exists_Only_Rank_Tests
    {
        private const byte OldRanking = 1;
        private const byte NewRanking = 2;

        private static readonly Guid guid = Guid.NewGuid();

        private readonly AutoMocker autoMocker = new AutoMocker();

        private readonly InMemoryDatabaseContextFactory databaseContextFactory = new InMemoryDatabaseContextFactory();

        private DatabaseContext databaseContext;

        [OneTimeSetUp]
        public async Task SetupAsync()
        {
            databaseContextFactory.WithProduct(new Models.Product() { Id = guid, Name = "Something", Ranking = new ProductRanking() { Rank = OldRanking } });

            databaseContext = databaseContextFactory.GetContext();

            autoMocker.Use(databaseContext);

            await autoMocker.CreateInstance<ProductsDAL>().UpdateProduct(new API.Models.InputModels.Product() { Ranking = NewRanking }, guid);
        }

        [Test]
        public void Expect_Product_Rank_To_Be_Updated()
        {
            Assert.That(databaseContext.ProductRanking.Single().Rank, Is.EqualTo(NewRanking));
        }

        [Test]
        public void Expect_ProductRankingHistory_Entry_Rank_To()
        {
            Assert.That(databaseContext.ProductRankingHistory.Single().To, Is.EqualTo(NewRanking));
        }

        [Test]
        public void Expect_ProductRankingHistory_Entry_Rank_From()
        {
            Assert.That(databaseContext.ProductRankingHistory.Single().From, Is.EqualTo(OldRanking));
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
