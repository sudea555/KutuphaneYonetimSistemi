using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LibrarySystem.DAL;
using LibrarySystem.MODEL;



namespace LibrarySystem.DAL
{
    public class BookDAL
    {
        public void AddBook(Book book)
        {


            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = @"INSERT INTO books 
                           (Title, Author, PublishYear, CreatedDate) 
                           VALUES 
                           (@Title, @Author, @PublishYear, @CreatedDate)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Title", MySqlDbType.VarChar).Value = book.Title ?? "";
                    cmd.Parameters.Add("@Author", MySqlDbType.VarChar).Value = book.Author ?? "";
                    cmd.Parameters.Add("@PublishYear", MySqlDbType.Int32).Value = book.PublishYear;
                    cmd.Parameters.Add("@CreatedDate", MySqlDbType.DateTime).Value = DateTime.Now;


                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }




        }
        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();

            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = "SELECT Id, Title, Author, publishyear FROM books";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Book book = new Book();
                    book.Id = Convert.ToInt32(reader["Id"]);
                    book.Title = reader["Title"].ToString();
                    book.Author = reader["Author"].ToString();
                    book.PublishYear = Convert.ToInt32(reader["publishyear"]);

                    books.Add(book);
                }
            }

            return books;
        }
        public void DeleteBook(int id)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = "DELETE FROM books WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateBook(Book book)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                string sql = @"UPDATE books 
                       SET title=@title, author=@author, publishyear=@year 
                       WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@title", book.Title);
                cmd.Parameters.AddWithValue("@author", book.Author);
                cmd.Parameters.AddWithValue("@year", book.PublishYear);
                cmd.Parameters.AddWithValue("@id", book.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
       
    }
    
}
