using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_Project
{
    //Class6 لحركة الصرف من المخزون (Stock Out)
    public class StockOut : StockMovement
    {
        // بنمرر اسم المنتج، الكمية، التاريخ، ونحدد نوع الحركة إنها صرف
        public StockOut(string productId, int quantity, DateTime date)
               : base(productId, quantity, date, MovementType.Issue) { }

        // تنفيذ عملية الصرف بنطبع بس في الكونسول كمثال
        public override void ApplyMovement()
        {
            Console.WriteLine($"Stock Out: Removed {Quantity} of {ProductID} from inventory.");
        }
    }
}
