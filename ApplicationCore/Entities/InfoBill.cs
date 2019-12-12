using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    [Table("InfoBill")]
    public class InfoBill : IAggregateRoot
    {
        [Key]
        public int Id { get; set; }
        public int IdProduct { get; set; }
        
        //public Product Product{get;set;}
        public int IdBill { get; set; }
        public Bill Bill{get;set;}
        public int SL { get; set; }
        public float Price { get; set; }
    }
}