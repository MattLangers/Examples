using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Database;
using Microsoft.EntityFrameworkCore;
using Publisher.Logic;
using Publisher.Configuration;
using Publisher.Logic.Factories;

Console.WriteLine($"Publisher Start: {DateTime.UtcNow}");

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) => {
        services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(config.GetConnectionString("ProductCatalogue")));
        services.AddScoped<IProductsDAL, ProductsDAL>();
        services.AddScoped<IPublisherOrchestration, PublisherOrchestration>();
        services.AddScoped<IQueueFactory, QueueFactory>();
        services.Configure<QueueConfiguration>(hostContext.Configuration.GetSection("QueueConfiguration"));

    })
    .Build();

var my = host.Services.GetRequiredService<IPublisherOrchestration>();
await my.Start();