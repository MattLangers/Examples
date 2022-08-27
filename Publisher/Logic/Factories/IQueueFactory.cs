using Azure.Storage.Queues;
using Database.Models.DTO;

namespace Publisher.Logic.Factories
{
    internal interface IQueueFactory
    {
        Task<IQueueClientWrapper> CreateQueueClient();
    }
}
