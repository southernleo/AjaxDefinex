using AjaxDefinex.Data.Repositories.Contracts;
using AjaxDefinex.Models.Entities;

namespace AjaxDefinex.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
