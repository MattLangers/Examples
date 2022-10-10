namespace Database.SpecificationPattern.Specifications.Product
{
    public class SearchProductBaseWithInclude : BaseSpecification<Models.Product>
    {
        public SearchProductBaseWithInclude()
        {
            Includes.Add(i => i.ProductType);
            Includes.Add(i => i.ProductDescriptions.OrderByDescending(pd => pd.Id).Take(1));
            Includes.Add(i => i.ProductPrices.OrderByDescending(pp => pp.Id).Take(1));
            Includes.Add(i => i.ProductRankings.OrderByDescending(pr => pr.Id).Take(1));
        }
    }
}
