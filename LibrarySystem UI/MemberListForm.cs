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
    public partial class MemberListForm : Form
    {
        public MemberListForm()
        {
            InitializeComponent();
        }

        private void LoadMembers()
        {
            MemberDAL dal = new MemberDAL();
            dgvMembers.DataSource = dal.GetAllMembers();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek üyeyi seçin");
                return;
            }

            int id = Convert.ToInt32(
                dgvMembers.SelectedRows[0].Cells["Id"].Value
            );

            MemberDAL dal = new MemberDAL();
            dal.DeleteMember(id);


            MessageBox.Show("Üye silindi");
            LoadMembers();
        }

       
    }
}
