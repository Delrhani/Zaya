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
    public partial class ModifierLecon : Form
    {
        private Lecon lecon;
        public ModifierLecon(Lecon lecon)
        {
            InitializeComponent();
            this.lecon = lecon;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtLecon.Text.Trim().Length > 0)
            { 
                lecon.textLecon = txtLecon.Text;
                lecon.idMatiere = int.Parse(cmbMatiere.SelectedValue.ToString());
                lecon.libelle = txtLibelle.Text;
                DataBaseConfiguration.Context.SubmitChanges();
                this.Close();
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
            cmbMatiere.SelectedValue = lecon.idMatiere;
            txtLibelle.Text = lecon.libelle;
            txtLecon.Text = lecon.textLecon;
        }

      

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Voulez-vous vraiment annuler les modifications ?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }
    }
}
