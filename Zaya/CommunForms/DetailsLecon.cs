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
        private Utilisateur utilisateur;
        public DetailsLecon(Lecon lecon, Utilisateur utilisateur)
        {
            InitializeComponent();
            this.lecon = lecon;
            this.utilisateur = utilisateur;
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

            if(lecon.idUtilisateur != utilisateur.idUtilisateur && utilisateur.TypeUtilisateur.libelle != "Administrateur")
            {
                this.btnModifier.Visible = false;
            }
            LoadCommentaires();
        }

        private void LoadCommentaires()
        {
            panelCommentaires.Controls.Clear();
            panelCommentaires.Controls.Add(new Controls.CommentairesModel(lecon));
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

        private void btnAjouterCommentaire_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Voulez-vous vraiment ajouter ce commentaire ?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Commentaire commentaire = new Commentaire();
                commentaire.dateCommentaire = DateTime.Now;
                commentaire.Lecon = lecon;
                commentaire.textCommentaire = txtCommentaire.Text;
                commentaire.Utilisateur = utilisateur;
                DataBaseConfiguration.Context.Commentaire.InsertOnSubmit(commentaire);
                DataBaseConfiguration.Context.SubmitChanges();
                LoadCommentaires();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            new ModifierLecon(lecon).ShowDialog();
        }
    }
}
