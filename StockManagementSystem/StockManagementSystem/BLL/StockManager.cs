using StockManagementSystem.Model;
using StockManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
    class StockManager
    {
        StockRepository _stockRepository = new StockRepository();
        Product _product = new Product();

        public bool GetSave(Product product)
        {
            return _stockRepository.GetSave(product);
        }
        public bool IsNameExists(Product product)
        {
            return _stockRepository.IsNameExists(product);
        }
        public bool Update(Product product)
        {
            return _stockRepository.Update(product);
        }

        public DataTable Display()
        {
           return _stockRepository.Display();
        }
    }
}
