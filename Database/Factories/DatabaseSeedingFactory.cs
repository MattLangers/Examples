using Database.Models;
using FastEnumUtility;

namespace Database.Factories
{
    internal class DatabaseSeedingFactory : IDatabaseSeedingFactory
    {
        public IList<ProductType> CreateProductTypes()
        {
            var values = FastEnum.GetValues<Enums.ProductType>();

            var productTypes = new List<ProductType>();

            foreach (var value in values)
            {
                productTypes.Add(new ProductType()
                {
                    Id = (int)value,
                    Name = FastEnum.GetName(value)
                });
            }

            return productTypes;
        }
    }
}
