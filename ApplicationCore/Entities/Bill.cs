using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    [Table("Bill")]
    public class Bill : IAggregateRoot
    {
        [Key]
        public int Id { get; set; }
        public string UsernameStaff { get; set; }
        public float Total { get; set; }
        public DateTime DateTime { get; set; }
        public List<InfoBill> InfoBill{get;set;}
    }
}