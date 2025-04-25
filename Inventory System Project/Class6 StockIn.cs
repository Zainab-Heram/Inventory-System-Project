using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_Project
{
    //Class7 لحركة الإضافة للمخزون (Stock In)
    public class StockIn : StockMovement
    {
        // بنمرر اسم المنتج، الكمية، التاريخ، ونحدد نوع الحركة إنها استلام
        public StockIn(string productId, int quantity, DateTime date)
               : base(productId, quantity, date, MovementType.Receipt) { }

        // تنفيذ عملية الإضافة (بنطبع بس في الكونسول كمثال)
        public override void ApplyMovement()
        {
            Console.WriteLine($"Stock In: Added {Quantity} of {ProductID} to inventory.");
        }
    }
}
