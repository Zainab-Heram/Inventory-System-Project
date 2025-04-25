using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_Project
{
    public class InventorySystem
    {
        // قايمة بالمنتجات اللي موجودة في النظام
        public List<Product> Products { get; private set; }

        // قايمة بالمستخدمين اللي مسجلين في النظام
        public List<User> Users { get; private set; }

        // Constructor – بيبدأ القوايم فاضية
        public InventorySystem()
        {
            Products = new List<Product>();
            Users = new List<User>();
        }

        // دالة لإضافة منتج جديد للمخزون
        public void AddProduct(Product product)
        {
            Products.Add(product);
            Console.WriteLine("Product added successfully.");
        }

        // دالة لحذف منتج من المخزون باستخدام ID
        public void RemoveProduct(int productId)
        {
            var product = Products.FirstOrDefault(p => p.ID == productId);
            if (product != null)
            {
                Products.Remove(product);
                Console.WriteLine("Product removed successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        // دالة للبحث عن منتج باستخدام الاسم أو جزء منه
        public List<Product> SearchProduct(string keyword)
        {
            return Products
                .Where(p => p.Name.ToLower().Contains(keyword.ToLower()))
                .ToList();
        }

        // دالة لتوليد تقرير بسيط عن كل المنتجات
        public void GenerateReport()
        {
            Console.WriteLine("------ Product Report ------");
            foreach (var product in Products)
            {
                product.DisplayDetails();
                Console.WriteLine("------------------------");
            }
        }

        // دالة لتحديث بيانات منتج الاسم، السعر، الكمية  
        public void UpdateProduct(int productId, string newName = null, decimal? newPrice = null, int? newQuantity = null)
        {
            var productToUpdate = Products.FirstOrDefault(p => p.ID == productId);

            if (productToUpdate != null)
            {
                if (newName != null)
                    productToUpdate.Name = newName;

                if (newPrice.HasValue)
                    productToUpdate.Price = newPrice.Value;

                if (newQuantity.HasValue)
                    productToUpdate.UpdateQuantity(newQuantity.Value);

                Console.WriteLine("Product updated successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }
}
