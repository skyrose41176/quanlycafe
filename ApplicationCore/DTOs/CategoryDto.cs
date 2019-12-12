using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.DTOs
{
    [Table("Category")]
    public class CategoryDto
    {
        [Key]
        [Display(Name="Mã loại")]
        public int CategoryId { get; set; }
        [Display(Name="Tên loại")]
        public string CategoryName { get; set; }
        public List<ProductDto> ProductDto{get;set;}
    }
}    