using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");
        public List<Product> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["Stock"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                };
                products.Add(product);
            }

            reader.Close();
            _connection.Close();
            return products;
        }

        public void AddProduct(Product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Insert into Products values(@Name,@UnitPrice,@Stock)", _connection);

            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@Stock", product.StockAmount);

            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void UpdateProduct(Product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Update Products set Name=@name, UnitPrice=@unitPrice, Stock=@stock where Id=@id", _connection);

            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stock", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);

            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void DeleteProduct(int id)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Delete From Products where Id=@id", _connection);

            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
            _connection.Close();
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }

        //Old Version

        public DataTable GetAllDataTable()
        {

            if (_connection.State == ConnectionState.Closed)
                _connection.Open();

            SqlCommand command = new SqlCommand("Select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }
    }
}



