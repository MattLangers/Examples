using Database.Models;
using Microsoft.EntityFrameworkCore;
using ProductCatalogue.Models.InputModels;

namespace Database.SpecificationPattern.Specifications
{
    public class SearchProductByNameSpecification : BaseSpecification<Models.Product>
    {
        public SearchProductByNameSpecification(ProductSearchInputModel productSearchInputModel)
        {
            Criteria = p => EF.Functions.Like(p.Name, $"%{productSearchInputModel.Name}%");
        }
    }
}
