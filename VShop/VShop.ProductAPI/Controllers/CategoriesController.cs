using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VShop.ProductAPI.DTOs;
using VShop.ProductAPI.Services;

namespace VShop.ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> Get()
        {
            var categoriesDto = await  _categoryService.GetCategories();
            if (categoriesDto is null)
                return NotFound("Categories not found.");
            return Ok(categoriesDto);
        }

        [HttpGet("products")]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetCategoriesProducts()
        {
            var categoriesDto = await _categoryService.GetCategoriesProducts();
            if (categoriesDto is null)
                return NotFound("Categories not found.");
            return Ok(categoriesDto);
        }
        
        [HttpGet("{int:id}", Name = "GetCategory")]
        public async Task<ActionResult<CategoryDTO>> Get([FromRoute]int id)
        {
            var categoryDto = await _categoryService.GetCategoryById(id);
            if (categoryDto is null)
                return NotFound("Categories not found.");
            return Ok(categoryDto);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CategoryDTO categoryDto)
        {
            if (categoryDto is null)
                return BadRequest("Invalid Data");

            await _categoryService.AddCategory(categoryDto);

            return new CreatedAtRouteResult("GetCategory",
                new { id = categoryDto.CategoryId }, categoryDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromRoute] int id, [FromBody] CategoryDTO categoryDto)
        {
            if (id != categoryDto.CategoryId)
                return BadRequest();

            if (categoryDto is null)
                return BadRequest();

            await _categoryService.UpdateCategory(categoryDto);
            return Ok(categoryDto);
        }

        [HttpDelete("{id: int}")]
        public async Task<ActionResult<CategoryDTO>> Delete(int id)
        {
            var categoryDto = await _categoryService.GetCategoryById(id);

            if (categoryDto is null)
                return NotFound("Category not found");

            await _categoryService.RemoveCategory(id);
            return Ok(categoryDto);
        }
    }
}
