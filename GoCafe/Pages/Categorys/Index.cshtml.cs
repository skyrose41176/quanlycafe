using GoCafe.Interfaces;
using GoCafe.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoCafe.Pages.Categorys
{
    public class IndexCategory : PageModel
    {
        private readonly ICategoryIndexVmService _CategoryService;

        public IndexCategory(ICategoryIndexVmService CategoryService)
        {
            _CategoryService = CategoryService;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CategoryGenre { get; set; }

        public CategoryIndexVm CategoryIndexVM { get; set; }

        public void OnGet(string searchString, int pageIndex = 1)
        {
            CategoryIndexVM = _CategoryService.GetCategoryListVm(SearchString, CategoryGenre, pageIndex);

        }
        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("Username");
            HttpContext.Session.Remove("UserRole");
            HttpContext.Session.Remove("Fullname");
            return RedirectToPage("/Index");
        }
    }
}
