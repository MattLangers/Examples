using Database;
using Publisher.Logic.Factories;

namespace Publisher.Logic
{
    internal class PublisherOrchestration : IPublisherOrchestration
    {
        private readonly IProductsDAL productsDAL;
        private readonly IQueueFactory queueFactory;
        private readonly IJsonFactory jsonFactory;

        public PublisherOrchestration(
            IProductsDAL productsDAL, IQueueFactory queueFactory, IJsonFactory jsonFactory)
        {
            this.productsDAL = productsDAL;
            this.queueFactory = queueFactory;
            this.jsonFactory = jsonFactory;
        }

        public async Task Start(CancellationToken stoppingToken = default)
        {
            await Task.Run(
                async () =>
                {
                    var products = await productsDAL.GetUnPublishedProducts();
                    var queue = await queueFactory.CreateQueueClient();
                    foreach (var product in products)
                    {
                        await queue.SendMessageAsync(jsonFactory.CreateJson(product));
                        await productsDAL.ProductPublished(product);
                    }
                }, stoppingToken);
            
        }
    }
}
