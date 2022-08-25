using Database.Enums;
using Database.Models;
using FastEnumUtility;
using ProductType = Database.Models.ProductType;

namespace Database.Factories
{
    internal class DatabaseSeedingFactory : IDatabaseSeedingFactory
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
                products.Add(new Product()
                {
                    Name = value.GetEnumMemberValue(),
                    ProductType = new Models.ProductType() { Id = (int)mapEnumToEnum.MapProductToProductType(value) }
                });
            }

            return products;
        }

        public IList<ProductType> CreateProductTypes()
        {
            var values = FastEnum.GetValues<Enums.ProductType>();

            var productTypes = new List<ProductType>();

            foreach (var value in values)
            {
                productTypes.Add(new ProductType()
                {
                    Id = (int)value,
                    Name = FastEnum.GetName(value),
                });
            }

            return productTypes;
        }
    }
}
