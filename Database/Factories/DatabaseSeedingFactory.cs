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

        public IList<ProductDescription> CreateProductDescriptions()
        {
            var values = FastEnum.GetValues<Enums.Products>();
            var productDesciptions = new List<ProductDescription>();

            foreach (var value in values)
            {
#pragma warning disable CS8604 // Possible null reference argument.
                productDesciptions.Add(new ProductDescription() { Id = Guid.Parse(value.GetLabel()), Description = Description() });
#pragma warning restore CS8604 // Possible null reference argument.
            }

            return productDesciptions;
        }

        public IList<ProductPrice> CreateProductPrices()
        {
            var values = FastEnum.GetValues<Enums.Products>();
            var productPrices = new List<ProductPrice>();

            foreach (var value in values)
            {
#pragma warning disable CS8604 // Possible null reference argument.
                productPrices.Add(new ProductPrice() { Id = Guid.Parse(value.GetLabel()), Price = float.Parse("0.99") });
#pragma warning restore CS8604 // Possible null reference argument.
            }

            return productPrices;
        }

        public IList<ProductRanking> CreateProductRankings()
        {
            var values = FastEnum.GetValues<Enums.Products>();
            var productRankings = new List<ProductRanking>();

            foreach (var value in values)
            {
#pragma warning disable CS8604 // Possible null reference argument.
                productRankings.Add(new ProductRanking() { Id = Guid.Parse(value.GetLabel()), Rank = 3 });
#pragma warning restore CS8604 // Possible null reference argument.
            }

            return productRankings;
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

        public string Description()
        {
            return "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Odio eligendi similique exercitationem optio libero vitae accusamus cupiditate laborum eos.";
        }
    }
}
