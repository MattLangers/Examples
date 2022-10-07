using API.Models.InputModels;

namespace Database.SpecificationPattern.Specifications
{
    public sealed class SearchProductByProductTypeSpecification : BaseSpecification<Models.Product>
    {
        public SearchProductByProductTypeSpecification(ProductSearchInputModel productSearchInputModel)
        {
            Criteria = p => p.ProductType.Id == productSearchInputModel.ProductTypeId && p.Archived == productSearchInputModel.Archived;
            Includes.Add(i => i.ProductType);
        }
    }
}
