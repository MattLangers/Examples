using API.Models.OutputModels;

namespace API.Models.Factories
{
    public sealed class OutputModelFactory : IOutputModelFactory
    {
        public ProductId Create(Guid id)
        {
            return new ProductId() { Id = id };
        }
    }
}
