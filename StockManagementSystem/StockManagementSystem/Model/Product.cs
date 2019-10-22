using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Model
{
    class Product
    {
        public int ID { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public int ReorderLevel { set; get; }
        public string ProductDescription { set; get; }
        public int CateogoryID { set; get; }
    }
}
