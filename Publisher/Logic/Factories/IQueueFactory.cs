namespace Publisher.Logic.Factories
{
    internal interface IQueueFactory
    {
        Task<IQueueClientWrapper> CreateQueueClient();
    }
}
