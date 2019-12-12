using System;
using System.Collections.Generic;
using System.Linq;
using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoCafe.Pages.Order
{
    public class HoadonModel : PageModel
    {
        private GoCafeContext _context;

        public HoadonModel(GoCafeContext context)
        {
            _context = context;
        }

        public IList<Product> Products {get; set;}
        public List<ObjOrder> objOrders {get; set;}
        int[] a = new int[100];
        int[] sl = new int[100];
        DateTime dtnow = DateTime.Today;
        public void OnGet()
        {
             var n = from m in  _context.Products
                orderby m.Id descending
                select m.Id;
            int mm = n.First();
            objOrders = new List<ObjOrder>();
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
            OnGet();
            //Lấy Username của nhân viên từ Session
            string TenNV = HttpContext.Session.GetString("Username");
            //Tính tổng giá của tất cả sản phẩm đã Order
            float priceTotal = 0;

            foreach (var item in Products)
            {
                foreach(var i in objOrders)
                {
                    int id = Convert.ToInt32(i.id);
                    if(item.Id==id)
                    {
                        priceTotal += item.Price*i.SL;
                    }
                }
            }

            // lấy id lớn nhất
            var _idBill = _context.Bills.OrderByDescending(b => b.Id).FirstOrDefault();
            int _IDBill = 0;
            if(_idBill == null)
            {
                _context.Bills.AddRange(
                    new Bill
                    {       
                        Id = 1,
                        UsernameStaff= TenNV,
                        Total = priceTotal,
                        DateTime = dtnow
                    }
                );
            }
            else{
                _IDBill = _idBill.Id + 1;
                _context.Bills.AddRange(
                new Bill
                    {
                        Id = _IDBill,
                        UsernameStaff= TenNV,
                        Total = priceTotal,
                        DateTime = dtnow
                    }
                );
            }

            int dem=1;
            foreach (var item in Products)
            {
                foreach (var i in objOrders)
                {
                    float price = 0;
                    int id = Convert.ToInt32(i.id);
                    if(item.Id==id)
                    {
                        //Lấy id infobill lơn nhất
                        var _idInfoBill = _context.InfoBills.OrderByDescending(b => b.Id).FirstOrDefault();
                        //tính giá của sản phẩm a với số lượng i
                        price += item.Price*i.SL;

                        if(_idInfoBill == null)
                        {
                            _context.InfoBills.AddRange(
                                new InfoBill
                                {
                                    Id = dem,
                                    IdProduct = item.Id,
                                    IdBill = 1,
                                    SL = i.SL,
                                    Price = price
                                }
                            );
                        }
                        else{
                            int  _IdInfoBill = _idInfoBill.Id + dem;
                            _context.InfoBills.AddRange(
                                new InfoBill
                                {
                                    Id = _IdInfoBill,
                                    IdProduct = item.Id,
                                    IdBill = _IDBill,
                                    SL = i.SL,
                                    Price = price
                                }
                            );
                        }
                        dem++;
                    }
                }
            }
            _context.SaveChanges();
            foreach (var item in objOrders)
            {
                HttpContext.Session.Remove(item.id);
            }
            
            return RedirectToPage("/Order/Index");
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