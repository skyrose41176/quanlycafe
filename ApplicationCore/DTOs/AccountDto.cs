using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;

namespace ApplicationCore.DTOs
{    public class AccountDto
    {
        [Key] 
        [Display(Name="Tên tài khoản")]
        public string Username { get; set; }

        [Required]
        [StringLength(100, MinimumLength=3)]
        [Display(Name="Họ Tên")]
        public string Fullname { get; set; }

        [Required]
        [Display(Name="Số điện thoại")]
        [StringLength(20, MinimumLength=10)]
        public string Phone { get; set; }

        [DataType(DataType.Date)]
        [Display(Name="Ngày sinh")]
        public DateTime Dateofbirth { get; set; }

        [Required]
        [StringLength(1000, MinimumLength=8)]
        [Display(Name="Mật khẩu")]
        public string Password { get; set; }

        [Required]
        [Display(Name="Quyền")]
        public string UserRole { get; set; }

        [Required]
        [Display(Name="Trạng thái")]
        public string Status { get; set; }
    }
}