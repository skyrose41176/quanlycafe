using System.Threading.Tasks;
using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using GoCafe.Interfaces;
using GoCafe.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoCafe.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly IProductService _context;
        private readonly ICategoryIndexVmService _categoryService;

        public CreateModel(IProductService context,ICategoryIndexVmService categoryService)
        {
            _categoryService= categoryService;
            _context = context;
        }
        public CategoryIndexVm CategoryIndexVM { get; set; }
        public IActionResult OnGet()
        {
            CategoryIndexVM = _categoryService.GetCategoryListVm("","",1);
            return Page();
        }

        [BindProperty]
        public SaveProductDto Product { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (!ProductExists(Product.Id))
            {
                _context.CreateProduct(Product);
            }
            else
            {
                HttpContext.Session.SetString("Trung", "Trung");
                return Page();
            }
            return RedirectToPage("./Index");
        }
        private bool ProductExists(int id)
        {
            return _context.GetProduct(id) != null;
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
