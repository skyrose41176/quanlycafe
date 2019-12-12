using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    [Table("Category")]
    public class Category : IAggregateRoot
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Product { get; set; }
    }
}