using API.Models.InputModels;
using Database.Factories;
using Database.Models;
using Database.Models.DTO;
using Database.Search;
using Database.SpecificationPattern.Specifications.Product;
using Moq;
using Moq.AutoMock;

namespace Database.Tests.ProductsDal.CreateProduct
{
    public sealed class ProductsDal_CreateProduct_All_InputModel_Properties_Tests
    {
        private const string Name = "Name";
        private const string Description = "Description";
        private const float Price = 0.1f;
        private const byte Ranking = 1;

        private readonly AutoMocker autoMocker = new AutoMocker();

        private readonly InMemoryDatabaseContextFactory databaseContextFactory = new InMemoryDatabaseContextFactory();

        private DatabaseContext databaseContext;

        [OneTimeSetUp]
        public async Task SetupAsync()
        {
            databaseContext = databaseContextFactory.GetContext();

            autoMocker.Use(databaseContext);

            await autoMocker.CreateInstance<ProductsDAL>().CreateProduct(new API.Models.InputModels.Product()
            {
                Name = Name,
                Description = Description,
                Price = Price,
                Ranking = Ranking
            });
        }

        [Test]
        public void Expect_Product_Name()
        {
            Assert.That(databaseContext.Product.Single().Name, Is.EqualTo(Name));
        }

        [Test]
        public void Expect_Product_Description()
        {
            Assert.That(databaseContext.Product.Single().Description.Description, Is.EqualTo(Description));
        }

        [Test]
        public void Expect_Product_Price()
        {
            Assert.That(databaseContext.Product.Single().Price.Price, Is.EqualTo(Price));
        }

        [Test]
        public void Expect_Product_Ranking()
        {
            Assert.That(databaseContext.Product.Single().Ranking.Rank, Is.EqualTo(Ranking));
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            databaseContext.Dispose();
        }
    }
}
