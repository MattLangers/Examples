using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace ProductCatalogue.Models.InputModels
{
    public class ProductSearchInputModel
    {
        public Guid? Id { get; init; }

        public int ProductTypeId { get; init; }

        public string? Name { get; init; }

        public bool HasSearchPropertiesDefined { get; init; } = false;
    }
}
