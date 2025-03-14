using AjaxDefinex.Models.Entities;

namespace AjaxDefinex.Data.Repositories.Contracts
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> SearchProductsAsync(string searchTerm, int? categoryId);
    }
}
