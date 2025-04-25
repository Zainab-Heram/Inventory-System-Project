using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_Project
{
    // Enum لتحديد نوع حركة المخزون: استلام أو صرف
    public enum MovementType
    {
        Receipt, // استلام
        Issue    // صرف
    }

    // كلاس مجرد (abstract) يعني مينفعش نعمل منه object مباشر
    public abstract class StockMovement
    {
        // معرفين البيانات (الحقول) اللي هنخزن فيها تفاصيل الحركة
        private string _productId; // كود المنتج
        private int _quantity;     // الكمية
        private DateTime _date;    // تاريخ الحركة
        private MovementType _movementType; // نوع الحركة (استلام أو صرف)

        // خاصية لكود المنتج
        public string ProductID
        {
            get { return _productId; }
            set { _productId = value; }
        }

        // خاصية للكمية
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        // خاصية للتاريخ
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        // خاصية لنوع الحركة
        public MovementType MovementType
        {
            get { return _movementType; }
            protected set { _movementType = value; } // protected يعني تتعدل من داخل الكلاس أو الكلاسات اللي وراها بس
        }

        // Constructor (البناء) بياخد البيانات الأساسية ويخزنها
        protected StockMovement(string productId, int quantity, DateTime date, MovementType movementType)
        {
            _productId = productId;
            _quantity = quantity;
            _date = date;
            _movementType = movementType;
        }

        // دالة مجردة، يعني الكلاسات اللي هتورث من الكلاس ده لازم تنفذها
        public abstract void ApplyMovement();
    }
}
