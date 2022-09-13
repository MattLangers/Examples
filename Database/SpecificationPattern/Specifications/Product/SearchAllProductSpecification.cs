namespace Database.SpecificationPattern.Specifications.Product
{
    public sealed class SearchAllProductSpecification : BaseSpecification<Models.Product>
    {
        public SearchAllProductSpecification()
        {
            Criteria = p => true;
            Includes.Add(i => i.ProductType);
        }
    }
}
