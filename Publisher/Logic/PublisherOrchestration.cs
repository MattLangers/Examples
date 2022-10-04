using Database;
using Microsoft.Extensions.Logging;
using Publisher.Logic.Factories;

namespace Publisher.Logic
{
    internal class PublisherOrchestration : IPublisherOrchestration
    {
        private readonly IProductsDAL productsDAL;
        private readonly IQueueFactory queueFactory;
        private readonly IJsonFactory jsonFactory;
        private readonly ILogger logger;

        public PublisherOrchestration(
            IProductsDAL productsDAL,
            IQueueFactory queueFactory,
            IJsonFactory jsonFactory,
            ILogger<PublisherOrchestration> logger)
        {
            this.productsDAL = productsDAL;
            this.queueFactory = queueFactory;
            this.jsonFactory = jsonFactory;
            this.logger = logger;
        }

        public async Task Start(CancellationToken cancelationToken = default)
        {
            await Task.Run(
                async () =>
                {
                    var products = await productsDAL.GetUnPublishedProducts();
                    var queue = await queueFactory.CreateQueueClient();
                    logger.LogInformation($"Number of products: {products.Count}");

                    foreach (var product in products)
                    {
                        if (cancelationToken.IsCancellationRequested)
                        {
                            logger.LogInformation($"Request cancelled");
                            break;
                        }

                        logger.LogInformation($"Add product to the queue: {product}");
                        await queue.SendMessageAsync(jsonFactory.CreateJson(product), cancelationToken);
                        await productsDAL.ProductPublished(product, cancelationToken);
                    }
                }, cancelationToken);
        }
    }
}
