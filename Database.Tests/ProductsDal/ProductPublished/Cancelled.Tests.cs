using API.Models.InputModels;
using Database.Factories;
using Database.Models;
using Database.Models.DTO;
using Database.Search;
using Database.SpecificationPattern.Specifications.Product;
using Moq;
using Moq.AutoMock;

namespace Database.Tests.ProductsDal.ProductPublished
{
    public sealed class ProductsDal_ProductPublished_Cancelled_Tests
    {
        private static readonly Guid guid = Guid.NewGuid();

        private static readonly ProductDtoForPublishing product = new() { Id = guid };

        private readonly CancellationTokenSource cancelationServiceToken = new CancellationTokenSource();

        private readonly AutoMocker autoMocker = new AutoMocker();

        private readonly InMemoryDatabaseContextFactory databaseContextFactory = new InMemoryDatabaseContextFactory();

        private DatabaseContext databaseContext;

        [OneTimeSetUp]
        public async Task SetupAsync()
        {
            databaseContext = databaseContextFactory.GetContext();

            autoMocker.Use(databaseContext);

            cancelationServiceToken.Cancel();

            await autoMocker.CreateInstance<ProductsDAL>().ProductPublished(product, cancelationServiceToken.Token);
        }

        [Test]
        public void Expect_ProductPublished_To_Contain_No_Elements()
        {
            Assert.IsFalse(databaseContext.ProductPublished.Any());
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            databaseContext.Dispose();
        }
    }
}
