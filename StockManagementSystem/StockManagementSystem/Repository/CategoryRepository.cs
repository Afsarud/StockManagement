using StockManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Repository
{
    class CategoryRepository
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public List<Category> GetAllCategory()
        {
            List<Category> categories = new List<Category>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string queryString = @"SELECT * FROM Categories";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Category category1 = new Category
            {
                ID= 1,
                Name = "--Select--"
            };
            categories.Add(category1);
            while (sqlDataReader.Read())
            {
                Category category = new Category();
                category.ID = Convert.ToInt32(sqlDataReader["ID"]);
                category.Code = sqlDataReader["Code"].ToString();
                category.Name = sqlDataReader["Name"].ToString();
                categories.Add(category);
            }
            return categories;
        }

    }
       
}
