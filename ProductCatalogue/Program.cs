using Microsoft.EntityFrameworkCore;
using Database;
using Database.Models;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ProductCatalogue"), b => b.MigrationsAssembly("ProductCatalogue")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/products", async (DatabaseContext db) =>
    await db.Product.ToListAsync());

app.MapGet("/products/{id}", async (Guid id, DatabaseContext db) =>
    await db.Product.FindAsync(id)
        is Product product
            ? Results.Ok(product)
            : Results.NotFound());

app.MapGet("/product-types", async (DatabaseContext db) =>
    await db.ProductType.ToListAsync());

app.Run();