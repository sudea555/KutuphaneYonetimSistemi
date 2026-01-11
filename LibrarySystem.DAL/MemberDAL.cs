using LibrarySystem.MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.DAL
{
    public class MemberDAL
    {
        public void AddMember(Member member)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = @"INSERT INTO members (name, email, phone)
                               VALUES (@name, @email, @phone)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", member.Name);
                cmd.Parameters.AddWithValue("@email", member.Email);
                cmd.Parameters.AddWithValue("@phone", member.Phone);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Member> GetAllMembers()
        {
            List<Member> list = new List<Member>();

            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = "SELECT * FROM members";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Member
                    {
                        Id = (int)dr["id"],
                        Name = dr["name"].ToString(),
                        Email = dr["email"].ToString(),
                        Phone = dr["phone"].ToString()
                    });
                }
            }
            return list;
        }
        public void DeleteMember(int id)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = "DELETE FROM members WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
