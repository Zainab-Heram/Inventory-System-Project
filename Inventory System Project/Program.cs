using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System_Project
{
    internal static class Program
    {
        /// <summary>  
        /// The main entry point for the application.  
        /// </summary>  
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            Application.Run(new DashboardForm());
            Application.Run(new AddProductForm());
            Application.Run(new UpdateProductForm());
            Application.Run(new InventoryViewForm());
            Application.Run(new GenerateReportForm());
            Application.Run(new StockMovementForm());
            Application.Run(new ProductDetailForm());
        }
    }
}
