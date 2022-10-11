using API.Models.InputModels;

namespace Database.SpecificationPattern.Specifications.Product
{
    public sealed class SearchProductByGuidSpecification : SearchProductBaseWithInclude
    {
        public SearchProductByGuidSpecification(ProductSearchInputModel productSearchInputModel)
        {
            Criteria = p => p.Id == productSearchInputModel.Id && p.Archived == productSearchInputModel.Archived;

        }
    }
}
