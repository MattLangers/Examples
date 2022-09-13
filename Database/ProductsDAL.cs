using Database.Models;
using Database.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public sealed class ProductsDAL : IProductsDAL
    {
        private readonly DatabaseContext _dbContext;

        public ProductsDAL(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<HashSet<ProductDtoForPublishing>> GetUnPublishedProducts()
        {
            return Task.Run(() =>
            {
                /* TODO: should we be using Linq to buid the query */
                return _dbContext.Set<Product>()
                .FromSqlRaw("select p.* from Product p Left Join ProductPublished pb on p.Id = pb.Id Where pb.Id is NULL")
                .Select(product => new ProductDtoForPublishing() { Id = product.Id, Name = product.Name, ProductTypeId = product.ProductType.Id })
                .ToHashSet();
            });
        }

        public async Task ProductPublished(ProductDtoForPublishing productGuid)
        {
            _dbContext.Add(new Models.ProductPublished() { Id = productGuid.Id });
            await _dbContext.SaveChangesAsync();
        }
    }
}
