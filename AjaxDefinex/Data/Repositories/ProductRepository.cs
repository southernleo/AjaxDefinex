using AjaxDefinex.Data.Repositories.Contracts;
using AjaxDefinex.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AjaxDefinex.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> SearchProductsAsync(string searchTerm, int? categoryId)
        {
            var query = _context.Products.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(p => p.Name.Contains(searchTerm));
            }

            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryId == categoryId);
            }

            return await query
                .Include(p => p.Category)
                .ToListAsync();
        }
    }

}
