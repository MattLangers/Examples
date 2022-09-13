using API.Models.InputModels;
using Database.SpecificationPattern.Specifications;
using Database.SpecificationPattern.Specifications.Product;

namespace Database.Factories
{
    public sealed class SearchProductSpecificationFactory : ISearchProductSpecificationFactory
    {
        public SearchProductByGuidSpecification CreateSearchByGuid(ProductSearchInputModel productSearchInputModel)
        {
            return new SearchProductByGuidSpecification(productSearchInputModel);
        }

        public SearchProductByNameSpecification CreateSearchByName(ProductSearchInputModel productSearchInputModel)
        {
            return new SearchProductByNameSpecification(productSearchInputModel);
        }

        public SearchProductByProductTypeSpecification CreateSearchByProductType(ProductSearchInputModel productSearchInputModel)
        {
            return new SearchProductByProductTypeSpecification(productSearchInputModel);
        }

        public SearchAllProductSpecification CreateSearchForAllProducts()
        {
            return new SearchAllProductSpecification();
        }
    }
}
