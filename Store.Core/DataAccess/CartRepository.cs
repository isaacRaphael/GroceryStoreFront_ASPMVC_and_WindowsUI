using Store.Core.Contracts;
using Store.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.DataAccess
{
    public class CartRepository : ICartRepository
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string _conStrn = @"Data Source = .\SQLEXPRESS;Initial Catalog = dbgrocery_store_products; Integrated Security = True";

        public void AddItem(CartDTO cartDTO)
        {
            using (connection = new SqlConnection(_conStrn))
            {
                var sql = $"insert into tbCartItems (Id , prodName, Price, Quantity) values ('{cartDTO.Id}' , '{cartDTO.Name}', {cartDTO.Price}, {cartDTO.Quantity});";
                command = new SqlCommand(sql, connection);
                connection.Open();

                command.ExecuteNonQuery();

            }
        }

        public void ClearCartItems()
        {
            using (connection = new SqlConnection(_conStrn))
            {
                var Query = "delete from dbo.tbCartItems;";
                command = new SqlCommand(Query, connection);
                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public List<CartDTO> GetCartItems()
        {
            var Items = new List<CartDTO>();
            using (connection = new SqlConnection(_conStrn))
            {
                var Query = "select * from dbo.tbCartItems;";
                command = new SqlCommand(Query, connection);
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Items.Add(new CartDTO() { 
                            Id = reader.GetString(4),
                            Name = reader.GetString(3),
                            Price = reader.GetDecimal(0),
                            Quantity = reader.GetInt32(1),
                        });
                    }
                }
            }
            return Items;
        }

        public CartDTO GetItem(string id)
        {
            throw new NotImplementedException();
        }
    }
}
