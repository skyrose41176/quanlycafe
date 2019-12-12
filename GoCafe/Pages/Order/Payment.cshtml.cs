using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Persistence;
using ApplicationCore.Entities;
using GoCafe.Interfaces;
using GoCafe.ViewModels;

namespace GoCafe.Pages.Order
{
    public class PaymentModel : PageModel
    {
        private readonly GoCafeContext _context;
        public readonly ICategoryIndexVmService _cate;

        public PaymentModel(GoCafeContext context,ICategoryIndexVmService cate)
        {
            _cate = cate;
            _context = context;
        }
        public CategoryIndexVm CategoryIndexVM { get; set; }
        
        public IList<Product> Products {get; set;}
        public List<ObjOrder> objOrders {get; set;}
        public int mm { get; set; }
        public void OnGet()
        {
            
            CategoryIndexVM = _cate.GetCategoryListVm("","",1);
            var n = from m in  _context.Products
                orderby m.Id descending
                select m.Id;
                mm = n.First();
            // int mm = n.First();
            objOrders = new List<ObjOrder>();
            int[] a = new int[100];
            int[] sl = new int[100];
            for(int i=1; i<=mm; i++)
            {
                string tmp = Convert.ToString(i);
                int temp = HttpContext.Session.GetInt32(tmp).GetValueOrDefault();
                if(temp != 0)
                {
                    a[i] = i;
                    sl[i] = temp;
                    objOrders.Add(new ObjOrder(tmp, temp));
                }
            }
            var ids = a;
            var _products = _context.Products.Where(x=>ids.Contains(x.Id));
            
            Products = _products.ToList();
        }

        public IActionResult OnPost()
        {
            if(!string.IsNullOrEmpty(Request.Form["item.Id"]))
            {
                string id = Request.Form["item.Id"];
                HttpContext.Session.Remove(id);
            }
            return RedirectToPage("/Order/Payment");
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