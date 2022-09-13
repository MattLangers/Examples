using Moq.AutoMock;
using Database.Enums;

namespace Database.Tests.Enums.MapEnumToEnum.MapProductToProductType
{
    public sealed class EnsureAllProductsAreMappedTests
    {
        private readonly Database.Enums.MapEnumToEnum mapEnumToEnum = new AutoMocker().CreateInstance<Database.Enums.MapEnumToEnum>();

        [Test]
        public void All_Products_Map_To_A_ProductType([Values] Products products)
        {
            Assert.DoesNotThrow(() => mapEnumToEnum.MapProductToProductType(products));
        }
    }
}
