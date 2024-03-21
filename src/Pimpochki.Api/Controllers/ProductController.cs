using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pimpochki.Application.Dtos.ImageDtos;
using Pimpochki.Application.Dtos.ProductDtos;
using Pimpochki.Application.Persistence.EntityRepositories;
using Pimpochki.Application.Persistence.EntityServices;
using Pimpochki.Domain.Entities;

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
        public IActionResult GetProducts()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ProductDto> GetById(int id)
        {
            var product = await _productService.GetProduct(id);
            return product;
        }

        [HttpGet("{id}/images")]
        public IActionResult GetImages([FromRoute] int id)
        {
            var images = _productService.GetAllImages(id);
            return Ok();
        }

        [HttpPost]
        public async Task CreateProduct([FromBody] CreateProductDto productDto)
        {
            await _productService.CreateProduct(productDto);
        }

        [HttpDelete("{id}")]
        public  IActionResult DeleteProduct([FromRoute] int id)
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
        public async Task BuyProduct([FromRoute]int quantity,int id)
        {
            var product = await _productRepository.GetAsync(obj => obj.Id == id);
            await _productService.BuyProduct(quantity, product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProducts([FromRoute] int id,[FromBody] UpdateProductDto updateProductDto)
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

        [HttpPatch("add-quantity/{quantity}/{id}")]
        public async Task QuantityAdding([FromRoute]int quantity,[FromRoute] int id)
        {
            var product = await _productRepository.GetAsync(obj => obj.Id == id);
            await _productService.AddQuantity(quantity, product);
        }




    }
}
