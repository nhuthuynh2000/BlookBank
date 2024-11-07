using BloodBankManagement.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagement.View
{
    public partial class LoginForm : Form
    {
        MainForm mainForm;


        public LoginForm(MainForm form)
        {
            InitializeComponent();
            mainForm = form;


        }



        private void btn_login_Click(object sender, EventArgs e)
        {
            Login controller = new Login();
            bool isAuthenticated = controller.LoginController(txt_email.Text, txt_pass.Text);

            if (isAuthenticated)
            {
                MessageBox.Show("Đăng nhập thành công!");
                mainForm.isLoggedIn = true;
                mainForm.role = controller.GetRole(txt_email.Text, txt_pass.Text);

                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            UpdateLoginButtonState();
        }
        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            UpdateLoginButtonState();
        }
        private void UpdateLoginButtonState()
        {
            bool isUsernameFilled = !string.IsNullOrWhiteSpace(txt_email.Text);
            bool isPasswordFilled = !string.IsNullOrWhiteSpace(txt_pass.Text);

            btn_login.Enabled = isUsernameFilled && isPasswordFilled;
        }

        private void txt_email_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            btn_login.Enabled = false;
        }
    }
}
