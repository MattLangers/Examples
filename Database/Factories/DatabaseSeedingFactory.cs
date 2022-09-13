using Database.Enums;
using Database.Models;
using FastEnumUtility;
using ProductType = Database.Models.ProductType;

namespace Database.Factories
{
    internal sealed class DatabaseSeedingFactory : IDatabaseSeedingFactory
    {
        private readonly IMapEnumToEnum mapEnumToEnum;

        public DatabaseSeedingFactory(IMapEnumToEnum mapEnumToEnum)
        {
            this.mapEnumToEnum = mapEnumToEnum;
        }

        public IList<Product> CreateProducts()
        {
            var values = FastEnum.GetValues<Enums.Products>();
            var products = new List<Product>();

            foreach (var value in values)
            {
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8601 // Possible null reference assignment.
                products.Add(new Product()
                {
                    Id = Guid.Parse(value.GetLabel()),
                    Name = value.GetEnumMemberValue(),
                    ProductTypeId = (int)mapEnumToEnum.MapProductToProductType(value)
                });
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore CS8604 // Possible null reference argument.
            }

            return products;
        }

        public IList<ProductType> CreateProductTypes()
        {
            var values = FastEnum.GetValues<Enums.ProductType>();

            var productTypes = new List<ProductType>();

            foreach (var value in values)
            {
#pragma warning disable CS8601 // Possible null reference assignment.
                productTypes.Add(new ProductType()
                {
                    Id = (int)value,
                    Name = FastEnum.GetName(value),
                });
#pragma warning restore CS8601 // Possible null reference assignment.
            }

            return productTypes;
        }
    }
}
