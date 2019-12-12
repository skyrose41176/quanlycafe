using GoCafe.Interfaces;
using GoCafe.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoCafe.Pages.Products
{
    public class IndexProduct : PageModel
    {
        private readonly IProductIndexVmService _productService;

        private readonly ICategoryIndexVmService _cateService;
        public IndexProduct(IProductIndexVmService productService,ICategoryIndexVmService cateService)
        {
            _cateService=cateService;
            _productService = productService;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ProductGenre { get; set; }

        public ProductIndexVm ProductIndexVM { get; set; }
        public CategoryIndexVm CategoryIndexVM{get;set;}
        public void OnGet(string searchString, int pageIndex = 1)
        {
            ProductIndexVM = _productService.GetProductListVm1(SearchString, ProductGenre, pageIndex);
            CategoryIndexVM =_cateService.GetCategoryListVm("","",1);
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
