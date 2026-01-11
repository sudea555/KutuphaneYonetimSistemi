using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystem.DAL;
using LibrarySystem.MODEL;

namespace LibrarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = "Deneme Kitabı";
            book.Author = "Sude";
            book.Year = 2024;

            BookDAL dal = new BookDAL();
            dal.AddBook(book);

            MessageBox.Show("Kitap eklendi!");

        }
    }
}
