using System.Threading.Tasks;
using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoCafe.Pages.Categorys
{
    public class CreateModel : PageModel
    {
        private readonly ICategoryService _context;

        public CreateModel(ICategoryService context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SaveCategoryDto Category { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //if(!CategoryExists(Category.CategoryName))
            //{
                _context.CreateCategory(Category);
            //}
            //else{
                //HttpContext.Session.SetString("Trung","Trung");
                //return Page();
            //}
            return RedirectToPage("./Index");
        }
        // private bool CategoryExists(string CategoryName)
        // {
        //     return _context.GetCategory(CategoryName) != null;
        // }
        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("Username");
            HttpContext.Session.Remove("UserRole");
            HttpContext.Session.Remove("Fullname");
            return RedirectToPage("/Index");
        }
    }
}
