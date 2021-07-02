using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Transaction
    {
        [Key]
        [Required]
        [Display(Name = "Transaction ID")]
        public int TransactionID { get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        [ForeignKey(nameof(Product))]
        public virtual Product Product { get; set; }
        public int ProductID { get; set; }
        public int Quanitity { get; set; }
        public decimal TotalCost
        {
            get
            {
                return Product.UnitPrice * Quanitity;
            }
        }


    }
}