using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            //Application.Run(new CategoryUI());
            Application.Run(new SupplierUI());
            //Application.Run(new PurchaseUI());
=======

           // Application.Run(new CategoryUI());
            //Application.Run(new CustomerUI());

           // Application.Run(new CategoryUI());
            //Application.Run(new SupplierUI());
         //   Application.Run(new PurchaseUI());


            Application.Run(new ProductUI());

>>>>>>> 624d5fbb2c8b91ce929a18a136572b0323b5c492

        }
    }
}
