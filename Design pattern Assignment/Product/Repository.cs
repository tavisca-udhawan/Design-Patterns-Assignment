using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Repository : IRepository
    {
        public void InsertDataToDatabase(string id, string name, string desc, string product,int Fare,bool isBook)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=repositoryDB;User ID=sa;Password=test123!@#";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into " + product + "Products values(@id,@name,@description,@IsBook)", connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@description", desc);
            command.Parameters.AddWithValue("@IsBook", isBook);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void InsertDataToFile(string ProductName, string ProductId, string ProductDesc,int Fare,bool isBook)
        {
            File.AppendAllText("C:/Users/udhawan/Desktop/savedData.txt", "Name: " + ProductName + "," + "ID: " + ProductId + "," + "Description: " + ProductDesc+" IsBooked= "+ isBook+ Environment.NewLine);

        }
    }
}