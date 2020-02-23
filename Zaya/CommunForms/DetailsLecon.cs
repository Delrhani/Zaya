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

        private void button1_MouseHover(object sender, EventArgs e)
        {
           metroButton1.BackColor = Color.Red;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            new AjouterQuestion(lecon).ShowDialog();
        }

    }
}
