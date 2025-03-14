using AjaxDefinex.Models.Entities;

namespace AjaxDefinex.Services.Conracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
    }
}
