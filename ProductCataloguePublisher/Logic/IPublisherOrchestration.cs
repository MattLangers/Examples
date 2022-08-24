namespace Publisher.Logic
{
    internal interface IPublisherOrchestration
    {
        Task Start(CancellationToken cancelationToken = default);
    }
}
