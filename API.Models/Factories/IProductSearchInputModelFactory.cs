using API.Models.InputModels;

namespace API.Models.Factories
{
    public interface IProductSearchInputModelFactory
    {
        ProductSearchInputModel Create(string id, int? productTypeId, string name);
    }
}
