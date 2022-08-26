using Database.Models;
using Database.SpecificationPattern;
using Database.SpecificationPattern.Specifications;
using Microsoft.Extensions.Logging;
using ProductCatalogue.Models.InputModels;

namespace Database.Search
{
    public class DatabaseSearchOrchestrator : IDatabaseSearchOrchestrator
    {
        private readonly ILogger<DatabaseSearchOrchestrator> logger;
        private readonly DatabaseContext _context;

        public DatabaseSearchOrchestrator(
            ILogger<DatabaseSearchOrchestrator> logger,
            DatabaseContext context)
        {
            _context = context;
            this.logger = logger;
        }

        public List<Product> SearchProducts(ProductSearchInputModel productSearchInputModel)
        {
            var products = _context.Product;

            var hasGuid = productSearchInputModel.Id != null;
            var hasProductTypeId = productSearchInputModel.ProductTypeId > 0;
            var hasName = !string.IsNullOrWhiteSpace(productSearchInputModel.Name);

            if (hasGuid && hasProductTypeId && hasName)
            {
                return products.Specify(SearchByGuid(productSearchInputModel)).Specify(SearchByProductId(productSearchInputModel)).Specify(SearchByName(productSearchInputModel)).ToList();
            }

            if (hasGuid && hasProductTypeId && !hasName)
            {
                return products.Specify(SearchByGuid(productSearchInputModel)).Specify(SearchByProductId(productSearchInputModel)).ToList();
            }

            if (!hasGuid && hasProductTypeId && hasName)
            {
                return products.Specify(SearchByProductId(productSearchInputModel)).Specify(SearchByName(productSearchInputModel)).ToList();
            }

            if (!hasGuid && hasProductTypeId && !hasName)
            {
                return products.Specify(SearchByProductId(productSearchInputModel)).ToList();
            }

            if (hasGuid && !hasProductTypeId && !hasName)
            {
                return products.Specify(SearchByGuid(productSearchInputModel)).ToList();
            }

            if (!hasGuid && !hasProductTypeId && hasName)
            {
                return products.Specify(SearchByName(productSearchInputModel)).ToList();
            }

            if (hasGuid && !hasProductTypeId && hasName)
            {
                return products.Specify(SearchByGuid(productSearchInputModel)).Specify(SearchByName(productSearchInputModel)).ToList();
            }

            logger.LogInformation($"There are no search parameters defined");
            return products.ToList();
        }

        static SearchProductByGuidSpecification SearchByGuid(ProductCatalogue.Models.InputModels.ProductSearchInputModel inputModel)
        {
            return new SearchProductByGuidSpecification(inputModel);
        }

        static SearchProductByProductTypeSpecification SearchByProductId(ProductCatalogue.Models.InputModels.ProductSearchInputModel inputModel)
        {
            return new SearchProductByProductTypeSpecification(inputModel);
        }

        static SearchProductByNameSpecification SearchByName(ProductCatalogue.Models.InputModels.ProductSearchInputModel inputModel)
        {
            return new SearchProductByNameSpecification(inputModel);
        }
    }
}
