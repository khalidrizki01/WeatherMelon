using Npgsql;
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
        private NpgsqlConnection conn;
        private string query;
        private NpgsqlCommand cmd;

        public LoginForm LoginForm { get => loginForm; set => loginForm = value; }

        public RegisterForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.LoginForm = loginForm;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if(conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }
                query = @"SELECT * FROM user_insert(:_username,:_password)";
                cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("_username", tbNameRegist.Text);
                cmd.Parameters.AddWithValue("_password", tbPasswordRegist.Text);

                if((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Success", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            //this.Hide();
            if (!this.LoginForm.Visible)
            {
                LoginForm.Show();
                this.Hide();
            } else {
                this.LoginForm.SendToBack();
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(LoginForm.connstring);
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
