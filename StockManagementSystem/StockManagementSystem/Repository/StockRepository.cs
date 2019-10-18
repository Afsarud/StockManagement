using StockManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.Repository
{
    class StockRepository
    {
        Product product = new Product();

        public bool Save(Product product)
        {
            bool isAdded = false;
            try
            {
                //Connection
               // Data Source = DESKTOP - SSEF4DE; Initial Catalog = SMS; Integrated Security = True
                string connectionString = @"Server=DESKTOP-SSEF4DE; Database=SMS; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"INSERT INTO Products Values ('" + product.Code + "', '" + product.Name + "', " + product.ReorderLevel + ",' " + product.ProductDescription + "', " + product.CateogoryID + ")";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Insert

                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isAdded = true;
                }
                
                sqlConnection.Close();


            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }

            return isAdded;
        }
    }
}
