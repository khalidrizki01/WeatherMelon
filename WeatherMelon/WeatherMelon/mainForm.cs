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
            lbCity.Text = tbSearch.Text;
            
            dtl.city = tbSearch.Text;

            /*Calling method*/

            dtl.GetForecast();
            

            /*To Display Results*/
            Displayer();
            /*Get Icon PNG*/
            getIcon();
        }

        private void Displayer()
        {
            /*Resizing*/
            lbTemp.Font = new Font("Microsoft Sans Serif", 24, FontStyle.Bold);
            lblHum.Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold);
            lblWindSpeed.Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold);

            /*Assigning Values*/
            lblTodayWeather.Text = dtl.condition;
            lbTemp.Text = dtl.avgTemp + "°C";
            lblHum.Text = dtl.humidity;
            lblWindSpeed.Text = dtl.avgwindk + " KpH";
            
            DataTable dt = dtl.GetNext4Days();
            List < DetailCuaca > fourDaysAhead = new List<DetailCuaca>();
            for (int i = 1; i < 5; i++)
            {
                DetailCuaca tempDtl = new DetailCuaca();
                tempDtl.date = Convert.ToString(dt.Rows[i]["Tanggal"]);
                tempDtl.minTemp = Convert.ToString(dt.Rows[i]["Temp"]);
                tempDtl.condition = Convert.ToString(dt.Rows[i]["Kondisi"]);
                fourDaysAhead.Add(tempDtl);
                // MessageBox.Show(tempDtl.date);
            }

            //besok 
            lblHari1.Text = fourDaysAhead[0].date;
            lblTempDay1.Text = fourDaysAhead[0].minTemp;
            lblWeather1.Text = fourDaysAhead[0].condition;
            //lusa
            lblHari2.Text = fourDaysAhead[1].date;
            lblTempDay2.Text = fourDaysAhead[1].minTemp;
            lblWeather2.Text = fourDaysAhead[1].condition;

            //3 hari setelah
            lblHari3.Text = fourDaysAhead[2].date;
            lblTempDay3.Text = fourDaysAhead[2].minTemp;
            weather3.Text = fourDaysAhead[2].condition;

            //4 hari setelah
            lblHari4.Text = fourDaysAhead[3].date;
            lblTempDay4.Text = fourDaysAhead[3].minTemp;
            weather4.Text = fourDaysAhead[3].condition;
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
