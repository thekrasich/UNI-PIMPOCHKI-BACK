
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
        public async Task<ProductDto> GetById(int productId)
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
        public async Task CreateProduct([FromBody] CreateProductDto productDto)
        {
            await _productService.CreateProduct(productDto);
        }

        [HttpDelete("{productId}")]
        public  IActionResult DeleteProduct([FromRoute] int productId)
        {
            Product product = new()
            {
                Id = 1,
                Name = "string",
                Description = "string",
                Price = 1,
                Quantity = 214
            };
            _productService.DeleteProduct(product);
            return Ok();
        }

        [HttpPatch("buy/{quantity}")]
        public async Task BuyProduct([FromRoute]int quantity,int productId)
        {
            var product = await _productRepository.GetAsync(obj => obj.Id == productId);
            await _productService.BuyProduct(quantity, product);
        }

        [HttpPut("{productId}")]
        public IActionResult UpdateProducts([FromRoute] int productId,[FromBody] UpdateProductDto updateProductDto)
        {
            // if (!ModelState.IsValid)
            // {
            //     return BadRequest(ModelState);
            // }
            //
            // try
            // {
            //     await _productService.UpdateProduct(id, updateProductDto);
            //     return Ok();
            // }
            // catch (ArgumentException ex)
            // {
            //     return NotFound(ex.Message);
            // }
            // catch (Exception ex)
            // {
            //     return StatusCode(500, "An error occurred while updating the product.");
            // }
            _productService.UpdateProduct(updateProductDto);
            return Ok();
        }

        [HttpPatch("add-quantity/{quantity}/{productId}")]
        public async Task QuantityAdding([FromRoute]int quantity,[FromRoute] int productId)
        {
            var product = await _productRepository.GetAsync(obj => obj.Id == productId);
            await _productService.AddQuantity(quantity, product);
        }




    }
}
