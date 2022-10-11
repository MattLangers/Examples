namespace Database.SpecificationPattern.Specifications.Product
{
    public class SearchProductBaseWithInclude : BaseSpecification<Models.Product>
    {
        public SearchProductBaseWithInclude()
        {
            Includes.Add(i => i.ProductType);
            Includes.Add(i => i.Description);
            Includes.Add(i => i.Price);
            Includes.Add(i => i.Ranking);
        }
    }
}
