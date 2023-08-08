using System.ComponentModel.DataAnnotations;
using System;

namespace Fitness_First.Models
{
    public class Products
    {

        [Key]
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string ProductType { get; set; }

        public double ProductPrice { get; set; }

        public string ProductPicturePath { get; set; }
    }
}
