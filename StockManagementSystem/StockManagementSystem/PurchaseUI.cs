using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.BLL;
using StockManagementSystem.Model;

namespace StockManagementSystem
{
    public partial class PurchaseUI : Form
    {
        public PurchaseUI()
        {
            InitializeComponent();
        }

        PurchaseManager _purchaseManager = new PurchaseManager();
        Product product = new Product();


        

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseUI_Load(object sender, EventArgs e)
        {
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.DataSource = _purchaseManager.GetAllCategoryFromComboBox();
            supplierComboBox.DataSource = _purchaseManager.GetSupplierComboBox();
            productComboBox.DataSource = _purchaseManager.GetProductFromComboBox();
           

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (categoryComboBox.SelectedValue.ToString() != null)
            //{
            //    int ID = Convert.ToInt32(categoryComboBox.SelectedValue.ToString());
            //    _purchaseManager.GetProductFromComboBox(ID);
            //    productComboBox.Enabled = true;
               

            //}



        }

        

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (productComboBox.SelectedIndex > -1)
            //{
            //    productComboBox.DataSource = _purchaseManager.GetProductFromComboBox();

            //    product.ID = Convert.ToInt32(productComboBox.SelectedValue);

            //    categoryComboBox.Enabled = true;
                
            //    categoryComboBox.DataSource = _purchaseManager.GetAllCategoryFromComboBox();

                


            //    reorderLevelTextBox.Text = _stockManager.GetReorderLevel(stockIn).ToString();

            //    int availableQuantity;
            //    availableQuantity = _stockManager.GetAvailableQuantity(stockIn, stockOut);
            //    availableQuantityTextBox.Text = availableQuantity.ToString();


            //}




        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
