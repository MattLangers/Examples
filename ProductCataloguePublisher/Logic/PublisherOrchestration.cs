using Database;

namespace Publisher.Logic
{
    internal class PublisherOrchestration : IPublisherOrchestration
    {
        private readonly IProductsDAL productsDAL;

        public PublisherOrchestration(
            IProductsDAL productsDAL)
        {
            this.productsDAL = productsDAL;
        }

        public async Task Start(CancellationToken stoppingToken = default)
        {
            await Task.Run(
                async () =>
                {
                    var products = await productsDAL.GetUnPublishedProducts();
                    foreach (var product in products)
                    {
                        /* ADD ITEM TO QUEUE */
                        await productsDAL.ProductPublished(product);
                    }
                }, stoppingToken);
            
        }
    }
}
