﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Model
{
    public class Product
    {
        public int ID { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string Category { set; get; }
        public int ReorderLevel { set; get; }
<<<<<<< HEAD
        public string Description { set; get; }
        public int Quantity { set; get; }
        public int CategoryID { set; get; }
        public int PrevUnitPrice { set; get; }
        public int PrevMRP { set; get; }
=======
        public string ProductDescription { set; get; }

>>>>>>> 624d5fbb2c8b91ce929a18a136572b0323b5c492

    }
}
