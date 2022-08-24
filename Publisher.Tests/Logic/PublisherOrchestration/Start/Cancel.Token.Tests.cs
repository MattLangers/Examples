using Azure.Storage.Queues;
using Database;
using Database.Models.DTO;
using Moq;
using Moq.AutoMock;
using NUnit.Framework;
using Publisher.Logic;
using Publisher.Logic.Factories;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Publisher.Tests.Logic.PublisherOrchestration.Start
{
    [TestFixture]
    public class PublisherOrchestration_Start_Cancel_Token_Tests
    {
        private readonly static Guid guidForProduct1 = new Guid();
        private readonly static Guid guidForProduct2 = new Guid();

        private readonly static ProductDto productDto1 = new ProductDto() { Id = guidForProduct1 };
        private readonly static ProductDto productDto2 = new ProductDto() { Id = guidForProduct2 };
        
        private readonly HashSet<ProductDto> products = new HashSet<ProductDto>()
        {
            productDto1, productDto2
        };

        private readonly CancellationTokenSource cancelationServiceToken = new CancellationTokenSource();

        private readonly AutoMocker autoMocker = new AutoMocker();

        private readonly Mock<IQueueClientWrapper> mockQueueClientWrapper = new Mock<IQueueClientWrapper>();

        [OneTimeSetUp]
        public async Task Setup()
        {
            autoMocker.GetMock<IProductsDAL>().Setup(m => m.GetUnPublishedProducts()).Returns(Task.Run(() => products));
            
            autoMocker.GetMock<IQueueFactory>().Setup(m => m.CreateQueueClient()).Returns(Task.Run(() => mockQueueClientWrapper.Object)).Callback(() =>
            {
                cancelationServiceToken.Cancel();
            });

            await autoMocker.CreateInstance<Publisher.Logic.PublisherOrchestration>().Start(cancelationServiceToken.Token);
        }

        [Test]
        public async Task IProductsDAL_VerifyAll()
        {
            autoMocker.VerifyAll();
        }

        [Test]
        public async Task MockQueueClientWrapper_SendMessageAsync_Verify_Never_Called()
        {
            mockQueueClientWrapper.Verify(m => m.SendMessageAsync(It.IsAny<string>()), Times.Never);
        }
    }
}
