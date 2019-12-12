using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.DTOs
{
    [Table("Bill")]
    public class BillDto
    {
        [Key]
        [Display(Name = "Mã hóa đơn")]
        public int Id { get; set; }
        [Display(Name = "Tên tài khoản")]
        public string UsernameStaff { get; set; }
        [Display(Name = "Tổng tiền")]
        public float Total { get; set; }
        [Display(Name = "Ngày lập")]
        public DateTime DateTime { get; set; }
    }
}