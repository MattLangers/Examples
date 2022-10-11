namespace Database.SpecificationPattern.Specifications.Product
{
    public sealed class SearchAllProductSpecification : SearchProductBaseWithInclude
    {
        public SearchAllProductSpecification()
        {
            Criteria = p => p.Archived == false;
        }
    }
}
