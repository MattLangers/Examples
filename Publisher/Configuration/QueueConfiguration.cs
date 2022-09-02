namespace Publisher.Configuration
{
    internal class QueueConfiguration
    {
        public string StorageConnectionString { get; set; } = default!;

        public string QueueName { get; set; } = default!;
    }
}
