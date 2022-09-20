﻿using API.Models.InputModels;
using Database.Models.DTO;

namespace Database
{
    public interface IProductsDAL
    {
        Task<Guid> CreateProduct(Product inputModel);

        Task<List<ProductType>> GetProductTypeDtos();

        Task<HashSet<ProductDtoForPublishing>> GetUnPublishedProducts();

        Task ProductPublished(ProductDtoForPublishing productGuid);
    }
}
