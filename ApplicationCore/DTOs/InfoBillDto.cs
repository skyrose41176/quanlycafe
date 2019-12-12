using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.DTOs
{
    [Table("InfoBill")]
    public class InfoBillDto
    {
        [Key]
        public int Id { get; set; }
        public int IdProduct { get; set; }

        public int IdBill { get; set; }
        public int SL { get; set; }
        public float Price { get; set; }
    }
}