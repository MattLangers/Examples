﻿using API.Models.InputModels;
using Database.Models.DTO;

namespace Database
{
    public interface IProductsDAL
    {
        Task<Guid> CreateProduct(CreateProductInputModel inputModel);

        Task<List<ProductTypeDtoWithDateCreated>> GetProductTypeDtos();

        Task<HashSet<ProductDtoForPublishing>> GetUnPublishedProducts();

        Task ProductPublished(ProductDtoForPublishing productGuid);
    }
}
