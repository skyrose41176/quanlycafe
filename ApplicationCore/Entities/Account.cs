using System;
using System.ComponentModel.DataAnnotations;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
  public class Account : IAggregateRoot
    {
        [Key]
        public string Username { get; set; }
        public string Fullname { get; set; }
         public string Phone { get; set; }
        public DateTime Dateofbirth { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
        public string Status { get; set; }
    }
}