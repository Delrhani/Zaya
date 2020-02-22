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
    public partial class DetailsLecon : Form
    {
        private Lecon lecon;
        public DetailsLecon(Lecon lecon)
        {
            InitializeComponent();
            this.lecon = lecon;
        }

        private void DetailsLecon_Load(object sender, EventArgs e)
        {
            txtLibelle.Text = lecon.libelle;
            txtDateAjoute.Text = lecon.dateAjoute.ToLongDateString();
            txtNomUtilisateur.Text = lecon.Utilisateur.nom + ' ' + lecon.Utilisateur.prenom;
            txtLecon.Text = lecon.textLecon;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
           metroButton1.BackColor = Color.Red;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
