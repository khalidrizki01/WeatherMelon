using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
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
    }

}
