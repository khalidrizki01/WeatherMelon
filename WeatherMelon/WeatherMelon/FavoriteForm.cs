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
    public partial class FavoriteForm : Form
    {
        public FavoriteForm()
        {
            InitializeComponent();
            DisplayFavorites();
        }

        public void DisplayFavorites()
        {
            List<BoxFavorit> listFavorit = new List<BoxFavorit>();
            for(int i =0; i < 6; i++)
            {
                BoxFavorit boxFavorit = new BoxFavorit();
                favoriteContainer.Controls.Add(boxFavorit);
            }
        }
    }
}
