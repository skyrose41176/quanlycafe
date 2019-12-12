using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoCafe.Pages.Home
{
    public class IndexHome : PageModel
    {

        private readonly IAccountService _context;

        public IndexHome(IAccountService context)
        {
            _context = context;
        }

        public AccountDto Account { get; set; }
        public IActionResult OnGet()
        {      
            var a =@HttpContext.Session.GetString("Username");     
            Account =  _context.GetAccount(a ?? default(string));
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