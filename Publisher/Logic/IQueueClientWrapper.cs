namespace Publisher.Logic
{
    internal interface IQueueClientWrapper
    {
        Task SendMessageAsync(string jsonMessage, CancellationToken cancellationToken);
    }
}
