using System;
using System.Linq;
using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoCafe.Pages
{
    public class IndexModel : PageModel
    {
        public string Msg { get; set; }
        [BindProperty]
        public Account account { get; set; }
        private GoCafeContext db;
        public IndexModel(GoCafeContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            account = new Account();
        }
        public Account acc {get; set;}
        public IActionResult OnPost()
        {
            var dk = Lgin(account.Username, account.Password);
            if(dk==1)
            {
                string a= Convert.ToString(acc.Dateofbirth);
                HttpContext.Session.SetString("Username", acc.Username);
                HttpContext.Session.SetString("UserRole", acc.UserRole);
                HttpContext.Session.SetString("Fullname", acc.Fullname);
                HttpContext.Session.SetString("Phone", acc.Phone);
                HttpContext.Session.SetString("Status", acc.Status);
                HttpContext.Session.SetString("Dateofbirth", a);
                return RedirectToPage("Home/Index");
            }
            else if(dk==2)
            {
                Msg="*Không hợp lệ";
            }
            else
            {
                Msg="*tài khoản bị khoá";
            }
            return Page();
        }
        private int Lgin(string username, string password)
        {
            acc = db.Accounts.SingleOrDefault(a=>a.Username.Equals(username));
            if(acc != null)
            {
                if(acc.Password==password)
                    if(acc.Status == "Hoạt động")
                        return 1;
                    else return 0;
            }
            return 2;
        }
        
    }
}
