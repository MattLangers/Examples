using API.Models.InputModels;
using Database.SpecificationPattern.Specifications.Product;
using Microsoft.EntityFrameworkCore;

namespace Database.SpecificationPattern.Specifications
{
    public sealed class SearchProductByNameSpecification : SearchProductBaseWithInclude
    {
        public SearchProductByNameSpecification(ProductSearchInputModel productSearchInputModel)
        {
            Criteria = p => EF.Functions.Like(p.Name, $"%{productSearchInputModel.Name}%") && p.Archived == productSearchInputModel.Archived;
        }
    }
}
