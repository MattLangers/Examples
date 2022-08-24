using Azure.Storage.Queues;
using Publisher.Configuration;

namespace Publisher.Logic.Factories
{
    internal class QueueFactory : IQueueFactory
    {
        private readonly QueueConfiguration configuration;

        public QueueFactory(QueueConfiguration queueConfiguration)
        {
            this.configuration = queueConfiguration;
        }

        public async Task<IQueueClientWrapper> CreateQueueClient()
        {
            var queue = new QueueClient(configuration.StorageConnectionString, configuration.QueueName);
            await queue.CreateAsync();
            return new QueueClientWrapper(queue);
        }
    }
}
