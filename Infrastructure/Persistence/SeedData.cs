using System;
using System.Collections.Generic;
using System.Linq;
using ApplicationCore.Entities;
namespace Infrastructure.Persistence
{
   public class SeedData
    {
        public static void Initialize(GoCafeContext context)
        {
            context.Database.EnsureCreated();

            if (context.Accounts.Any()) return;

            context.Accounts.AddRange(
                new Account
                {
                    Username = "HarrySally",
                    Fullname = "abvdasdasd",
                    Phone = "0123456789",
                    Dateofbirth = DateTime.Parse("1999-10-02"),
                    Password = "12345678",
                    UserRole = "Nhân viên",
                    Status = "Hoạt động"
                },

                new Account
                {
                    Username = "Ghostbusters",
                    Fullname = "Ghost busters",
                    Phone = "0123456789",
                    Dateofbirth = DateTime.Parse("1999-10-02"),
                    Password = "12345678",
                    UserRole = "Quản trị viên",
                    Status = "Hoạt động"
                },
                new Account
                {
                    Username = "admin",
                    Fullname = "Trương Phạm Nhật Tiến",
                    Phone = "0123456789",
                    Dateofbirth = DateTime.Parse("1999-10-02"),
                    Password = "12345678",
                    UserRole = "Nhân viên",
                    Status = "Khoá"
                }
            );
            if (context.Products.Any()) return;
            var category = new List<Category>(){
                new Category{
                    CategoryId=1,
                    CategoryName="cafe"
                },
                new Category{
                    CategoryId=2,
                    CategoryName="Sua"
                }
            };
            context.Products.AddRange(
                new Product
                {
                    Id=1,
                    ProductName="Espreso",
                    Price=50000,
                    Category=category[0]

                },
                new Product
                {
                    Id=2,
                    ProductName="Trà sữa trân châu",
                    Price=50000,
                    Category=category[1]
                }
            );
            
            context.SaveChanges();
        }
    }
}