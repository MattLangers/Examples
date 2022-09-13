﻿namespace Database.Models.DTO
{
    public sealed class ProductDtoForPublishing
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = default!;

        public int ProductTypeId { get; set; }
    }
}
