using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GoCafe.Pages.Accounts
{
    public class DeleteModel : PageModel
    {
        private readonly IAccountService _context;

        public DeleteModel(IAccountService context)
        {
            _context = context;
        }

        [BindProperty]
        public AccountDto Account { get; set; }

        public IActionResult OnGet(string username)
        {
            if (username == null)
            {
                return NotFound();
            }

            Account = _context.GetAccount(username?? default(string));

            if (Account == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(string username)
        {
            if (username == null)
            {
                return NotFound();
            }
            _context.DeleteAccount(username?? default(string));
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
