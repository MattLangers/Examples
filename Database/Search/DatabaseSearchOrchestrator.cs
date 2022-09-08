using API.Models.InputModels;
using Database.Factories;
using Database.Models.DTO;
using Database.SpecificationPattern;
using Microsoft.Extensions.Logging;

namespace Database.Search
{
    public class DatabaseSearchOrchestrator : IDatabaseSearchOrchestrator
    {
        private readonly ILogger logger;
        private readonly DatabaseContext context;
        private readonly IProductsToDtoMapper productsToDtoMapper;
        private readonly ISearchProductSpecificationFactory searchProductSpecificationFactory;

        public DatabaseSearchOrchestrator(
            ILogger<DatabaseSearchOrchestrator> logger,
            DatabaseContext context,
            IProductsToDtoMapper productsToDtoMapper,
            ISearchProductSpecificationFactory searchProductSpecificationFactory)
        {
            this.context = context;
            this.logger = logger;
            this.productsToDtoMapper = productsToDtoMapper;
            this.searchProductSpecificationFactory = searchProductSpecificationFactory;
        }

        public IList<ProductDto> SearchProducts(ProductSearchInputModel productSearchInputModel)
        {
            var products = context.Product;

            var hasGuid = productSearchInputModel.Id != null;
            var hasProductTypeId = productSearchInputModel.ProductTypeId > 0;
            var hasName = !string.IsNullOrWhiteSpace(productSearchInputModel.Name);

            if (hasGuid && hasProductTypeId && hasName)
            {
                return productsToDtoMapper.Map(products.Specify(searchProductSpecificationFactory.CreateSearchByGuid(productSearchInputModel)).Specify(searchProductSpecificationFactory.CreateSearchByProductType(productSearchInputModel)).Specify(searchProductSpecificationFactory.CreateSearchByName(productSearchInputModel)));
            }

            if (hasGuid && hasProductTypeId && !hasName)
            {
                return productsToDtoMapper.Map(products.Specify(searchProductSpecificationFactory.CreateSearchByGuid(productSearchInputModel)).Specify(searchProductSpecificationFactory.CreateSearchByProductType(productSearchInputModel)));
            }

            if (!hasGuid && hasProductTypeId && hasName)
            {
                return productsToDtoMapper.Map(products.Specify(searchProductSpecificationFactory.CreateSearchByProductType(productSearchInputModel)).Specify(searchProductSpecificationFactory.CreateSearchByName(productSearchInputModel)));
            }

            if (!hasGuid && hasProductTypeId && !hasName)
            {
                return productsToDtoMapper.Map(products.Specify(searchProductSpecificationFactory.CreateSearchByProductType(productSearchInputModel)));
            }

            if (hasGuid && !hasProductTypeId && !hasName)
            {
                return productsToDtoMapper.Map(products.Specify(searchProductSpecificationFactory.CreateSearchByGuid(productSearchInputModel)));
            }

            if (!hasGuid && !hasProductTypeId && hasName)
            {
                return productsToDtoMapper.Map(products.Specify(searchProductSpecificationFactory.CreateSearchByName(productSearchInputModel)));
            }

            if (hasGuid && !hasProductTypeId && hasName)
            {
                return productsToDtoMapper.Map(products.Specify(searchProductSpecificationFactory.CreateSearchByGuid(productSearchInputModel)).Specify(searchProductSpecificationFactory.CreateSearchByName(productSearchInputModel)));
            }

            logger.LogInformation($"There are no search parameters defined");
            return productsToDtoMapper.Map(products.Specify(searchProductSpecificationFactory.CreateSearchForAllProducts()));
        }
    }
}
