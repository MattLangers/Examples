﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Database;
using Microsoft.EntityFrameworkCore;
using Publisher.Logic;

Console.WriteLine($"Publisher Start: {DateTime.UtcNow}");

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services => {
        services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(config.GetConnectionString("ProductCatalogue")));
        services.AddScoped<IProductsDAL, ProductsDAL>();
        services.AddScoped<IPublisherOrchestration, PublisherOrchestration>();
    })
    .Build();

var my = host.Services.GetRequiredService<IPublisherOrchestration>();
await my.Start();