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
    public sealed class ProductsDal_UpdateProduct_Product_Exists_Only_Desc_Tests
    {
        private const string OldDescription = "OldDescription";
        private const string NewDescription = "NewDescription";

        private static readonly Guid guid = Guid.NewGuid();

        private readonly AutoMocker autoMocker = new AutoMocker();

        private readonly InMemoryDatabaseContextFactory databaseContextFactory = new InMemoryDatabaseContextFactory();

        private DatabaseContext databaseContext;

        [OneTimeSetUp]
        public async Task SetupAsync()
        {
            databaseContextFactory.WithProduct(new Models.Product() { Id = guid, Name = "Something", Description = new ProductDescription() { Description = OldDescription } });

            databaseContext = databaseContextFactory.GetContext();

            autoMocker.Use(databaseContext);

            await autoMocker.CreateInstance<ProductsDAL>().UpdateProduct(new API.Models.InputModels.Product() { Description = NewDescription }, guid);
        }

        [Test]
        public void Expect_ProductDescription_To_Be_Updated()
        {
            Assert.That(databaseContext.ProductDescription.Single().Description, Is.EqualTo(NewDescription));
        }

        [Test]
        public void Expect_ProductDescriptionHistory_Entry_To()
        {
            Assert.That(databaseContext.ProductDescriptionHistory.Single().To, Is.EqualTo(NewDescription));
        }

        [Test]
        public void Expect_ProductDescriptionHistory_Entry_From()
        {
            Assert.That(databaseContext.ProductDescriptionHistory.Single().From, Is.EqualTo(OldDescription));
        }

        [Test]
        public void Expect_ProductRankingHistory_To_Contain_No_Entries()
        {
            Assert.That(databaseContext.ProductRankingHistory.Any(), Is.False);
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
