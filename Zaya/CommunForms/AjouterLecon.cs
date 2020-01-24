using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaya.CommunForms
{
    public partial class AjouterLecon : Form
    {
        private Utilisateur utilisateur;
        public AjouterLecon(Utilisateur utilisateur)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtLecon.Text.Trim().Length > 0)
            { 
                Lecon lecon = new Lecon();
                lecon.textLecon = txtLecon.Text;
                lecon.idMatiere = int.Parse(cmbMatiere.SelectedValue.ToString());
                lecon.libelle = txtLibelle.Text;
                lecon.idUtilisateur = utilisateur.idUtilisateur;
                DataBaseConfiguration.Context.Lecon.InsertOnSubmit(lecon);
                DataBaseConfiguration.Context.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Merci de saisir le texte du leçon", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }

        }

        private void AjouterLecon_Load(object sender, EventArgs e)
        {
            var resultat = from m in DataBaseConfiguration.Context.Matiere
                           select new { m.libelle, m.idMatiere };
            cmbMatiere.ValueMember = "idMatiere";
            cmbMatiere.DisplayMember = "libelle";
            cmbMatiere.DataSource = resultat;
        }
    }
}
