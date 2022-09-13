using API.Models.OutputModels;

namespace API.Models.Factories
{
    public interface IOutputModelFactory
    {
        public ProductId Create(Guid id);
    }
}
