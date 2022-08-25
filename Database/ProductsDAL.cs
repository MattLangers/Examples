using Database.Models;
using Database.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class ProductsDAL : IProductsDAL
    {
        private readonly DatabaseContext _dbContext;

        public ProductsDAL(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<HashSet<ProductDto>> GetUnPublishedProducts()
        {
            return Task.Run(() =>
            {
                /* TODO: should we be using Linq to buid the query */
                return _dbContext.Set<Product>()
                .FromSqlRaw("select p.* from Product p Left Join ProductPublished pb on p.Id = pb.Id Where pb.Id is NULL")
                .Select(products => new ProductDto() { Id = products.Id, Name = products.Name, ProductTypeId = products.ProductType.Id })
                .ToHashSet();
            });
        }

        public async Task ProductPublished(ProductDto productGuid)
        {
            _dbContext.Add(new Models.ProductPublished() { Id = productGuid.Id });
            await _dbContext.SaveChangesAsync();
        }
    }
}
