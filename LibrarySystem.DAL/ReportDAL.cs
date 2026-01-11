using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.DAL
{
    public class ReportDAL
    {
        public DataTable MostBorrowedBooks()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = @"
                SELECT b.title, COUNT(*) AS borrow_count
                FROM borrows br
                JOIN books b ON br.book_id = b.id
                GROUP BY b.title
                ORDER BY borrow_count DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Geciken kitaplar
        public DataTable LateBooks()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = @"
                SELECT b.title, m.name, br.borrow_date
                FROM borrows br
                JOIN books b ON br.book_id = b.id
                JOIN members m ON br.member_id = m.id
                WHERE br.return_date IS NULL 
                AND br.borrow_date < DATE_SUB(NOW(), INTERVAL 14 DAY)";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Aktif üyeler
        public DataTable ActiveMembers()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = @"
                SELECT m.name, COUNT(*) AS borrow_count
                FROM borrows br
                JOIN members m ON br.member_id = m.id
                GROUP BY m.name
                ORDER BY borrow_count DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Aylık ödünç istatistiği
        public DataTable MonthlyStats()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = @"
                SELECT MONTH(borrow_date) AS Ay, COUNT(*) AS Toplam
                FROM borrows
                GROUP BY MONTH(borrow_date)";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetActiveBorrows()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = @"
                SELECT b.title, m.name, br.borrow_date
                FROM borrows br
                JOIN books b ON br.book_id = b.id
                JOIN members m ON br.member_id = m.id
                WHERE br.return_date IS NULL";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
