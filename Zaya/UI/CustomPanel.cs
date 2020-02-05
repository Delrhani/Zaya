using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaya.UI
{
    class CustomPanel : Panel
    {
        public Color ColorBottom { get; set; }
        public Color ColorTop { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new
            LinearGradientBrush(this.ClientRectangle, this.ColorTop,
            this.ColorBottom, 50f);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
