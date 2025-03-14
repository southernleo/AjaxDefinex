using AjaxDefinex.Models;
using AjaxDefinex.Services.Conracts;
using Microsoft.AspNetCore.Mvc;

namespace AjaxDefinex.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();
            var viewModel = new SearchViewModel
            {
                Categories = categories.ToList()
            };
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> SearchProducts(string searchTerm, int? categoryId)
        {
            var products = await _productService.SearchProductsAsync(searchTerm, categoryId);
            return PartialView("_ProductListPartial", products);
        }
    }

}