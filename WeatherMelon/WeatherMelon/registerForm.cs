using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherMelon
{
    public partial class RegisterForm : Form
    {
        LoginForm loginForm;
        public RegisterForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbNameRegist.Text == "John Doe" && tbEmailRegist.Text == "user@gmail.com" && tbPasswordRegist.Text == "password" && tbCityRegist.Text=="Jogja")
            {
                MessageBox.Show("Anda berhasil Sign Up, silakan Login");
                DialogResult = DialogResult.OK;
                loginForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Masukkan 'John Doe', 'user@gmail.com', 'password', dan 'Jogja'");
            }
        }

        private void lblLogin_DoubleClick(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }
    }
}
