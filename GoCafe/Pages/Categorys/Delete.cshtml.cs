using System.Threading.Tasks;
using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GoCafe.Pages.Categorys
{
    public class DeleteModel : PageModel
    {
        private readonly ICategoryService _context;

        public DeleteModel(ICategoryService context)
        {
            _context = context;
        }

        [BindProperty]
        public CategoryDto Category { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = _context.GetCategory(id ?? default(int));

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            _context.DeleteCategory(id ?? default(int));
            return RedirectToPage("./Index");
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
