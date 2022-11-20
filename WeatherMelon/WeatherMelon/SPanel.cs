using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherMelon
{
    public class SPanel : Panel
    {
        private int padd = 40;
        /*public void Padd(int padd)
        {
            set{ _padd = padd; }
        }*/
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(Color.White), padd, padd, this.Width - 2*padd, this.Height - 2*padd, 10);
            g.DrawLine(Pens.DarkSlateBlue, 39, 120, 1141, 120);
        }
    }
}
