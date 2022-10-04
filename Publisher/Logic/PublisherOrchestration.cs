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
                    var publishedProducts = new List<Guid>();

                    logger.LogInformation($"Number of products: {products.Count}");

                    var tasks = products.Select(async product =>
                    {
                        if (!cancelationToken.IsCancellationRequested)
                        {
                            logger.LogInformation($"Add product to the queue: {product}");
                            publishedProducts.Add(product.Id);
                            await queue.SendMessageAsync(jsonFactory.CreateJson(product));
                        }
                    });

                    await Task.WhenAll(tasks);

                    await productsDAL.ProductsPublished(publishedProducts);

                }, cancelationToken);
        }
    }
}
