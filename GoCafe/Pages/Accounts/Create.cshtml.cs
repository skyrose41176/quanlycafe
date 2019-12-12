using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoCafe.Pages.Accounts
{
    public class CreateModel : PageModel
    {
        private readonly IAccountService _context;

        public CreateModel(IAccountService context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SaveAccountDto Account { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (!AccountExists(Account.Username))
            {
                _context.CreateAccount(Account);
            }
            else
            {
                HttpContext.Session.SetString("Trung","Trung");
                return Page();
            }
            return RedirectToPage("./Index");
        }
        private bool AccountExists(string username)
        {
            return _context.GetAccount(username) != null;
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
