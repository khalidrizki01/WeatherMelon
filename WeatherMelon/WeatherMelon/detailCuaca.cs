using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WeatherMelon
{
    internal class DetailCuaca
    {
        public string searched_city;
        public string resulting_city;
        public string country;

        public string maxTemp;
        public string minTemp;
        public string avgTemp;

        public string maxwindm;
        public string maxwindk;
        public string avgwindk;

        public string humidity;
        public string condition;
        public string date;

        public string localtime;

        public string iconUrl;
        public void GetForecast()
        {
            string url = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=5aec79e3b7f241ac9be131349221311&q={0}&days=0&aqi=no&alerts=no", this.searched_city);

            XDocument doc = XDocument.Load(url);

            resulting_city = (string)doc.Descendants("name").FirstOrDefault();

            country = (string)doc.Descendants("country").FirstOrDefault();

            maxTemp = (string)doc.Descendants("maxtemp_c").FirstOrDefault();
            minTemp = (string)doc.Descendants("mintemp_c").FirstOrDefault();

            avgTemp = (string)doc.Descendants("avgtemp_c").FirstOrDefault();

            maxwindm = (string)doc.Descendants("maxwind_mph").FirstOrDefault();
            maxwindk = (string)doc.Descendants("maxwind_kph").FirstOrDefault();

            avgwindk = (string)doc.Descendants("wind_kph").FirstOrDefault();

            humidity = (string)doc.Descendants("avghumidity").FirstOrDefault();

            condition = (string)doc.Descendants("text").FirstOrDefault();

            localtime = (string)doc.Descendants("localtime").FirstOrDefault();

            iconUrl = (string)doc.Descendants("icon").FirstOrDefault();
        }

        public DataTable GetNext4Days()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tanggal", typeof(string));
            dt.Columns.Add("Temp", typeof(string));
            dt.Columns.Add("Kondisi", typeof(string));
            dt.Columns.Add("Icon", typeof(string));

            string url = String.Format("https://api.weatherapi.com/v1/forecast.xml?key=137c78c1a0874ace81c70453222011&q={0}&days=5&aqi=no&alerts=no", this.city);
            XDocument doc = XDocument.Load(url);
            foreach (var npc in doc.Descendants("forecastday")) //loop untuk mengambil data API.
            {
                string iconUrl = (string)npc.Descendants("icon").FirstOrDefault();

                WebClient client = new WebClient();

                byte[] image = client.DownloadData("http:" + iconUrl);

                MemoryStream stream = new MemoryStream(image);

                Bitmap newBitmap = new Bitmap(stream);

                dt.Rows.Add(new object[]
                {
                      //display negara ditulis doc karena tidak berubah seiring waktu dalam loop.
                    (string)npc.Descendants("date").FirstOrDefault(),
                    (string)npc.Descendants("mintemp_c").FirstOrDefault(),
                    (string)npc.Descendants("text").FirstOrDefault(),
                    newBitmap
                });

            }
            return dt;
        }
    }

}
