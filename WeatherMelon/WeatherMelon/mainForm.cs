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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

/*        private void MainForm_Load(object sender, EventArgs e)
        {
            // this.Shown += MainForm_Shown;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
           *//* LoginForm loginForm = new LoginForm();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Nantikan fitur selanjutnya");
                //this.Close();
            }*//*
        }*/

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DetailCuaca dtl = new DetailCuaca();

            dtl.city = tbSearch.Text;

            dtl.GetForecast();

            lblTodayWeather.Text = dtl.condition;
            lbTemp.Text = dtl.avgTemp;

        }

        }

        private void lblMaxWS_Click(object sender, EventArgs e)
        {

        }
    }
}
