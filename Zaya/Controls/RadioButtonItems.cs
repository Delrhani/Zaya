using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaya.Controls
{
    public partial class RadioButtonItems : UserControl
    {
        private List<Reponse> Reponses { get; set; }
        public RadioButtonItems()
        {
            InitializeComponent();
        }

        private void RadioButtonItems_Load(object sender, EventArgs e)
        {

            int y = 0;
            foreach (Reponse r in Reponses)
            {
                RadioButton check = new RadioButton();
                check.Name = r.idReponse.ToString();
                check.Text = r.txtReponse;
                Point point = check.Location;
                point.Y = y;
                panelRadioButton.Controls.Add(check);
                y += check.Location.Y + 5;
            }
        }
    }
}
