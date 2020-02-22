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
            txtMatiere.Text = lecon.Matiere.libelle;
            
            string[] words = lecon.textLecon.Split(' ');
            string text = "";
            for(int i = 0; i < words.Length; i++)
            {
                if (text.Length + words[i].Length > 76)
                {
                    text += '\n';
                    txtLecon.Text += text;
                    text = "";
                }
                text += words[i] + " ";
            }
            txtLecon.Text += text;
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
            this.Close();
        }

        private void txtLibelle_Click(object sender, EventArgs e)
        {

        }

        private void txtNomUtilisateur_Click(object sender, EventArgs e)
        {

        }

        private void txtDateAjoute_Click(object sender, EventArgs e)
        {

        }

        private void txtLecon_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblModele_Click(object sender, EventArgs e)
        {

        }
    }
}
