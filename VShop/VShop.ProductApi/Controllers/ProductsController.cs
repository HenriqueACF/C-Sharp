using Microsoft.AspNetCore.Mvc;
using VShop.ProductApi.DTOs;
using VShop.ProductApi.Service.Product;

namespace VShop.ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> Get()
        {
            var productDto = await _productService.GetProducts();
            if(productDto is null)
                return NotFound("Product not found");
            return Ok(productDto);
        }
        
        [HttpGet("{id}", Name = "GetProduct")]
        public async Task<ActionResult<ProductDTO>> GetById(int id)
        {
            var productDto = await _productService.GetProductById(id);
            if(productDto is null)
                return NotFound("Product not found");
            return Ok(productDto);    //
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProductDTO productDto)
        {
            if(productDto is null)
                return BadRequest("Data Invalid");

            await _productService.AddProduct(productDto);

            return new CreatedAtRouteResult("GetProduct", new
            {
                id = productDto.Id
            }, productDto);
        }
        
        [HttpPut]
        public async Task<ActionResult> Put(int id,[FromBody] ProductDTO productDto)
        {
            if(id != productDto.Id)
                return BadRequest("Data Invalid");

            if(productDto is null)
                return BadRequest("Data Invalid");
            
            await _productService.UpdateProduct(productDto);
            return Ok(productDto);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductDTO>> Delete(int id)
        {
            var productDto = await _productService.GetProductById(id);
            if (productDto is null)
                return NotFound("Product not found");

            await _productService.DeleteProduct(id);
            return Ok(productDto);
        }
    }
}
