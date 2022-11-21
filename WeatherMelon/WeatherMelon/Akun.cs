using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WeatherMelon
{
    public class Akun
    {
        public string username;
        public string password;
        // public string email;
        public string tempatTinggal;

        public Akun(string username, string password, string tempatTinggal)
        {
            this.username = username;
            this.password = password;
            // this.email = email;
            this.tempatTinggal = tempatTinggal;
        }
    }
}
