using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WeatherMelon
{
    internal class detailCuaca
    {
        public string city;
        public string country;

        public string maxTemp;
        public string minTemp;

        public string maxwindm;
        public string maxwindk;

        public string humidity;
        public string condition;

        public void GetForecast()
        {
            string url = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=d03903d1f8894aa4aa840215212704&q={0}&days=1&aqi=no&alerts=no", city);

            XDocument doc = XDocument.Load(url);

            country = (string)doc.Descendants("country").FirstOrDefault();

            maxTemp = (string)doc.Descendants("maxtemp_c").FirstOrDefault();
            minTemp = (string)doc.Descendants("mintemp_c").FirstOrDefault();

            maxwindm = (string)doc.Descendants("maxwind_mph").FirstOrDefault();
            maxwindk = (string)doc.Descendants("maxwind_kph").FirstOrDefault();

            humidity = (string)doc.Descendants("avghumidity").FirstOrDefault();

            condition = (string)doc.Descendants("text").FirstOrDefault();

            //return (country, maxTemp, minTemp, maxwindk, maxwindm, humidity, condition);
        }
    }

}
