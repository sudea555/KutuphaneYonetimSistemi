using LibrarySystem.DAL;
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
    public partial class BookListForm : Form
    {
        public BookListForm()
        {
            InitializeComponent();
            LoadBooks();
        }
        private void LoadBooks()

        {
            BookDAL dal = new BookDAL();
            dgvBooks.DataSource = dal.GetAllBooks();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BookDAL dal = new BookDAL();
            dgvBooks.DataSource = dal.GetAllBooks();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek kitabı seç");

                return;

            }
            int id = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["id"].Value);
            BookDAL dal = new BookDAL(); dal.DeleteBook(id);
            MessageBox.Show("Kitap silindi");
            LoadBooks(); 
        }


        private void dgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells["Id"].Value);
            string title = dgvBooks.Rows[e.RowIndex].Cells["Title"].Value.ToString();
            string author = dgvBooks.Rows[e.RowIndex].Cells["Author"].Value.ToString();
            string year = dgvBooks.Rows[e.RowIndex].Cells["PublishYear"].Value.ToString();

            BookForm frm = new BookForm();
            frm.LoadSelectedBook(id, title, author, year);
            frm.Show();
        }

        
    }
    
}