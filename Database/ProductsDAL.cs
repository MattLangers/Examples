using System.Diagnostics.Metrics;
using API.Models.InputModels;
using Database.Models;
using Database.Models.DTO;
using Database.Models.Hitory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Database
{
    public sealed class ProductsDAL : IProductsDAL
    {
        private readonly ILogger _logger;
        private readonly DatabaseContext _dbContext;

        public ProductsDAL(
            ILogger<ProductsDAL> logger,
            DatabaseContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task ArchiveProduct(Guid id)
        {
            var product = await _dbContext.Product.FirstOrDefaultAsync(p => p.Id == id);

            if (product != null)
            {
                _logger.LogInformation($"Product {id} archived");
                product.Archived = true;
                _dbContext.Update(product);
                await _dbContext.SaveChangesAsync();
            }
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
            return _dbContext.Product.Include(p => p.ProductPublished).Where(p => p.ProductPublished == null).Select(p => new ProductDtoForPublishing() { Id = p.Id, Name = p.Name, ProductTypeId = p.ProductTypeId }).ToListAsync();
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

        public async Task UpdateProduct(API.Models.InputModels.Product inputModel, Guid id)
        {
            var product = await _dbContext.Product.Include(p => p.Description).Include(p => p.Price).Include(p => p.Ranking).FirstOrDefaultAsync(p => p.Id == id);

            if (product != null)
            {
                _logger.LogInformation($"Update Product {id}");
                if (!string.IsNullOrWhiteSpace(inputModel.Name) && product.Name != inputModel.Name)
                {
                    _logger.LogInformation("Updata name");
                    _dbContext.Add(new ProductNameHistory() { Product = product, From = product.Name, To = inputModel.Name });
                    product.Name = inputModel.Name;
                }

                if (!string.IsNullOrWhiteSpace(inputModel.Description) && product.Description.Description != inputModel.Description)
                {
                    _logger.LogInformation("Update description");
                    _dbContext.Add(new ProductDescriptionHistory() { Product = product, From = product.Description.Description, To = inputModel.Description });
                    product.Description.Description = inputModel.Description;
                }

                if (inputModel.Price.HasValue && product.Price.Price != inputModel.Price)
                {
                    _logger.LogInformation("Update pricing");
                    _dbContext.Add(new ProductPriceHistory() { Product = product, From = product.Price.Price, To = inputModel.Price.Value });
                    product.Price.Price = inputModel.Price.Value;
                }

                if (inputModel.Ranking.HasValue && product.Ranking.Rank != inputModel.Ranking)
                {
                    _logger.LogInformation("Update ranking");
                    _dbContext.Add(new ProductRankingHistory() { Product = product, From = product.Ranking.Rank, To = inputModel.Ranking.Value });
                    product.Ranking.Rank = inputModel.Ranking.Value;
                }

                _dbContext.Update(product);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
