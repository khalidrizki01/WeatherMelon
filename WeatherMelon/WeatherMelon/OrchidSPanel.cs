using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace WeatherMelon
{
    public class OrchidSPanel : Panel
    {
        private int padd = 1;
        protected override void OnPaint(PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(Color.DarkOrchid), 1, 1, this.Width-2*padd, this.Height-2, 10);
        }
    }
}
