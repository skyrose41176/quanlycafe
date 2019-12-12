using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    [Table("Product")]
    public class Product : IAggregateRoot
    {
        [Key]
        public int Id { get; set; }
         [Display(Name="Tến sản phẩm")]
        public string ProductName { get; set; }
         [Display(Name="Giá")]
        public float Price { get; set; }
        public int CategoryId{get;set;}
        public Category Category{get;set;}
        //public InfoBill InfoBill{get;set;}
        
    }
}