using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherMelon
{
    public partial class MainForm : Form
    {
        /*Constructor for DetailCuaca.cs*/
        private readonly DetailCuaca dtl = new DetailCuaca();

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
            if (tbSearch.Text == "")
            {
                MessageBox.Show("Search Box Kosong!");
            }
            else
            {
                /*To Display Results*/
                try
                {
                    dtl.searched_city = tbSearch.Text;
                    dtl.GetForecast();
                    Displayer();
                    /*Get Icon PNG*/
                    getIcon();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n karena Daerah tidak dikenali");
                }
            }
        }

        private void Displayer()
        {
            /*Resizing*/
            lbTemp.Font = new Font("Microsoft Sans Serif", 24, FontStyle.Bold);
            lblHum.Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold);
            lblWindSpeed.Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold);

            /*Assigning Values*/
            lbCity.Text = dtl.resulting_city;
            tbSearch.Text = dtl.resulting_city;

            lblTodayWeather.Text = dtl.condition;
            lbTemp.Text = dtl.avgTemp + "°C";
            lblHum.Text = dtl.humidity;
            lblWindSpeed.Text = dtl.avgwindk + " KpH";

            lblLocalTime.Text = dtl.localtime;
        }

        private void getIcon()
        {
            /*Client to donwload PNG from URL*/
            WebClient client = new WebClient();

            byte[] image = client.DownloadData("http:" + dtl.iconUrl);
            MemoryStream stream = new MemoryStream(image);
            Bitmap newBitmap = new Bitmap(stream);

            Bitmap icon = newBitmap;

            pictureBoxCondition.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCondition.Image = icon;
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }
    }
}
