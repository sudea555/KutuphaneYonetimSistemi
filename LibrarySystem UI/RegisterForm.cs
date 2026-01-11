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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Tüm alanları doldurun");
                return;
            }

            User user = new User
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Email = txtEmail.Text,
                Role = "Member"
            };

            UserDAL dal = new UserDAL();
            dal.Register(user);

            MessageBox.Show("Kayıt başarılı! Giriş yapabilirsiniz.");
            this.Close();
        }

       
    }
}
