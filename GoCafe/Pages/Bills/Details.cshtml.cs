using GoCafe.Interfaces;
using GoCafe.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoCafe.Pages.Bills
{
    public class BillModel : PageModel
    {
        private readonly IInfoBillIndexVmService _infobill;
        private readonly IProductIndexVmService _pro;
        public BillModel(IInfoBillIndexVmService infobill,IProductIndexVmService pro)
        {
            _pro=pro;
            _infobill = infobill;
        }
        public InfoBillIndexVm InfoBillIndexVM { get; set; }
        public ProductIndexVm ProductIndexVM { get; set; }
        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            InfoBillIndexVM = _infobill.GetInfoBillListVm("",id?? default(int), 1);
            ProductIndexVM = _pro.GetProductListVm("",0, 1);
            if (InfoBillIndexVM == null)
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
