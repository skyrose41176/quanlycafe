using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoCafe.Pages.Accounts
{
    public class DetailsModel : PageModel
    {
        private readonly IAccountService _context;

        public DetailsModel(IAccountService context)
        {
            _context = context;
        }

        public AccountDto Account { get; set; }

        public IActionResult OnGet(string username)
        {
            if (username == null)
            {
                return NotFound();
            }

            Account =  _context.GetAccount(username ?? default(string));

            if (Account == null)
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
