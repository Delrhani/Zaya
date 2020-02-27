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
    public partial class LeconModel : UserControl
    {
        private Lecon lecon;
        private Utilisateur utilisateur;
        public LeconModel(Lecon lecon, Utilisateur utilisateur) : this()
        {
            this.lecon = lecon;
            this.utilisateur = utilisateur;
            BindingData();
        }

        public LeconModel()
        {
            InitializeComponent();
        }

        private void BindingData()
        {
            string value = lecon.textLecon;
            if (lecon.textLecon.Length > 60)
            {
                value = value.Substring(0, 60);
                value = value.Substring(0, value.LastIndexOf(' '));
            }
            this.txtTitle.Text = lecon.libelle;
            this.txtNomProfesseur.Text = lecon.Utilisateur.nom + ' ' + lecon.Utilisateur.prenom;
            this.txtLesson.Text = lecon.textLecon;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            new CommunForms.DetailsLecon(lecon, utilisateur).ShowDialog();
            /*
             aaaaaaaaaaaabbbbbbbbbbbbbbbbbbbbbbbbbbbbbbaaaaaaaaaaaavvvvv4vv
             */
        }

        private void txtNomProfesseur_Click(object sender, EventArgs e)
        {

        }
    }
}
