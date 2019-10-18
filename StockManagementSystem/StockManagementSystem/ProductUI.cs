using StockManagementSystem.BLL;
using StockManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class ProductUI : Form
       
    {
        CategoryManager _categoryManager = new CategoryManager();
        public ProductUI()
        {
            InitializeComponent();
        }
        
        private void SaveButton(object sender, EventArgs e)
        {
            StockManager _stockManager = new StockManager();
            Product _product = new Product();

            _product.Code = codeTextBox.Text;
            _product.Name = nameTextBox.Text;
            _product.ReorderLevel = Convert.ToInt32(reOrderTextBox.Text);
            _product.ProductDescription = descriptionTextBox.Text;
            _product.CateogoryID = Convert.ToInt32(categoryComboBox.SelectedValue);

            //showDataGridView.DataSource = _stockManager.Save(_product);

            showDataGridView.DataSource = _stockManager.Save(_product);
            nameTextBox.Clear();
            codeTextBox.Clear();
            reOrderTextBox.Clear();

        }

        private void ProductUI_Load(object sender, EventArgs e)
        {
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.DataSource = _categoryManager.GetAllCategory();
        }

        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.showDataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex + 1);


        }

        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
