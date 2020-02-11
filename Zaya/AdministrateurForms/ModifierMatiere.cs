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

        }

        private void ModifierMatiere_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void btnAnnuler_MouseHover(object sender, EventArgs e)
        {
            btnAnnuler.BackColor = Color.DarkRed;
        }

        private void btnAnnuler_MouseLeave(object sender, EventArgs e)
        {
            btnAnnuler.BackColor = Color.Transparent;
        }
    }
}
