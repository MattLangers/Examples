using Database.Models;

namespace Database.SpecificationPattern.Specifications
{
    public class ProductByProductTypeSpecification : BaseSpecification<Product>
    {
        public ProductByProductTypeSpecification(int productTypeId)
        {
            Criteria = i => i.ProductType.Id == productTypeId;
        }
    }
}
