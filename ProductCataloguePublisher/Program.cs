using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Database;
using Microsoft.EntityFrameworkCore;
using Publisher.Logic;
using Publisher.Configuration;
using Publisher.Logic.Factories;

Console.WriteLine($"Publisher Start: {DateTime.UtcNow}");

var cancellationToken = new CancellationTokenSource();

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) => {
        var configuration = new QueueConfiguration();
        hostContext.Configuration.GetSection("QueueConfiguration").Bind(configuration);

        services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(config.GetConnectionString("ProductCatalogue")));
        services.AddScoped<IProductsDAL, ProductsDAL>();
        services.AddScoped<IPublisherOrchestration, PublisherOrchestration>();
        services.AddScoped<IQueueFactory, QueueFactory>();
        services.AddSingleton(configuration);
        services.AddScoped<IQueueFactory, QueueFactory>();
        services.AddScoped<IQueueClientWrapper, QueueClientWrapper>();
        services.AddScoped<IJsonFactory, JsonFactory>();
    })
    .Build();

var my = host.Services.GetRequiredService<IPublisherOrchestration>();

Console.CancelKeyPress += (sender, eventArgs) =>
{
    Console.WriteLine("Cancel event triggered");
    cancellationToken.Cancel();
    eventArgs.Cancel = true;
};

await my.Start(cancellationToken.Token);