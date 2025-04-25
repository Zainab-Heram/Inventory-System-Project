using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_Project
{
    public class User
    {
           // خصائص المستخدم
           public string Username { get; set; }   // اسم المستخدم
           public string Password { get; set; }   // كلمة المرور
           public int ID { get; set; }            // رقم تعريفي فريد للمستخدم

           // مُنشئ الكلاس - يستخدم لتعيين القيم عند إنشاء كائن جديد من User
           public User(int id, string username, string password)
           {
               ID = id;
               Username = username;
               Password = password;
           }

           // التحقق من بيانات تسجيل الدخول
           public bool Login(string inputUsername, string inputPassword)
           {
               return Username == inputUsername && Password == inputPassword;
           }

           // تنفيذ عملية تسجيل الخروج
           public void Logout()
           {
               Console.WriteLine($"{Username} has logged out.");
           }

           // الوصول إلى لوحة التحكم بعد تسجيل الدخول
           public void AccessDashboard()
           {
               Console.WriteLine($"Welcome to the Dashboard, {Username}!");
           }

           // إنشاء تقرير جديد
           public void CreateReport()
           {
               Console.WriteLine("Generating report...");
               // هنا تقدر تضيف كود توليد التقرير
           }

           // دالة لإضافة منتج جديد
           public void AddProduct()
           {
               Console.WriteLine("AddProduct function called.");
               // هنا تقدر تضيف كود إضافة المنتج
           }

           // دالة لتحديث الكمية في المخزون
           public void UpdateStock()
           {
               Console.WriteLine("UpdateStock function called.");
               // هنا تقدر تضيف كود تحديث المخزون
           }
    }
}
