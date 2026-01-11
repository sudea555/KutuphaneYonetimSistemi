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
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Tüm alanları doldurun");
                return;
            }

            Member member = new Member
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text
            };

            MemberDAL dal = new MemberDAL();
            dal.AddMember(member);

            MessageBox.Show("Üye eklendi");

            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }

        
    }
}
