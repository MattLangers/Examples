using API.Models.InputModels;

namespace Database.SpecificationPattern.Specifications.Product
{
    public class SearchProductByGuidSpecification : BaseSpecification<Models.Product>
    {
        public SearchProductByGuidSpecification(ProductSearchInputModel productSearchInputModel)
        {
            Criteria = p => p.Id == productSearchInputModel.Id;
            Includes.Add(i => i.ProductType);
        }
    }
}
