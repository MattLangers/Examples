using Microsoft.EntityFrameworkCore;
using Database;
using Microsoft.AspNetCore.Mvc;
using Database.Search;
using API.Middleware;
using API.Models.Factories;
using Database.Factories;
using Database.Models.DTO;
using API.Models.InputModels;

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
builder.Services.AddScoped<IOutputModelFactory, OutputModelFactory>();

var connectionString = builder.Configuration.GetConnectionString("ProductCatalogue");

var corsAllowedOrigins = new List<string>();
builder.Configuration.GetSection("Cors:AllowedOrigins").Bind(corsAllowedOrigins); ;

var productCategoryAllowOrigins = "_productCategoryAllowOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: productCategoryAllowOrigins,
                      policy =>
                      {
                          policy.WithOrigins(corsAllowedOrigins.ToArray());
                      });
});

var app = builder.Build();

app.UseCors(productCategoryAllowOrigins);

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

app.MapPost("/products", async (
    ILogger<Program> logger,
    IProductsDAL productsDAL,
    IOutputModelFactory outputModelFactory,
    [FromBody]Product inputModel) =>
{
    return await CreateProduct(logger, productsDAL, outputModelFactory, inputModel);
});

app.MapGet("/product-types", async (ILogger<Program> logger, IProductsDAL productsDAL) =>
{
    logger.LogInformation("Get all product types request");
    return await productsDAL.GetProductTypeDtos();
});

app.UseMiddleware<ExceptionHandlerMiddleware>();

app.Run();

static async Task<IResult> CreateProduct(
    ILogger<Program> logger,
    IProductsDAL productsDAL, 
    IOutputModelFactory outputModelFactory, 
    Product inputModel)
{
    /* Unable to keep this logic in the main path of the request end-point as visual studio was 
     * rendering an error in the designer */
    logger.LogInformation($"Create product request: {inputModel.Name}, {inputModel.ProductTypeId}");
    if (string.IsNullOrEmpty(inputModel.Name) || inputModel.ProductTypeId == 0)
    {
        logger.LogInformation("Returning a bad request response");
        return Results.BadRequest();
    }

    var productGuid = await productsDAL.CreateProduct(inputModel);
    return Results.Ok(outputModelFactory.Create(productGuid));
}