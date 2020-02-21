using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaya.UtilisateurForms
{
    public partial class PagePrincipale : Form
    {
        private Utilisateur utilisateur;

        public PagePrincipale(Utilisateur utilisateur)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
        }

        private void PagePrincipale_Load(object sender, EventArgs e)
        {
            customPanel1.ColorTop = Color.FromArgb(35, 186, 201, 57);
            customPanel1.ColorBottom = Color.FromArgb(255, 253, 187, 45);
        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
