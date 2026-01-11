using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibrarySystem.DAL
{
    public class DbHelper
    {
        private static string connectionString = "Server=172.21.54.253;Database=26_132430009;Uid=26_132430009;Pwd=İnif123;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
