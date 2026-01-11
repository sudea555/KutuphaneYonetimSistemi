using LibrarySystem.DAL;
using LibrarySystem.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem_UI
{
    public partial class BorrowForm : Form
    {
        int selectedBorrowId = 0;

        public BorrowForm()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            BookDAL bookDal = new BookDAL();
            MemberDAL memberDal = new MemberDAL();
            BorrowDAL borrowDal = new BorrowDAL();

            cmbBooks.DataSource = bookDal.GetAllBooks();
            cmbBooks.DisplayMember = "Title";
            cmbBooks.ValueMember = "Id";

            cmbMembers.DataSource = memberDal.GetAllMembers();
            cmbMembers.DisplayMember = "Name";
            cmbMembers.ValueMember = "Id";

            dgvBorrows.DataSource = borrowDal.GetActiveBorrows();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (cmbBooks.SelectedValue == null || cmbMembers.SelectedValue == null)
            {
                MessageBox.Show("Kitap ve üye seçmelisiniz");
                return;
            }

            int bookId = Convert.ToInt32(cmbBooks.SelectedValue);
            int memberId = Convert.ToInt32(cmbMembers.SelectedValue);

            BorrowDAL dal = new BorrowDAL();
            dal.BorrowBook(bookId, memberId);

            MessageBox.Show("Kitap ödünç verildi");
        
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (selectedBorrowId == 0)
            {
                MessageBox.Show("Lütfen geri alınacak kaydı seçin");
                return;
            }

            BorrowDAL dal = new BorrowDAL();
            dal.ReturnBook(selectedBorrowId);

            MessageBox.Show("Kitap geri alındı");

            selectedBorrowId = 0;
            LoadBorrows();
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadMembers();
        }

        private void btnBorrow_Click_1(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(cmbBooks.SelectedValue);
            int memberId = Convert.ToInt32(cmbMembers.SelectedValue);

            BorrowDAL dal = new BorrowDAL();
            dal.BorrowBook(bookId, memberId); 

            MessageBox.Show("Kitap ödünç verildi");
        }

       
        private void dgvBorrows_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedBorrowId = Convert.ToInt32(
                dgvBorrows.Rows[e.RowIndex].Cells["id"].Value
            );
        }
        private void LoadBorrows()
        {
            BorrowDAL dal = new BorrowDAL();
            dgvBorrows.DataSource = dal.GetActiveBorrows();
        }

        private void btnBorrow_Click_2(object sender, EventArgs e)
        {

        }
        private void LoadBooks()
        {
            BookDAL dal = new BookDAL();
            cmbBooks.DataSource = dal.GetAllBooks();
            cmbBooks.DisplayMember = "Title";
            cmbBooks.ValueMember = "Id";
        }

        private void LoadMembers()
        {
            MemberDAL dal = new MemberDAL();
            cmbMembers.DataSource = dal.GetAllMembers();
            cmbMembers.DisplayMember = "Name";
            cmbMembers.ValueMember = "Id";
        }

       
    }
}
