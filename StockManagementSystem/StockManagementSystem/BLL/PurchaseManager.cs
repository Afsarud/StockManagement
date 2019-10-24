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
    class PurchaseManager
    {
        public List<Category> GetAllCategoryFromComboBox()
        {
            CategoryRepository _categoryRepository = new CategoryRepository();
            return _categoryRepository.GetAllCategoryFromComboBox();
        }

        public DataTable GetSupplierComboBox()
        {

            SupplierRepository _supplierRepository = new SupplierRepository();
            return _supplierRepository.Display();
        }

        public List<Product> GetProductFromComboBox()
        {

            CategoryRepository _categoryRepository = new CategoryRepository();

            return _categoryRepository.GetProductFromComboBox();

        }

        public bool ViewQuantity(string productCombo,int quantity,int prevMRP,int prevUnitPrice)
        {
            return true;
        }



    }
}
