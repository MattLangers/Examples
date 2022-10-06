using API.Models.InputModels;
using Database.Factories;
using Database.Models.DTO;
using Database.SpecificationPattern;
using Microsoft.Extensions.Logging;

namespace Database.Search
{
    public sealed class DatabaseSearchOrchestrator : IDatabaseSearchOrchestrator
    {
        private readonly ILogger logger;
        private readonly DatabaseContext context;
        private readonly IMapProductsToDto productsToDtoMapper;
        private readonly ISearchProductSpecificationFactory searchProductSpecificationFactory;

        public DatabaseSearchOrchestrator(
            ILogger<DatabaseSearchOrchestrator> logger,
            DatabaseContext context,
            IMapProductsToDto productsToDtoMapper,
            ISearchProductSpecificationFactory searchProductSpecificationFactory)
        {
            this.context = context;
            this.logger = logger;
            this.productsToDtoMapper = productsToDtoMapper;
            this.searchProductSpecificationFactory = searchProductSpecificationFactory;
        }

        public IList<ProductDto> SearchProducts(ProductSearchInputModel productSearchInputModel)
        {
            var products = context.Product.AsQueryable();

            var hasGuid = productSearchInputModel.Id != null;
            var hasProductTypeId = productSearchInputModel.ProductTypeId > 0;
            var hasName = !string.IsNullOrWhiteSpace(productSearchInputModel.Name);

            if (hasGuid)
            {
                logger.LogInformation("Create search for guid");
                products = products.Specify(searchProductSpecificationFactory.CreateSearchByGuid(productSearchInputModel));
            }

            if (hasProductTypeId)
            {
                logger.LogInformation("Create search for product type");
                products = products.Specify(searchProductSpecificationFactory.CreateSearchByProductType(productSearchInputModel));
            }

            if (hasName)
            {
                logger.LogInformation("Create search for name");
                products = products.Specify(searchProductSpecificationFactory.CreateSearchByName(productSearchInputModel));
            }

            if (hasGuid || hasProductTypeId || hasName)
            {
                logger.LogInformation("Return products for search");
                return productsToDtoMapper.Map(products);
            }

            logger.LogInformation($"There are no search parameters defined");
            return productsToDtoMapper.Map(products.Specify(searchProductSpecificationFactory.CreateSearchForAllProducts()));
        }
    }
}
