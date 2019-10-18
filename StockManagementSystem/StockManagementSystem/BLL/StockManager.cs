﻿using StockManagementSystem.Model;
using StockManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
    class StockManager
    {
        StockRepository _stockRepository = new StockRepository();
        Product _product = new Product();

        public bool Save(Product product)
        {
            return _stockRepository.Save(product);
        }
    }
}
