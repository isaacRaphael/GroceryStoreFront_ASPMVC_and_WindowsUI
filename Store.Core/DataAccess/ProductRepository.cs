using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Store.Core
{
    public class ProductRepository : IProductRepository
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        private string _conStrn = @"Data Source = .\SQLEXPRESS;Initial Catalog = dbgrocery_store_products; Integrated Security = True";
        public  List<Product> GetProducts()
        {
            var DefaultProducts = new List<Product>();
            var sql = "select * from tbproducts;";

            using (connection = new SqlConnection(_conStrn))
            {
                command = new SqlCommand(sql, connection);
                connection.Open();
                reader =  command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DefaultProducts.Add(new Product(reader.GetString(1),reader.GetString(0), reader.GetInt32(2),reader.GetInt32(3)));
                    }
                }

            }
            return DefaultProducts;
        }

        public bool AddToProducts(string id, string prodName, decimal prodPrice , int qty)
        {
            bool result;
            using (connection = new SqlConnection(_conStrn))
            {
                

                var sql = $"insert into tbproducts (id , product_name , price, quantity) values ('{id}' , '{prodName}', {prodPrice}, {qty});";
                command = new SqlCommand(sql, connection);
                connection.Open();

                var response= command.ExecuteNonQuery();
                result = response == 1;

            }

            return result;

        }
        public bool RemoveFromProducts(string id)
        {
            bool result;
            using (connection = new SqlConnection(_conStrn))
            {
                var sql = $"delete from tbproducts where id = '{id}';";
                command = new SqlCommand(sql, connection);
                connection.Open();

                var response = command.ExecuteNonQuery();
                result = response == 1 ? true : false;
                
            }
            return result;
        }

        public bool UpdateDbOnCheckOut(string id, int qty)
        {
            bool result;
            using (connection = new SqlConnection(_conStrn))
            {
                var sql = $"update tbproducts set quantity = {qty} where id = '{id}';";
                command = new SqlCommand(sql, connection);
                connection.Open();

                var response = command.ExecuteNonQuery();
                result = response == 1 ? true : false;
            }
            return result;
        }
    }
}
