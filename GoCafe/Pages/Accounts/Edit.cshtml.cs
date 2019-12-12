using System.Linq;
using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GoCafe.Pages.Accounts
{
    public class EditModel : PageModel
    {
        private readonly IAccountService _context;
        private readonly IMapper _mapper;
        public EditModel(IAccountService context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [BindProperty]
        public SaveAccountDto Account { get; set; }
        // public SelectList Quyen { get; set; }
        // public SelectList Active { get; set; }
        public IActionResult OnGet(string username)
        {
            if (username == null)
            {
                return NotFound();
            }

            var account = _context.GetAccount(username ?? default(string));

            if (account == null)
            {
                return NotFound();
            }
            // var _quyen = from m in _context.Accounts
            //                 select m.UserRole;
            // Quyen = new SelectList(_quyen.Distinct().ToList());

            // var _active = from m in _context.Accounts
            //                 select m.Status;
            // Active = new SelectList(_active.Distinct().ToList());
            Account = _mapper.Map<AccountDto,SaveAccountDto>(account);

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                return Page();
            }
            try
            {
                _context.UpdateAccount(Account);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountExists(Account.Username))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
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
