using Database.Models;
using ProductCatalogue.Models.InputModels;

namespace Database.SpecificationPattern.Specifications
{
    public class ProductSearchSpecification : BaseSpecification<Product>
    {
        public ProductSearchSpecification(ProductSearchInputModel productSearchInputModel)
        {
            if (productSearchInputModel.HasSearchPropertiesDefined)
            {
                Criteria = p => true;
            }

            if (productSearchInputModel.Id != null)
            {
                Criteria = p => p.Id == productSearchInputModel.Id;
            }

            if (productSearchInputModel.ProductTypeId > 0)
            {
                Criteria = p => p.ProductType.Id == productSearchInputModel.ProductTypeId;
            }

            if (!string.IsNullOrWhiteSpace(productSearchInputModel.Name))
            {
                Criteria = p => p.Name.Contains(productSearchInputModel.Name);
            }
        }
    }
}
