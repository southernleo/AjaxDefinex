using AjaxDefinex.Data.Repositories.Contracts;
using AjaxDefinex.Models.Entities;
using AjaxDefinex.Services.Conracts;

namespace AjaxDefinex.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _categoryRepository.GetAllAsync();
        }
    }
}
