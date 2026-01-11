using LibrarySystem.DAL;
using LibrarySystem.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem_UI
{
    public partial class BookForm : Form
    {
        public void LoadSelectedBook(int id, string title, string author, string year)
        {
            
            selectedBookId = id;
            txtTitle.Text = title;
            txtAuthor.Text = author;
            txtPublishYear.Text = year;
            MessageBox.Show("BookForm ID ALDI: " + selectedBookId); 
        }

        int selectedBookId = 0;
        public BookForm()
        {
            InitializeComponent();
        }
        public BookForm(int bookId)
        {
            InitializeComponent();
            MessageBox.Show("Seçilen Kitap ID: " + bookId);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
     string.IsNullOrWhiteSpace(txtAuthor.Text) ||
     string.IsNullOrWhiteSpace(txtPublishYear.Text))
            {
                MessageBox.Show("Tüm alanları doldurun");
                return;
            }

            if (!int.TryParse(txtPublishYear.Text, out int year))
            {
                MessageBox.Show("Yıl sayı olmalı");
                return;
            }

            Book book = new Book
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                PublishYear = year
            };

            BookDAL dal = new BookDAL();
            dal.AddBook(book);

            MessageBox.Show("Kitap eklendi");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update basıldı, ID = " + selectedBookId); 

            if (selectedBookId == 0)
            {
                MessageBox.Show("Güncellenecek kitap seçilemedi");
                return;
            }

            Book book = new Book
            {
                Id = selectedBookId,
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                PublishYear = int.Parse(txtPublishYear.Text)
            };

            BookDAL dal = new BookDAL();
            dal.UpdateBook(book);

            MessageBox.Show("Kitap güncellendi!");

        }



    }
    
}
