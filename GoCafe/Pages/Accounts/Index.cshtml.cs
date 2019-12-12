using GoCafe.Interfaces;
using GoCafe.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoCafe.Pages.Accounts
{
    public class IndexAccount : PageModel
    {
        private readonly IAccountIndexVmService _accountService;

        public IndexAccount(IAccountIndexVmService accountService)
        {
            _accountService = accountService;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string AccountGenre { get; set; }
        public AccountIndexVm AccountIndexVM { get; set; }

        public void OnGet(string searchString, int pageIndex = 1)
        {
            AccountIndexVM = _accountService.GetAccountListVm(SearchString,AccountGenre, pageIndex);
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
