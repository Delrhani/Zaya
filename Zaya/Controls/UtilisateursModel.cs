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
    public partial class UtilisateursModel : UserControl
    {
        public UtilisateursModel()
        {
            InitializeComponent();
        }

        private void LeconsModel_Load(object sender, EventArgs e)
        {
            int y = 0;
            var v = from u in DataBaseConfiguration.Context.Utilisateur
                    select u;
            foreach (Utilisateur u in v)
            {
                UtilisateurModel utilisateurModel = new UtilisateurModel(u);
                Point p = utilisateurModel.Location;
                p.Y = y;
                y += utilisateurModel.Height + 5;
                utilisateurModel.Location = p;
                panelContenu.Controls.Add(utilisateurModel);
            }
        }

        private void panelContenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
