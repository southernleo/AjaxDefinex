using AjaxDefinex.Data.Repositories.Contracts;
using AjaxDefinex.Models;
using AjaxDefinex.Services.Conracts;

namespace AjaxDefinex.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<ProductViewModel>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return products.Select(p => new ProductViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                CategoryName = p.Category?.Name
            });
        }

        public async Task<IEnumerable<ProductViewModel>> SearchProductsAsync(string searchTerm, int? categoryId)
        {
            var products = await _productRepository.SearchProductsAsync(searchTerm, categoryId);
            return products.Select(p => new ProductViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                CategoryName = p.Category?.Name
            });
        }
    }

}
