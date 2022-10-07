namespace Database.SpecificationPattern.Specifications.Product
{
    public sealed class SearchAllProductSpecification : BaseSpecification<Models.Product>
    {
        public SearchAllProductSpecification()
        {
            Criteria = p => p.Archived == false;
            Includes.Add(i => i.ProductType);
        }
    }
}
