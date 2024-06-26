﻿using Pimpochki.Application.Dtos.ImageDtos;
using Pimpochki.Application.Dtos.ProductDtos;
using Pimpochki.Domain.Entities;

namespace Pimpochki.Application.Persistence.EntityServices;

public interface IProductService
{
    IEnumerable<ProductDto> GetAllProducts();
    Task<ProductDto> GetProduct(int id);
    Task DeleteProduct(Product product);
    Task BuyProduct(int quantity,Product product);
    Task CreateProduct(UpsertProductDto productDto);
    Task UpdateProduct(UpsertProductDto productDto);
    IEnumerable<ImageDto> GetAllImages(int id);
    Task AddQuantity(int quantity,Product product);
}