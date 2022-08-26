using Database.Models;
using ProductCatalogue.Models.InputModels;

namespace Database.SpecificationPattern.Specifications
{
    public class ProductSearchSpecification : BaseSpecification<Product>
    {
        public ProductSearchSpecification(ProductSearchInputModel productSearchInputModel)
        {
            if (productSearchInputModel.Id != null)
            {
                Criteria = i => i.Id == productSearchInputModel.Id;
            }

            if (productSearchInputModel.ProductTypeId > 0)
            {
                Criteria = i => i.ProductType.Id == productSearchInputModel.ProductTypeId;
            }

            if (!string.IsNullOrWhiteSpace(productSearchInputModel.Name))
            {
                Criteria = i => i.Name.Contains(productSearchInputModel.Name);
            }
        }
    }
}
