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
    public class PublisherOrchestration_Start_Multiple_Product_Tests
    {
        private const string productAsJsonMessage1 = "productAsJsonMessage1";
        private const string productAsJsonMessage2 = "productAsJsonMessage2";

        private readonly static Guid guidForProduct1 = new Guid();
        private readonly static Guid guidForProduct2 = new Guid();

        private readonly static ProductDto productDto1 = new ProductDto() { Id = guidForProduct1 };
        private readonly static ProductDto productDto2 = new ProductDto() { Id = guidForProduct2 };
        
        private readonly HashSet<ProductDto> products = new HashSet<ProductDto>()
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

            autoMocker.GetMock<IProductsDAL>().Setup(m => m.ProductPublished(productDto1)).Returns(Task.Run(() => { }));
            autoMocker.GetMock<IProductsDAL>().Setup(m => m.ProductPublished(productDto2)).Returns(Task.Run(() => { }));

            await autoMocker.CreateInstance<Publisher.Logic.PublisherOrchestration>().Start();
        }

        [Test]
        public async Task IProductsDAL_VerifyAll()
        {
            autoMocker.VerifyAll();
        }

        [Test]
        public async Task MockQueueClientWrapper_VerifyAll()
        {
            mockQueueClientWrapper.VerifyAll();
        }
    }
}
