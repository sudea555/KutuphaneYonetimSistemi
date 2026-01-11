using LibrarySystem.MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibrarySystem.DAL
{
    public class BorrowDAL
    {
        public void BorrowBook(int bookId, int memberId)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = @"INSERT INTO borrows 
                       (book_id, member_id, borrow_date, is_returned) 
                       VALUES 
                       (@bookId, @memberId, NOW(), 0)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@bookId", bookId);
                cmd.Parameters.AddWithValue("@memberId", memberId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public List<Borrow> GetActiveBorrows()
        {
            List<Borrow> list = new List<Borrow>();

            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = @"SELECT * FROM borrows 
                       WHERE is_returned = 0";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Borrow
                    {
                        Id = Convert.ToInt32(dr["id"]),
                        BookId = Convert.ToInt32(dr["book_id"]),
                        MemberId = Convert.ToInt32(dr["member_id"]),
                        BorrowDate = Convert.ToDateTime(dr["borrow_date"]),
                        ReturnDate = dr["return_date"] == DBNull.Value
                                     ? (DateTime?)null
                                     : Convert.ToDateTime(dr["return_date"]),
                        IsReturned = Convert.ToBoolean(dr["is_returned"])
                    });
                }
            }

            return list;
        }

        public void ReturnBook(int borrowId)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = @"UPDATE borrows 
                       SET return_date = NOW(), is_returned = 1 
                       WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", borrowId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetActiveBorrowReport()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = @"
        SELECT 
            b.id,
            bk.title AS Kitap,
            m.name AS Uye,
            b.borrow_date
        FROM borrows b
        JOIN books bk ON b.book_id = bk.id
        JOIN members m ON b.member_id = m.id
        WHERE b.return_date IS NULL";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetActiveBorrowsReport()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = @"
        SELECT 
            b.id AS BorrowId,
            bo.title AS BookTitle,
            m.name AS MemberName,
            b.borrow_date AS BorrowDate
        FROM borrows b
        JOIN books bo ON b.book_id = bo.id
        JOIN members m ON b.member_id = m.id
        WHERE b.return_date IS NULL
        ";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
        
       
        public DataTable GetActiveMembers()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = @"
            SELECT m.name, COUNT(*) AS total_borrow
            FROM borrows br
            JOIN members m ON m.id = br.member_id
            GROUP BY m.name
            ORDER BY total_borrow DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        


        public DataTable GetMostBorrowedBooks()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = @"
            SELECT b.title AS Kitap, COUNT(*) AS OduncSayisi
            FROM borrows br
            JOIN books b ON br.book_id = b.id
            GROUP BY b.title
            ORDER BY OduncSayisi DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetLateBooks()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = @"
            SELECT b.title AS Kitap, m.name AS Uye, br.borrow_date
            FROM borrows br
            JOIN books b ON br.book_id = b.id
            JOIN members m ON br.member_id = m.id
            WHERE br.return_date IS NULL
            AND br.borrow_date < DATE_SUB(NOW(), INTERVAL 15 DAY)";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


    }

}
