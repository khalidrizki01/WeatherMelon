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

                    MessageBox.Show("Search berhasil!");
                }

                catch (Exception)
                {
                    MessageBox.Show("Daerah tidak dikenali!");
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

            pictureBoxCondition.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCondition.Image = getIcon(dtl.iconUrl);

            Displayer_4Days(); 
        }

        private void Displayer_4Days()
        {
            DataTable dt = dtl.GetNext4Days();
            List<DetailCuaca> fourDaysAhead = new List<DetailCuaca>();
            for (int i = 1; i < 5; i++)
            {
                DetailCuaca tempDtl = new DetailCuaca();
                tempDtl.date = Convert.ToString(dt.Rows[i]["Tanggal"]);
                tempDtl.minTemp = Convert.ToString(dt.Rows[i]["Temp"]);
                tempDtl.condition = Convert.ToString(dt.Rows[i]["Kondisi"]);
                tempDtl.icon = (Bitmap)dt.Rows[i]["Icon"];
                fourDaysAhead.Add(tempDtl);
                // MessageBox.Show(tempDtl.date);
            }

            //besok 
            lblHari1.Text = DisplayDayDate(fourDaysAhead[0].date);
            lblTempDay1.Text = fourDaysAhead[0].minTemp;
            lblWeather1.Text = fourDaysAhead[0].condition;
            pictureBoxDay1.Image = fourDaysAhead[0].icon;
            //lusa
            lblHari2.Text = DisplayDayDate(fourDaysAhead[1].date);
            lblTempDay2.Text = fourDaysAhead[1].minTemp;
            lblWeather2.Text = fourDaysAhead[1].condition;
            pictureBoxDay2.Image = fourDaysAhead[1].icon;

            //3 hari setelah
            lblHari3.Text = DisplayDayDate(fourDaysAhead[2].date);
            lblTempDay3.Text = fourDaysAhead[2].minTemp;
            weather3.Text = fourDaysAhead[2].condition;
            pictureBoxDay3.Image = fourDaysAhead[2].icon;

            //4 hari setelah
            lblHari4.Text = DisplayDayDate(fourDaysAhead[3].date);
            lblTempDay4.Text = fourDaysAhead[3].minTemp;
            weather4.Text = fourDaysAhead[3].condition;
            pictureBoxDay4.Image = fourDaysAhead[3].icon;
        }

        internal static Bitmap getIcon(string iconURL)
        {
            try
            {
                /*Client to donwload PNG from URL*/
                WebClient client = new WebClient();

                byte[] image = client.DownloadData("http:" + iconURL);
                MemoryStream stream = new MemoryStream(image);
                Bitmap newBitmap = new Bitmap(stream);

                Bitmap icon = newBitmap;
                return icon;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private string DisplayDayDate(string date)
        {
            return String.Format("{0}\n{1}", DateTime.Parse(date).DayOfWeek, DateTime.Parse(date).ToShortDateString());
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
