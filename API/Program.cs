using Microsoft.EntityFrameworkCore;
using Database;
using Microsoft.AspNetCore.Mvc;
using Database.Search;
using API.Middleware;
using API.Models.Factories;
using Database.Factories;
using Database.Models.DTO;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ProductCatalogue"), b => b.MigrationsAssembly("API")));
builder.Services.AddScoped<IProductSearchInputModelFactory, ProductSearchInputModelFactory>();
builder.Services.AddScoped<IDatabaseSearchOrchestrator, DatabaseSearchOrchestrator>();
builder.Services.AddScoped<IProductDtoFactory, ProductDtoFactory>();
builder.Services.AddScoped<ISearchProductSpecificationFactory, SearchProductSpecificationFactory>();
builder.Services.AddScoped<IProductsToDtoMapper, ProductsToDtoMapper>();
builder.Services.AddScoped<IProductsDAL, ProductsDAL>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapGet("/products", (
    [FromQuery(Name = "id")] string? id,
    [FromQuery(Name = "product-type")] int? productTypeId,
    [FromQuery(Name = "name")] string? name,
    ILogger<Program> logger,
    IProductSearchInputModelFactory factory,
    IDatabaseSearchOrchestrator databaseSearchOrchestrator) =>
{
    logger.LogInformation($"Get products request: id({id}), productTypeId({productTypeId}), name({name})");
    var inputModel = factory.Create(id, productTypeId, name);
    return databaseSearchOrchestrator.SearchProducts(inputModel)
            is List<ProductDto> product
                ? Results.Ok(product)
                : Results.NotFound();
});

app.MapGet("/product-types", async (ILogger<Program> logger, IProductsDAL productsDAL) =>
{
    logger.LogInformation("Get all product types request");
    return await productsDAL.GetProductTypeDtos();
});

app.UseMiddleware<ExceptionHandlerMiddleware>();

app.Run();