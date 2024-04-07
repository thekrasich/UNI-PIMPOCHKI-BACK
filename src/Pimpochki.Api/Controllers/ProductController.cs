
using Microsoft.AspNetCore.Mvc;
using Pimpochki.Application.ActionFilters;
using Pimpochki.Application.ActionFilters.ProductActionFilters;
using Pimpochki.Application.Dtos.ProductDtos;
using Pimpochki.Application.Persistence.EntityRepositories;
using Pimpochki.Application.Persistence.EntityServices;
using Pimpochki.Domain.Entities;
using Swashbuckle.AspNetCore.Annotations;

namespace Pimpochki.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IProductRepository _productRepository;

        public ProductController(IProductService productService,IProductRepository productRepository)
        {
            _productService = productService;
            _productRepository = productRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetProducts()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }

        [TypeFilter(typeof(ProductExistFilterAttribute))]
        [HttpGet("{productId}")]
        public async Task<ProductDto> GetById([FromRoute]int productId)
        {
            var product = await _productService.GetProduct(productId);
            return product;
        }

        [TypeFilter(typeof(ProductExistFilterAttribute))]
        [HttpGet("{productId}/images")]
        public IActionResult GetImages([FromRoute] int productId)
        {
            var images = _productService.GetAllImages(productId);
            return Ok();
        }
        
        [HttpPost]
        [ModelStateFilter]
        public async Task CreateProduct([FromBody] CreateProductDto productDto)
        {
            await _productService.CreateProduct(productDto);
        }

        [HttpDelete("{productId}")]
        [TypeFilter(typeof(ProductExistFilterAttribute))]
        public async  Task<IActionResult> DeleteProduct([FromRoute] int productId)
        {
            var product = await _productRepository.GetAsync(obj =>obj.Id == productId);
            await _productService.DeleteProduct(product);
            return Ok();
        }

        [HttpPatch("buy/{quantity}")]//?
        [TypeFilter(typeof(ProductExistFilterAttribute))]
        public async Task BuyProduct([FromRoute]int quantity,int productId)
        {
            var product = await _productRepository.GetAsync(obj => obj.Id == productId);
            await _productService.BuyProduct(quantity, product);
        }
        
        [ModelStateFilter]
        [HttpPut("{productId}")]
        [TypeFilter(typeof(ProductExistFilterAttribute))]
        public IActionResult UpdateProducts([FromRoute] int productId,[FromBody] UpdateProductDto updateProductDto)
        {
            _productService.UpdateProduct(updateProductDto);
            return Ok();
        }
        
        [TypeFilter(typeof(ProductExistFilterAttribute))]
        [HttpPatch("add-quantity/{quantity}/{productId}")]
        public async Task QuantityAdding([FromRoute]int quantity,[FromRoute] int productId)
        {
            var product = await _productRepository.GetAsync(obj => obj.Id == productId);
            await _productService.AddQuantity(quantity, product);
        }
    }
}
