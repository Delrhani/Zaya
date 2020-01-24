using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaya.AdministrateurForms
{
    public partial class ModifierMatiere : Form
    {
        private Matiere matiere;
        public ModifierMatiere(Matiere matiere)
        {
            InitializeComponent();
            this.matiere = matiere;
            txtMatiere.Text = matiere.libelle;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtMatiere.Text.Trim().Length > 0)
            { 
                matiere.libelle = txtMatiere.Text;
                DataBaseConfiguration.Context.SubmitChanges();
            } else
            {
                MessageBox.Show("Merci de saisir un nom de la matière", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
