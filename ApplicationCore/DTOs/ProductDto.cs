using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.DTOs
{
    [Table("Product")]
    public class ProductDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength=3)]
        [Display(Name="Tên sản phẩm")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name="Giá")]
        public float Price { get; set; }
        [Display(Name="Mã Loại")]
        public int CategoryId{get;set;}
        public CategoryDto CategoryDto { get; set; }
    }
}