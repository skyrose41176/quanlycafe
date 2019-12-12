using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System;
using Infrastructure.Persistence;
using ApplicationCore.Entities;
using GoCafe.Interfaces;
using GoCafe.ViewModels;
using ApplicationCore.Interfaces;

namespace GoCafe.Pages.Order
{
    public class IndexOrder : PageModel
    {
        private readonly IProductIndexVmService _productService;
        public ICategoryIndexVmService _pro;
        public IndexOrder(IProductIndexVmService productService,ICategoryIndexVmService pro)
        {
            _pro = pro;
            _productService = productService;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string categoryGenre { get; set; }

        public ProductIndexVm ProductIndexVm { get; set; }
        public CategoryIndexVm CategoryIndexVm{get;set;}
        public void OnGet(string searchString, int pageIndex = 1)
        {
            ProductIndexVm = _productService.GetProductListVm1(SearchString,categoryGenre, pageIndex);
            CategoryIndexVm = _pro.GetCategoryListVm("","", pageIndex);
        }
        public string id { get; set; }

        public IActionResult OnPost()
        {
            int SL;
            if (!string.IsNullOrEmpty(Request.Form["SL"]))
            {
                id = Request.Form["item.Id"];
                SL = Convert.ToInt32(Request.Form["SL"]);
                if (SL != 0)
                    HttpContext.Session.SetInt32(id, SL);
                HttpContext.Session.SetString("KT","KT");    
            }
            else{
                HttpContext.Session.SetString("KT","Dung");    
            }
            return RedirectToPage("Index");
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
