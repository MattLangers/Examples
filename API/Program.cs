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

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/products", (
    [FromQuery(Name = "id")] string? id,
    [FromQuery(Name = "product-type")] int? poductTypeId,
    [FromQuery(Name = "name")] string? name,
    IProductSearchInputModelFactory factory,
    IDatabaseSearchOrchestrator databaseSearchOrchestrator) =>
{
    var inputModel = factory.Create(id, poductTypeId, name);
    return databaseSearchOrchestrator.SearchProducts(inputModel)
            is List<ProductDto> product
                ? Results.Ok(product)
                : Results.NotFound();
});

app.MapGet("/product-types", async (DatabaseContext db) =>
{
    var productTypes = await db.ProductType.ToListAsync();
    return productTypes;
});

app.UseMiddleware<ExceptionHandlerMiddleware>();

app.Run();