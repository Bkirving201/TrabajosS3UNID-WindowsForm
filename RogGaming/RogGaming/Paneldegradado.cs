using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogGaming
{
    class Paneldegradado : Panel
    {
        public Color ColorTop { get; set; }

        public Color Colormid { get; set; }
        public Color ColorBottm { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgd = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottm, 90F);

            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[3] { ColorTop, Colormid, ColorBottm};
            cblend.Positions = new float[3] { 0f, 0.5f, 1f };

            lgd.InterpolationColors = cblend;
            e.Graphics.FillRectangle(lgd, this.ClientRectangle);

            base.OnPaint(e);
        }

    }
}
