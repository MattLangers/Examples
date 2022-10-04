using System.Diagnostics.Metrics;
using API.Models.InputModels;
using Database.Models;
using Database.Models.DTO;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

        public Task<List<ProductDtoForPublishing>> GetUnPublishedProducts()
        {
            return Task.Run(() =>
            {
                return _dbContext.Product.Include(p => p.ProductPublished).Where(p => p.ProductPublished == null).Select(p => new ProductDtoForPublishing() { Id = p.Id, Name = p.Name, ProductTypeId = p.ProductTypeId }).ToList();
            });
        }

        public async Task ProductsPublished(
            List<Guid> publishedProductIds)
        {
            if (publishedProductIds.Any())
            {
                foreach (var id in publishedProductIds)
                {
                    _dbContext.Add(new Models.ProductPublished() { Id = id });
                }

                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
