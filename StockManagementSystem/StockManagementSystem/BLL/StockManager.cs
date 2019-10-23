using StockManagementSystem.Model;
using StockManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using StockManagementSystem.Repository;
using System.Data;

namespace StockManagementSystem.BLL
{
    class StockManager
    {

        SupplierRepository _supplierRepository = new SupplierRepository();
        StockRepository _stockRepository = new StockRepository();
        Supplier _supplier = new Supplier();
        Product _product = new Product();

        public bool Save(Supplier supplier)
        {
            return _supplierRepository.Save(supplier);
        }

        public bool IsCodeExists(string code)
        {
            return _supplierRepository.IsCodeExists(code);
        }

        public bool IsContactExists(string contact)
        {
            return _supplierRepository.IsContactExists(contact);
        }

        public bool IsEmailExists(string email)
        {
            return _supplierRepository.IsEmailExists(email);
        }


        //public bool Update(string Name, double Price, int ItemId)
        //{
        //    return _itemRepository.Update(Name, Price, ItemId);
        //}


        //Afsar
      
        public bool GetSave(Product product)
        {
            return _stockRepository.GetSave(product);
        }
        public bool IsCodeExists(Product product)
        {
            return _stockRepository.IsCodeExists(product);
        }
        public bool IsNameExists(Product product)
        {
            return _stockRepository.IsNameExists(product);
        }

        public bool Update(Product product)
        {
            return _stockRepository.Update(product);
        }

        public DataTable GetProductDisplay()
        {
            return _stockRepository.GetProductDisplay();
        }

        public DataTable Display()
        {
            return _supplierRepository.Display();
        }


    }
}
