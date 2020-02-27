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

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Voulez-vous vraiment annuler les modifications ?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }
        Point lastPoint;
        private void ModifierMatiere_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ModifierMatiere_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
