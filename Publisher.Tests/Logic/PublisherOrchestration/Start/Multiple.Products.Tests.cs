using Database;
using Database.Models.DTO;
using Moq;
using Moq.AutoMock;
using NUnit.Framework;
using Publisher.Logic;
using Publisher.Logic.Factories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Publisher.Tests.Logic.PublisherOrchestration.Start
{
    [TestFixture]
    public sealed class PublisherOrchestration_Start_Multiple_Product_Tests
    {
        private const int NumberOfProducts = 1000;

        private readonly HashSet<ProductDtoForPublishing> products = new ProductBuilder().Create(NumberOfProducts);

        private readonly AutoMocker autoMocker = new AutoMocker();

        private readonly Mock<IQueueClientWrapper> mockQueueClientWrapper = new Mock<IQueueClientWrapper>();

        [OneTimeSetUp]
        public async Task Setup()
        {
            autoMocker.GetMock<IProductsDAL>().Setup(m => m.GetUnPublishedProducts()).Returns(Task.Run(() => products));

            autoMocker.GetMock<IQueueFactory>().Setup(m => m.CreateQueueClient()).Returns(Task.Run(() => mockQueueClientWrapper.Object));

            foreach (var product in products)
            {
                autoMocker.GetMock<IJsonFactory>().Setup(m => m.CreateJson(It.IsAny<ProductDtoForPublishing>())).Returns(product.Id.ToString());
            }

            mockQueueClientWrapper.Setup(m => m.SendMessageAsync(It.IsAny<string>())).Returns(Task.Run(async () =>
            {
                await Task.Delay(1000);
            }));

            autoMocker.GetMock<IProductsDAL>().Setup(m => m.ProductsPublished(It.IsAny<List<Guid>>())).Returns(Task.Run(() => { }));

            await autoMocker.CreateInstance<Publisher.Logic.PublisherOrchestration>().Start();
        }

        [Test]
        public void IProductsDAL_VerifyAll()
        {
            autoMocker.VerifyAll();
        }

        [Test]
        public void IProductsDAL_ProductsPublished_is_called_with_number_of_expected_Products()
        {
            autoMocker.GetMock<IProductsDAL>().Verify(m => m.ProductsPublished(It.Is<List<Guid>>(l => l.Count == NumberOfProducts)), Times.Once);
        }

        [Test]
        public void MockQueueClientWrapper_VerifyAll()
        {
            mockQueueClientWrapper.VerifyAll();
        }
    }
}
