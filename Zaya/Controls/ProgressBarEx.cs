using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaya.Controls
{
    class ProgressBarEx : ProgressBar
    {
        const int WmPaint = 15;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case WmPaint:
                    using (var graphics = Graphics.FromHwnd(Handle))
                    {
                        GraphicsPath path = new GraphicsPath();

                        Rectangle newRectangle = ClientRectangle;

                        newRectangle.Inflate(-2, -2);

                        path.AddRectangle(newRectangle);

                        Region = new Region(path);
                    }
                    break;
            }
        }
    }
}
