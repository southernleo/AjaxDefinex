using AjaxDefinex.Models.Entities;

namespace AjaxDefinex.Models
{
    public class SearchViewModel
    {
        public string SearchTerm { get; set; }
        public int? CategoryId { get; set; }
        public List<Category> Categories { get; set; }
    }
}
