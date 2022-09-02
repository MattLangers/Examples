using API.Models.InputModels;
using Microsoft.EntityFrameworkCore;

namespace Database.SpecificationPattern.Specifications
{
    public class SearchProductByNameSpecification : BaseSpecification<Models.Product>
    {
        public SearchProductByNameSpecification(ProductSearchInputModel productSearchInputModel)
        {
            Criteria = p => EF.Functions.Like(p.Name, $"%{productSearchInputModel.Name}%");
            Includes.Add(i => i.ProductType);
        }
    }
}
