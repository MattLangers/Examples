using System.Collections.Generic;
using Database.Models.DTO;

namespace Publisher.Tests.Logic.PublisherOrchestration.Start
{
    internal class ProductBuilder
    {
        public HashSet<ProductDtoForPublishing> Create(int x)
        {
            var result = new HashSet<ProductDtoForPublishing>();

            for (var i = 0; i < x; i++)
            {
                result.Add(new ProductDtoForPublishing { Id = new System.Guid() });
            }

            return result;
        }
    }
}
