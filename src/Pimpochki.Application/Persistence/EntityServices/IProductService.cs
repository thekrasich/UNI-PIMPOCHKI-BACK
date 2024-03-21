using Pimpochki.Application.Dtos.ImageDtos;
using Pimpochki.Application.Dtos.ProductDtos;
using Pimpochki.Domain.Entities;

namespace Pimpochki.Application.Persistence.EntityServices;

public interface IProductService
{
    IEnumerable<ProductDto> GetAllProducts();
    Task<ProductDto> GetProduct(int id);
    void DeleteProduct(Product product);
    Task BuyProduct(int quantity,Product product);
    Task CreateProduct(CreateProductDto productDto);
    void UpdateProduct(UpdateProductDto productDto);
    IEnumerable<ImageDto> GetAllImages(int id);
    Task AddQuantity(int quantity,Product product);
}