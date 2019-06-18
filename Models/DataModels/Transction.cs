using System;
using System.ComponentModel.DataAnnotations;

namespace bank.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID {get;set;}
        [Required]

        public decimal Amount {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public int UserID {get;set;}

        public User Owner {get;set;}

    }
    
}