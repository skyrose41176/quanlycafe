using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.DTOs
{
    [Table("Bill")]
    public class SaveBillDto
    {
        [Key]
        public int Id { get; set; }
        public string UsernameStaff { get; set; }
        public float Total { get; set; }
        
        public DateTime DateTime { get; set; }
    }
}