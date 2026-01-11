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
    public partial class ReportForm : Form
    {
        ReportDAL dal = new ReportDAL();
        public ReportForm()
        {
            InitializeComponent();
        }
        private void btnMostBorrowed_Click(object sender, EventArgs e)
        {
            BorrowDAL dal = new BorrowDAL();
            dgvReport.DataSource = dal.GetMostBorrowedBooks();
        }

        private void btnLateBooks_Click(object sender, EventArgs e)
        {
            BorrowDAL dal = new BorrowDAL();
            dgvReport.DataSource = dal.GetLateBooks();
        }

        private void btnActiveMembers_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = dal.ActiveMembers();
        }

        private void btnMonthlyStats_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = dal.MonthlyStats();
        }
    

        private void btnActiveBorrows_Click(object sender, EventArgs e)
        {
            BorrowDAL dal = new BorrowDAL();
            dgvReport.DataSource = dal.GetActiveBorrowReport();
        }

       
    }
}
