using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_Project
{
    // كلاس منتج سائل – بيرث من Product
    public class LiquidProduct : Product
    {
        public string VolumeUnit { get; set; } // وحدة الحجم زي لتر أو ملي

        public LiquidProduct(int id, string name, ProductCategory category, int quantity, decimal price, DateTime expiryDate, int lowStockThreshold, string volumeUnit)
            : base(id, name, category, quantity, price, expiryDate, lowStockThreshold)
        {
            VolumeUnit = volumeUnit;
        }

        // نعرض كل حاجة و نضيف وحدة الحجم
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"VolumeUnit: {VolumeUnit}");
        }
    }
}
