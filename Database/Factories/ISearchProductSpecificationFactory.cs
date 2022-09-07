using API.Models.InputModels;
using Database.SpecificationPattern.Specifications;
using Database.SpecificationPattern.Specifications.Product;

namespace Database.Factories
{
    public interface ISearchProductSpecificationFactory
    {
        SearchAllProductSpecification CreateSearchForAllProducts();

        SearchProductByGuidSpecification CreateSearchByGuid(ProductSearchInputModel productSearchInputModel);

        SearchProductByNameSpecification CreateSearchByName(ProductSearchInputModel productSearchInputModel);

        SearchProductByProductTypeSpecification CreateSearchByProductType(ProductSearchInputModel productSearchInputModel);
    }
}
