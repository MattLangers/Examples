namespace Database.Enums
{
    public sealed class MapEnumToEnum : IMapEnumToEnum
    {
        public ProductType MapProductToProductType(Products product) => product switch
        {
            Products.SherbetFountain => ProductType.Sherbet,
            Products.CadburyCremeEgg => ProductType.Chocolate,
            Products.CurlyWurly => ProductType.Chocolate,
            Products.LiquoriceAllsorts => ProductType.Liquorice,
            Products.CoconutMushrooms => ProductType.Chewy,
            Products.JellyBabies => ProductType.Chewy,
            Products.DollyMixtures => ProductType.Chewy,
            _ => throw new ArgumentOutOfRangeException(nameof(product), $"Not expected product value: {product}"),
        };
    }
}
