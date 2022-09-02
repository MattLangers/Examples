using API.Models.InputModels;
using Database.Factories;
using Database.Models.DTO;
using Database.SpecificationPattern;
using Database.SpecificationPattern.Specifications;
using Database.SpecificationPattern.Specifications.Product;
using Microsoft.Extensions.Logging;

namespace Database.Search
{
    public class DatabaseSearchOrchestrator : IDatabaseSearchOrchestrator
    {
        private readonly ILogger logger;
        private readonly DatabaseContext context;
        private readonly IProductDtoFactory productDtoFactory;

        public DatabaseSearchOrchestrator(
            ILogger<DatabaseSearchOrchestrator> logger,
            DatabaseContext context,
            IProductDtoFactory productDtoFactory)
        {
            this.context = context;
            this.logger = logger;
            this.productDtoFactory = productDtoFactory;
        }

        public IList<ProductDto> SearchProducts(ProductSearchInputModel productSearchInputModel)
        {
            var products = context.Product;

            var hasGuid = productSearchInputModel.Id != null;
            var hasProductTypeId = productSearchInputModel.ProductTypeId > 0;
            var hasName = !string.IsNullOrWhiteSpace(productSearchInputModel.Name);

            if (hasGuid && hasProductTypeId && hasName)
            {
                return FactoryCreate(products.Specify(SearchByGuid(productSearchInputModel)).Specify(SearchByProductId(productSearchInputModel)).Specify(SearchByName(productSearchInputModel)));
            }

            if (hasGuid && hasProductTypeId && !hasName)
            {
                return FactoryCreate(products.Specify(SearchByGuid(productSearchInputModel)).Specify(SearchByProductId(productSearchInputModel)));
            }

            if (!hasGuid && hasProductTypeId && hasName)
            {
                return FactoryCreate(products.Specify(SearchByProductId(productSearchInputModel)).Specify(SearchByName(productSearchInputModel)));
            }

            if (!hasGuid && hasProductTypeId && !hasName)
            {
                return FactoryCreate(products.Specify(SearchByProductId(productSearchInputModel)));
            }

            if (hasGuid && !hasProductTypeId && !hasName)
            {
                return FactoryCreate(products.Specify(SearchByGuid(productSearchInputModel)));
            }

            if (!hasGuid && !hasProductTypeId && hasName)
            {
                return FactoryCreate(products.Specify(SearchByName(productSearchInputModel)));
            }

            if (hasGuid && !hasProductTypeId && hasName)
            {
                return FactoryCreate(products.Specify(SearchByGuid(productSearchInputModel)).Specify(SearchByName(productSearchInputModel)));
            }

            logger.LogInformation($"There are no search parameters defined");
            return FactoryCreate(products.Specify(new SearchAllProductSpecification()));
        }

        private IList<ProductDto> FactoryCreate(IQueryable<Models.Product> products)
        {
            var result = new List<ProductDto>();

            foreach (var product in products)
            {
                result.Add(productDtoFactory.Create(product.Id, product.Name, product.CreationDate, product.ProductType.Id, product.ProductType.Name));
            }

            return result;
        }

        static SearchProductByGuidSpecification SearchByGuid(ProductSearchInputModel inputModel)
        {
            return new SearchProductByGuidSpecification(inputModel);
        }

        static SearchProductByProductTypeSpecification SearchByProductId(ProductSearchInputModel inputModel)
        {
            return new SearchProductByProductTypeSpecification(inputModel);
        }

        static SearchProductByNameSpecification SearchByName(ProductSearchInputModel inputModel)
        {
            return new SearchProductByNameSpecification(inputModel);
        }
    }
}
