using System.Threading.Tasks;
using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GoCafe.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly IProductService _context;

        public DetailsModel(IProductService context)
        {
            _context = context;
        }

        public ProductDto Product { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product =  _context.GetProduct(id ?? default(int));

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
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
