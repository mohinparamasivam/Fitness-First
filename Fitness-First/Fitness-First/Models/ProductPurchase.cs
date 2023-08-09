using System.ComponentModel.DataAnnotations;
using System;

namespace Fitness_First.Models
{
    public class ProductPurchase
    {

        [Key]
        public int PurchaseID { get; set; }

        public string ProductName { get; set; }

        public string ProductType { get; set; }

        public double ProductPrice { get; set; }

        public string PurchasedBy { get; set; }
    }
}
