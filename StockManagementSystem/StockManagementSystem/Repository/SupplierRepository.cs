using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using StockManagementSystem.Model;

namespace StockManagementSystem.Repository
{
    class SupplierRepository
    {
        Supplier supplier = new Supplier();

        public bool Save(Supplier supplier)
        {
            bool isAdded = false;
            try
            {
                //Connection
                // Data Source = DESKTOP - SSEF4DE; Initial Catalog = SMS; Integrated Security = True
                string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"INSERT INTO Suppliers Values ('" + supplier.Code + "', '" + supplier.Name + "', '" + supplier.Address + "','" + supplier.Email + "', " + supplier.Contact+ "," + supplier.ContactPerson + ")";
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
                //MessageBox.Show(exeption.Message);
            }

            return isAdded;
        
        }

        public bool IsCodeExists(string code)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 

                string commandString = @"SELECT * FROM Suppliers WHERE Code='" + code + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }
                //Close
                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                //MessageBox.Show(exeption.Message);
            }

            return exists;
        }

        public bool IsContactExists(string contact)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 

                string commandString = @"SELECT * FROM Suppliers WHERE Contact='" + contact + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }
                //Close
                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                //MessageBox.Show(exeption.Message);
            }

            return exists;
        }


        public bool IsEmailExists(string email)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 

                string commandString = @"SELECT * FROM Suppliers WHERE Email='" + email + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }
                //Close
                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                //MessageBox.Show(exeption.Message);
            }

            return exists;
        }

        public DataTable Display()
        {

            DataTable dataTable = new DataTable();
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Suppliers";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                sqlDataAdapter.Fill(dataTable);
                //if (dataTable.Rows.Count > 0)
                //{
                //    showDataGridView.DataSource = dataTable;
                //}
                //else
                //{
                //    MessageBox.Show("No Data Found");
                //}

                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }
            return dataTable;




        }




    }
}
