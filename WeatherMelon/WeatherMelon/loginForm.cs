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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text=="user@gmail.com" && tbPassword.Text=="password")
            {
                // DialogResult = DialogResult.OK;
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
                // Close();
            }
            else
            {
                MessageBox.Show("Masukkan 'user@gmail.com' dan 'password'");
            }
        }

        private void lblRegister_DoubleClick(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm(this);
            this.Hide();
            register.ShowDialog();
           
        }
    }
}
