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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WeatherMelon
{
    public partial class RegisterForm : Form
    {
        LoginForm loginForm;
        private NpgsqlConnection conn;
        private string query;
        private NpgsqlCommand cmd;
        private DataTable dt;


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
                query = "INSERT INTO tableuser(username, password, favcity) VALUES ('" + tbEmailRegist.Text.Trim() + "', '" + tbPasswordRegist.Text.Trim() + "', '" + tbCityRegist.Text.Trim() + "')";
                cmd = new NpgsqlCommand(query, conn);

/*              cmd.Parameters.AddWithValue("_username", tbNameRegist.Text);
                cmd.Parameters.AddWithValue("_password", tbPasswordRegist.Text);*/

/*                if((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Success", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }*/
                dt = new DataTable();

                NpgsqlDataReader rd = cmd.ExecuteReader();

                dt.Load(rd);

                if (dt.Rows.Count != 0)
                {
                    MessageBox.Show("Registrasi Berkendala");
/*                    MainForm objForm1 = new MainForm();
                    this.Hide();
                    objForm1.Show();*/

                }
                else if (tbEmailRegist.Text == "" || tbPasswordRegist.Text == "")
                {
                    MessageBox.Show("Tidak ada input");
                }
                else
                {
                    MessageBox.Show("Registrasi berhasil");
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
