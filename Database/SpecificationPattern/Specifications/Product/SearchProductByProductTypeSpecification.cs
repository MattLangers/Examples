using API.Models.InputModels;
using Database.SpecificationPattern.Specifications.Product;

namespace Database.SpecificationPattern.Specifications
{
    public sealed class SearchProductByProductTypeSpecification : SearchProductBaseWithInclude
    {
        public SearchProductByProductTypeSpecification(ProductSearchInputModel productSearchInputModel)
        {
            Criteria = p => p.ProductType.Id == productSearchInputModel.ProductTypeId && p.Archived == productSearchInputModel.Archived;
        }
    }
}
