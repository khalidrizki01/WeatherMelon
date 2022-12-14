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
using WeatherMelon.Properties;
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
        private bool hidePassword = true;
        Akun akun;

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
/*                dt = new DataTable();

                NpgsqlDataReader rd = cmd.ExecuteReader();

                dt.Load(rd);

                if (dt.Rows.Count != 0)
                {
                    
                    MessageBox.Show("Registrasi Berkendala");
                    *//*MainForm objForm1 = new MainForm(akun);
                    this.Hide();
                    objForm1.Show();*//*

                }*/
                if (tbEmailRegist.Text == "" || tbPasswordRegist.Text == "" || tbCityRegist.Text=="" || tbNameRegist.Text=="")
                {
                    MessageBox.Show("Harap isi seluruh kolom", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    NpgsqlDataReader rd = cmd.ExecuteReader();
                    MessageBox.Show("Registrasi berhasil, silakan log in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }   
            }

            catch (PostgresException ex)
            {
                MessageBox.Show("Email sudah terdaftar", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            loginForm.Show();
            //Application.Exit();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            hidePassword = !hidePassword;
            tbPasswordRegist.UseSystemPasswordChar = hidePassword;
        }
    }
}
