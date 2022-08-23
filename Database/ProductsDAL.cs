using Database.Models;
using Database.Models.DTO;

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
                var query = from products in _dbContext.Set<Product>()
                            from productsPublished in _dbContext.Set<ProductPublished>().Where(pb => pb.Id == products.Id).DefaultIfEmpty()
                            select new ProductDto() { Id = products.Id, Name = products.Name, ProductTypeId = products.ProductType.Id };

                return query.ToHashSet();
            });
        }

        public async Task ProductPublished(ProductDto productGuid)
        {
            _dbContext.Add(new Models.ProductPublished() { Id = productGuid.Id });
            await _dbContext.SaveChangesAsync();
        }
    }
}
