using System;
using System.Collections.Generic;
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
        Supplier _supplier = new Supplier();

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


        public DataTable Display()
        {
            return _supplierRepository.Display();
        }

    }
}
