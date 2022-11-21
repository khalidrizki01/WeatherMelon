using Npgsql;
using System;
using System.Collections;
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
        private List<string> listAutofill = new List<string>();
        Akun akun;
        private bool bookmarked = false;

        public MainForm(Akun akun)
        {
            InitializeComponent();
            this.akun = akun;
            dtl.searched_city = akun.tempatTinggal;
            dtl.GetForecast();
            Displayer();
            tbSearch.Text = "";

            listAutofill = dtl.Autofill();
            foreach (string kota in listAutofill)
            {
                tbSearch.AutoCompleteCustomSource.Add(kota);
                tbSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }

        }

        private NpgsqlConnection conn = new NpgsqlConnection(LoginForm.connstring);
        private string query;
        private NpgsqlCommand cmd;
        private DataTable dt;

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                MessageBox.Show("Search Box Kosong!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /*To Display Results*/
                try
                {
                    dtl.searched_city = tbSearch.Text;
                    dtl.GetForecast();
                    Displayer();
                    MessageBox.Show("Search berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Daerah tidak dikenali!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Displayer()
        {
            /*Resizing*/
            lbTemp.Font = new Font("Microsoft Sans Serif", 24, FontStyle.Bold);
            lblHum.Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold);
            lblWindSpeed.Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold);
            lblRec.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

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

            RecommendAction();
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
            }

            //besok 
            lblHari1.Text = DisplayDayDate(fourDaysAhead[0].date);
            lblTempDay1.Text = String.Format(fourDaysAhead[0].minTemp+ " °C");
            lblWeather1.Text = fourDaysAhead[0].condition;
            pictureBoxDay1.Image = fourDaysAhead[0].icon;
            //lusa
            lblHari2.Text = DisplayDayDate(fourDaysAhead[1].date);
            lblTempDay2.Text = String.Format(fourDaysAhead[1].minTemp + " °C");
            lblWeather2.Text = fourDaysAhead[1].condition;
            pictureBoxDay2.Image = fourDaysAhead[1].icon;

            //3 hari setelah
            lblHari3.Text = DisplayDayDate(fourDaysAhead[2].date);
            lblTempDay3.Text = String.Format(fourDaysAhead[2].minTemp + " °C");
            weather3.Text = fourDaysAhead[2].condition;
            pictureBoxDay3.Image = fourDaysAhead[2].icon;

            //4 hari setelah
            lblHari4.Text = DisplayDayDate(fourDaysAhead[3].date);
            lblTempDay4.Text = String.Format(fourDaysAhead[3].minTemp + " °C");
            weather4.Text = fourDaysAhead[3].condition;
            pictureBoxDay4.Image = fourDaysAhead[3].icon;
        }

        private void RecommendAction()
        {
            if (dtl.condition == "Sunny" || dtl.condition == "Clear"
                || dtl.condition == "Partly cloudy")
            {
                lblRec.Text = "Cuaca Cerah";
            }
            else if (dtl.condition == "Cloudy" || dtl.condition == "Overcast"
                || dtl.condition == "Mist")
            {
                lblRec.Text = "Cuaca Berawan";
            }
            else
                lblRec.Text = "Cuaca Tidak menentu";
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
                MessageBox.Show("Error : " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBookmark_Click(object sender, EventArgs e)
        {
            bookmarked = !bookmarked;
            if(bookmarked) pictureBookmark.BackColor = System.Drawing.Color.DarkSlateBlue;
            else pictureBookmark.BackColor = System.Drawing.Color.White;

            SaveFavorite();
        }

        private void SaveFavorite()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }
                query = "INSERT INTO tablefavorit(id_user,kota) VALUES ('" + akun.id + "', '" + dtl.resulting_city.Trim() + "')";

                cmd = new NpgsqlCommand(query, conn);

                dt = new DataTable();

                NpgsqlDataReader rd = cmd.ExecuteReader();

                dt.Load(rd);

                if (dt.Rows.Count != 0)
                {

                    MessageBox.Show("Registrasi Berkendala");
                    /*MainForm objForm1 = new MainForm(akun);
                    this.Hide();
                    objForm1.Show();*/

                }
                else
                {
                    MessageBox.Show("Bookmark berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (PostgresException ex)
            {
                MessageBox.Show("Kota sudah dibookmark", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    
}
