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
        private const string productAsJsonMessage1 = "productAsJsonMessage1";
        private const string productAsJsonMessage2 = "productAsJsonMessage2";

        private static readonly Guid guidForProduct1 = new Guid();
        private static readonly Guid guidForProduct2 = new Guid();
        private static readonly ProductDtoForPublishing productDto1 = new ProductDtoForPublishing() { Id = guidForProduct1 };
        private static readonly ProductDtoForPublishing productDto2 = new ProductDtoForPublishing() { Id = guidForProduct2 };

        private readonly HashSet<ProductDtoForPublishing> products = new HashSet<ProductDtoForPublishing>()
        {
            productDto1, productDto2
        };

        private readonly AutoMocker autoMocker = new AutoMocker();

        private readonly Mock<IQueueClientWrapper> mockQueueClientWrapper = new Mock<IQueueClientWrapper>();

        [OneTimeSetUp]
        public async Task Setup()
        {
            autoMocker.GetMock<IProductsDAL>().Setup(m => m.GetUnPublishedProducts()).Returns(Task.Run(() => products));

            autoMocker.GetMock<IQueueFactory>().Setup(m => m.CreateQueueClient()).Returns(Task.Run(() => mockQueueClientWrapper.Object));

            autoMocker.GetMock<IJsonFactory>().Setup(m => m.CreateJson(productDto1)).Returns(productAsJsonMessage1);
            autoMocker.GetMock<IJsonFactory>().Setup(m => m.CreateJson(productDto2)).Returns(productAsJsonMessage2);

            mockQueueClientWrapper.Setup(m => m.SendMessageAsync(productAsJsonMessage1)).Returns(Task.Run(() => { }));
            mockQueueClientWrapper.Setup(m => m.SendMessageAsync(productAsJsonMessage2)).Returns(Task.Run(() => { }));

            autoMocker.GetMock<IProductsDAL>().Setup(m => m.ProductsPublished(It.Is<List<Guid>>(l => l.Contains(guidForProduct1) && l.Contains(guidForProduct2)))).Returns(Task.Run(() => { }));

            await autoMocker.CreateInstance<Publisher.Logic.PublisherOrchestration>().Start();
        }

        [Test]
        public void IProductsDAL_VerifyAll()
        {
            autoMocker.VerifyAll();
        }

        [Test]
        public void MockQueueClientWrapper_VerifyAll()
        {
            mockQueueClientWrapper.VerifyAll();
        }
    }
}
