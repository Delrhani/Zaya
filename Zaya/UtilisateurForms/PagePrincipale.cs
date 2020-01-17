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

        }
    }
}
