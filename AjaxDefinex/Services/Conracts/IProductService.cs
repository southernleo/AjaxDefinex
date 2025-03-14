using AjaxDefinex.Models;

namespace AjaxDefinex.Services.Conracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAllProductsAsync();
        Task<IEnumerable<ProductViewModel>> SearchProductsAsync(string searchTerm, int? categoryId);
    }

}
