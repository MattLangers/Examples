using API.Models.InputModels;
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

        public async Task<Guid> CreateProduct(API.Models.InputModels.Product inputModel)
        {
            var product = new Models.Product() { ProductTypeId = inputModel.ProductTypeId, Name = inputModel.Name };
            _dbContext.Set<Models.Product>().Add(product);
            await _dbContext.SaveChangesAsync();
            return product.Id;
        }

        public Task<List<Models.DTO.ProductType>> GetProductTypeDtos()
        {
            return _dbContext.Set<Models.ProductType>().Select(p => new Models.DTO.ProductType() { Id = p.Id, CreationDate = p.CreationDate, Name = p.Name }).ToListAsync();
        }

        public Task<HashSet<ProductDtoForPublishing>> GetUnPublishedProducts()
        {
            return Task.Run(() =>
            {
                /* TODO: should we be using Linq to buid the query */
                return _dbContext.Set<Models.Product>()
                .FromSqlRaw("select p.* from Product p Left Join ProductPublished pb on p.Id = pb.Id Where pb.Id is NULL")
                .Select(product => new ProductDtoForPublishing() { Id = product.Id, Name = product.Name, ProductTypeId = product.ProductType.Id })
                .ToHashSet();
            });
        }

        public async Task ProductPublished(
            ProductDtoForPublishing product,
            CancellationToken cancellationToken)
        {
            if (!cancellationToken.IsCancellationRequested)
            {
                _dbContext.Add(new Models.ProductPublished() { Id = product.Id });
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
