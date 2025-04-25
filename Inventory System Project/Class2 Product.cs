using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_Project
{
    // تعريف الانواع المختلفة من المنتجات باستخدام Enum
    public enum ProductCategory
    {
        Food,
        Beverage, // مشروبات
        Electronics,
        Clothing,
        Medicine,
        Other
    }

    public class Product
    {
        // (encapsulation): خصائص خاصة يتم التحكم فيها من خلال خصائص عامة 
        public int ID { get; set; }
        public string Name { get; set; }
        public ProductCategory Category { get; set; }
        public int Quantity { get; private set; }    // الكمية لا يمكن تعديلها مباشرة من خارج الكلاس
        public decimal Price { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int LowStockThreshold { get; set; }    // اقل كمية قبل اعتباره منخفض المخزون

        // Constructor 
        public Product(int id, string name, ProductCategory category, int quantity, decimal price, DateTime expiryDate, int lowStockThreshold)
        {
            ID = id;
            Name = name;
            Category = category;
            Quantity = quantity;
            Price = price;
            ExpiryDate = expiryDate;
            LowStockThreshold = lowStockThreshold;
        }

        // دالة لتحديث الكمية في المخزون
        public void UpdateQuantity(int amount)
        {
            Quantity += amount;
        }

        // داله لفحص ما إذا كان المنتج منخفض المخزون
        public bool IsLowStock()
        {
            return Quantity <= LowStockThreshold;
        }

        // داله لعرض معلومات اساسيه عن المنتج (Base method for polymorphism)
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Product ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Category: {Category}");
        }

        // داله لعرض التفاصيل الكامله عن المنتج (Extended details)
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Product ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Expiry Date: {ExpiryDate.ToShortDateString()}");
            Console.WriteLine($"Low Stock Threshold: {LowStockThreshold}");
        }

        // ToString override تستخدم لعرض معلومات المنتج كنص عند الطباعه
        public override string ToString()
        {
            return $"[Product: {Name} | ID: {ID} | Price: {Price:C} | Quantity: {Quantity}]";
        }
    }
}
