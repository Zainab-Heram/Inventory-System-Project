using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_Project
{
    // كلاس منتج وزني – بيرث من Product
    public class WeightProduct : Product
    {
        public string WeightUnit { get; set; } // وحدة الوزن زي كجم أو جرام


        public WeightProduct(int id, string name, ProductCategory category, int quantity, decimal price, DateTime expiryDate, int lowStockThreshold, string weightUnit)
            : base(id, name, category, quantity, price, expiryDate, lowStockThreshold)
        {
            WeightUnit = weightUnit;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"WeightUnit: {WeightUnit}");
        }
    }
}
