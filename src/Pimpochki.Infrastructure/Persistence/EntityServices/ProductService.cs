using AutoMapper;
using Pimpochki.Application.Dtos.ImageDtos;
using Pimpochki.Application.Dtos.ProductDtos;
using Pimpochki.Application.Persistence.EntityRepositories;
using Pimpochki.Application.Persistence.EntityServices;
using Pimpochki.Domain.Entities;

namespace Pimpochki.Infrastructure.Persistence.EntityServices;

public class ProductService:IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;
    private readonly IImageService _imageService;
    public ProductService(IProductRepository productRepository,IMapper mapper,IImageService imageService)
    {
        _productRepository = productRepository;
        _mapper = mapper;
        _imageService = imageService;
    }
    
    public IEnumerable<ProductDto> GetAllProducts()
    {
        var products =  _productRepository.GetAll();
        var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products);
        return productsDto;
    }

    public async Task<ProductDto> GetProduct(int id)
    {
        var product = await _productRepository.GetAsync(obj => obj.Id == id);
        var productDto = _mapper.Map<ProductDto>(product);
        return productDto;
    }

    public void DeleteProduct(Product product)
    {
        _productRepository.Delete(product);
        _productRepository.SaveChages();
    }

    public async Task BuyProduct(int quantity,Product product)
    {
        product.Quantity -= quantity;
        await _productRepository.SaveChages();
    }

    public async Task CreateProduct(CreateProductDto productDto)
    {
        var product = _mapper.Map<Product>(productDto);
        await _productRepository.InsertAsync(product);
        await _productRepository.SaveChages();
    }

    public void UpdateProduct(UpdateProductDto productDto)
    {
        var productDtoToUpdate = _mapper.Map<Product>(productDto);
         _productRepository.Update(productDtoToUpdate);
         _productRepository.SaveChages();
    }

    public IEnumerable<ImageDto> GetAllImages(int id)
    {
        var images = _imageService.GetAllImages(id);
        return images;
    }

    public async Task AddQuantity(int quantity, Product product)
    {
        product.Quantity += quantity;
        await _productRepository.SaveChages();
    }
}