using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem.MODEL;


namespace LibrarySystem.DAL
{
    public class UserDAL
    {
        public User Login(string username, string password)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = @"SELECT * FROM users 
                               WHERE username=@u AND password=@p";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return new User
                    {
                        Id = Convert.ToInt32(dr["id"]),
                        Username = dr["username"].ToString(),
                        Role = dr["role"].ToString()
                    };
                }
            }
            return null;
        }
        public void Register(User user)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = @"INSERT INTO users (username, password , email ,   role)
                       VALUES (@u, @p, @e, @r)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", user.Username);
                cmd.Parameters.AddWithValue("@p", user.Password);
                cmd.Parameters.AddWithValue("@e", user.Email);
                cmd.Parameters.AddWithValue("@r", "Member");

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
