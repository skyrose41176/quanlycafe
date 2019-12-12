using GoCafe.Interfaces;
using GoCafe.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoCafe.Pages.Bills
{
    public class IndexBill : PageModel
    {
        private readonly IBillIndexVmService _billService;

        public IndexBill(IBillIndexVmService BillService)
        {
            _billService = BillService;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public int BillGenre { get; set; }
        public BillIndexVm BillIndexVM { get; set; }

        public void OnGet(string searchString, int pageIndex = 1)
        {
            BillIndexVM = _billService.GetBillListVm(SearchString, BillGenre, pageIndex);
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
