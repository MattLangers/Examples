using ProductCatalogue.Models.InputModels;

namespace ProductCatalogue.Models.Factories
{
    public interface IProductSearchInputModelFactory
    {
        ProductSearchInputModel Create(string id, int? productTypeId, string name);
    }
}
