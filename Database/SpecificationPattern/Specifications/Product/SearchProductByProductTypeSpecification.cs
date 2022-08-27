using API.Models.InputModels;

namespace Database.SpecificationPattern.Specifications
{
    public class SearchProductByProductTypeSpecification : BaseSpecification<Models.Product>
    {
        public SearchProductByProductTypeSpecification(ProductSearchInputModel productSearchInputModel)
        {
            Criteria = p => p.ProductType.Id == productSearchInputModel.ProductTypeId;
        }
    }
}
