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


namespace LibrarySystem_UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (username == "" || password == "")
                {
                    MessageBox.Show("Kullanıcı adı ve şifre boş olamaz");
                    return;
                }

                UserDAL dal = new UserDAL();
                User user = dal.Login(username, password);

                if (user == null)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                    return;
                }

                MessageBox.Show("Hoş geldin " + user.Username);
                

                MainForm frm = new MainForm(user);
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog();
        }

       
    }
}