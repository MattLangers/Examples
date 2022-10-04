using System;
using System.Collections.Generic;
using Database.Models.DTO;

namespace Publisher.Tests.Logic.PublisherOrchestration.Start
{
    internal class ProductBuilder
    {
        public List<ProductDtoForPublishing> Create(int x)
        {
            var result = new List<ProductDtoForPublishing>();

            for (var i = 0; i < x; i++)
            {
                result.Add(new ProductDtoForPublishing { Id = Guid.NewGuid() });
            }

            return result;
        }
    }
}
