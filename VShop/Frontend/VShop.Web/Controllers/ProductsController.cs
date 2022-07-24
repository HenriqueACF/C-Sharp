using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using VShop.Web.Models;
using VShop.Web.Roles;
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
        [Authorize]
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

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            ViewBag.CategoryId =
                new SelectList(await _categoryService.GetAllCategories(), "CategoryId", "Name");
            var result = await _productService.FindProductById(id);
            if (result is null)
                return View("Error");
            return View(result);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> UpdateProduct(ProductVM productVm)
        {
            if (ModelState.IsValid)
            {
                var result = await _productService.UpdateProduct(productVm);
                if (result is not null)
                    return RedirectToAction(nameof(Index));
            }

            return View(productVm);
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<ProductVM>> DeleteProduct(int id)
        {
            var result = await _productService.FindProductById(id);
            if (result is null)
                return View("Error");
            return View(result);
        }

        [HttpPost(), ActionName("DeleteProduct")]
        [Authorize(Roles = Role.Admin)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var result = await _productService.DeleteProductById(id);
            if(!result)
                return View("Error");
            return RedirectToAction("Index");
        }
    }
}