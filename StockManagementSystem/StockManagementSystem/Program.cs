﻿using System;
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


           Application.Run(new CategoryUI());
            Application.Run(new CustomerUI());

            //Application.Run(new CategoryUI());
            Application.Run(new SupplierUI());
            Application.Run(new PurchaseUI());
            Application.Run(new ProductUI());
            

            Application.Run(new CategoryUI());
            Application.Run(new CustomerUI());
            Application.Run(new ProductUI());
            Application.Run(new SupplierUI());
            Application.Run(new PurchaseUI());


            

        }
    }
}
