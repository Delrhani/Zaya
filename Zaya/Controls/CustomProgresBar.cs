using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaya.Controls
{
    public partial class CustomProgresBar : Form
    {
        public CustomProgresBar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=1;i<=100;i++)
            {
                Thread.Sleep(5);
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();


            }
        }

        private void CustomProgresBar_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
        }
    }
}
