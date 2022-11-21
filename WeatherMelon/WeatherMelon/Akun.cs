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
        public int id;
        public string username;
        public string password;
        // public string email;
        public string tempatTinggal;

        public Akun(int id, string username, string password, string tempatTinggal)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            // this.email = email;
            this.tempatTinggal = tempatTinggal;
        }
    }
}
