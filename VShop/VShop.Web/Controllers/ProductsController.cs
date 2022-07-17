using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using VShop.Web.Models;
using VShop.Web.Services.Contracts;

namespace VShop.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductsController(IProductService productService,
            ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductVM>>> Index()
        {
            var result = await _productService.GetAllProducts();
            if (result is null)
                return View("Error");
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            ViewBag.CategoryId = 
                new SelectList(await
                        _categoryService.GetAllCategories(), "CategoryId", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductVM productVm)
        {
            if (ModelState.IsValid)
            {
                var result = await _productService.CreateProduct(productVm);

                if (result != null)
                    return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.CategoryId = new 
                    SelectList(await _categoryService.GetAllCategories(), 
                        "CategoryId", "Name");
            }

            return View(productVm);
        }

        public IActionResult UpdateProduct()
        {
            throw new NotImplementedException();
        }
        
        public IActionResult DeleteProduct()
        {
            throw new NotImplementedException();
        }
        
        
    }
}