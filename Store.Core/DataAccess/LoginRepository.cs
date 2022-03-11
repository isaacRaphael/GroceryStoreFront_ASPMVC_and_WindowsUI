using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Store.Core.DataAccess
{
    public class LoginRepository : ILoginRepository
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string _conStrn = @"Data Source = .\SQLEXPRESS;Initial Catalog = dbgrocery_store_products; Integrated Security = True";


        public Dictionary<string, string> checkUser()
        {
            var users = new Dictionary<string, string>();
            using (connection = new SqlConnection(_conStrn))
            {
                var sql = $"select * from tblogins";
                command = new SqlCommand(sql, connection);
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        users.Add(reader.GetString(0), reader.GetString(1));
                    }
                }
            }

            return users;
        }


    }
}
