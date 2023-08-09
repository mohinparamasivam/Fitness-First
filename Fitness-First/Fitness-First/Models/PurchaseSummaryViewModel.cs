using System;
using System.Collections.Generic;
using Fitness_First.Models; // You may need to adjust the namespace based on your project structure

namespace Fitness_First.Models
{
    public class PurchaseSummaryViewModel
    {
        public List<ProductPurchase> ProductPurchases { get; set; }
        public List<PackageEnrollment> PackagePurchases { get; set; }
        public double ProductSum { get; set; }
        public double PackageSum { get; set; }
        public double TotalAmount { get; set; }
    }
}
