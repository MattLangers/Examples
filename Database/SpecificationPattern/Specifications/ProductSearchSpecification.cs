using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.SpecificationPattern.Specifications
{
    public class ProductSearchSpecification : BaseSpecification<Product>
    {
        public ProductSearchSpecification(ProductSearchInputModel productSearchInputModel)
        {

        }
        public ProductSearchSpecification(int productTypeId)
        {
            Criteria = i => i.ProductType.Id == productTypeId;
        }

        public ProductSearchSpecification(Guid id)
        {
            Criteria = i => i.Id == id;
        }

        public ProductSearchSpecification(string name)
        {
            Criteria = i => i.Name.Contains(name);
        }
    }
}
