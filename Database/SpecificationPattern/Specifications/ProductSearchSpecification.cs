using API.Models.InputModels;
using Database.Models;

namespace Database.SpecificationPattern.Specifications
{
    public class SearchProductByGuidSpecification : BaseSpecification<Models.Product>
    {
        public SearchProductByGuidSpecification(ProductSearchInputModel productSearchInputModel)
        {
            Criteria = p => p.Id == productSearchInputModel.Id;
        }
    }
}
