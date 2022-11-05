using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private NpgsqlConnection conn;
        public static string connstring = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=postgres";
        private string query;
        private NpgsqlCommand cmd;
        private DataTable dt;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }
                query = "Select * from tbluser where username = '" + tbEmail.Text.Trim() + "'and password = '" + tbPassword.Text.Trim() + "'";
                /*SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);*/

                cmd = new NpgsqlCommand(query, conn);
                dt = new DataTable();

                NpgsqlDataReader rd = cmd.ExecuteReader();

                dt.Load(rd);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login berhasil");
                    MainForm objForm1 = new MainForm();
                    this.Hide();
                    objForm1.Show();
                }
                else if (tbPassword.Text == "" || tbEmail.Text == "")
                {
                    MessageBox.Show("Tidak ada input");
                }
                else
                    MessageBox.Show("Username belum terdaftar atau salah");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblRegister_DoubleClick(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm(this);
            this.Hide();
            register.ShowDialog();
           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
