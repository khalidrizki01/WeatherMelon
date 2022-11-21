using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
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

        private NpgsqlConnection conn;
        internal static string connstring = "Host=weathermelonserver.postgres.database.azure.com;Port=5432;Username=informatika@weathermelonserver;Password=Rangga12!;Database=mypgsqldb";
        private string query;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private bool hidePassword = true;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }
                query = "Select * from tableuser where username = '" + tbEmail.Text.Trim() + "'and password = '" + tbPassword.Text.Trim() + "'";

                cmd = new NpgsqlCommand(query, conn);
                dt = new DataTable();

                NpgsqlDataReader rd = cmd.ExecuteReader();

                dt.Load(rd);

                if (dt.Rows.Count == 1)
                {
                    // dataGridView1.DataSource = dt;
                    Akun akun = new Akun((Int32)dt.Rows[0]["id"], dt.Rows[0]["username"].ToString(), dt.Rows[0]["password"].ToString(), dt.Rows[0]["favcity"].ToString());
                    MessageBox.Show("Login berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainForm objForm1 = new MainForm(akun);
                    this.Hide();
                    objForm1.Show();

                }
                else if (tbPassword.Text == "" || tbEmail.Text == "")
                {
                    MessageBox.Show("Harap isi email dan password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Email belum terdaftar atau salah", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : "+ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm(this);
            this.Hide();
            register.Show();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            hidePassword = !hidePassword;
            tbPassword.UseSystemPasswordChar = hidePassword;
        }
    }
}
