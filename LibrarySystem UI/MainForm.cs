using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystem_UI;
using LibrarySystem.MODEL;


namespace LibrarySystem_UI
{
    public partial class MainForm : Form
    {
        private User _currentUser;

        public MainForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // ADMIN → her şey açık
            if (_currentUser.Role == "Admin")
                return;

            // STAFF → sadece kitap listesi
            if (_currentUser.Role == "Staff")
            {
                btnBooks.Enabled = false;      
                btnMembers.Enabled = false;
                btnMemberList.Enabled = false;
                btnBorrow.Enabled = false;
                btnReports.Enabled = false;
                return;
            }

            // MEMBER 
            if (_currentUser.Role == "Member")
            {
                btnBooks.Visible = false;
                btnMembers.Visible = false;
                btnBorrow.Visible = false;
                btnReports.Visible = false;
                btnBookList.Visible = true; // SADECE LİSTE
            }
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            new BookForm().Show();
        }

        private void btnBookList_Click(object sender, EventArgs e)
        {
            new BookListForm().Show();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            new MemberForm().Show();
        }

        private void btnMemberList_Click(object sender, EventArgs e)
        {
            new MemberListForm().Show();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            new BorrowForm().Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            new ReportForm ().Show();
        }

       
    }
}




