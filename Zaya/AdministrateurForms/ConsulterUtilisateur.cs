using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zaya.Properties;

namespace Zaya.AdministrateurForms
{
    public partial class ConsulterUtilisateur : Form
    {
        private Utilisateur utilisateur;
        private bool isVisible = false;
        public ConsulterUtilisateur(Utilisateur utilisateur)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez-vous vraiment valider les changement ?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                utilisateur.email = this.txt_email.Text;
                utilisateur.prenom = this.txt_prenom.Text;
                utilisateur.nom = this.txt_nom.Text;
                utilisateur.telephone = this.txt_phone.Text;
                utilisateur.username = this.txt_username.Text;
                utilisateur.idTypeUtilisateur = (int)cmbTypeUtilisateur.SelectedValue;
                utilisateur.pwd = DataBaseConfiguration.Context.encrypt(txt_password.Text);
                if (utilisateur.sexe == 'F')
                {
                    utilisateur.sexe = 'M';
                }
                DataBaseConfiguration.Context.SubmitChanges();
            }
        }

        private void ConsulterUtilisateur_Load(object sender, EventArgs e)
        {
            cmbTypeUtilisateur.DisplayMember = "libelle";
            cmbTypeUtilisateur.ValueMember = "idTypeUtilisateur";
            cmbTypeUtilisateur.DataSource = from t in DataBaseConfiguration.Context.TypeUtilisateur
                                            select new { t.idTypeUtilisateur, t.libelle };
            cmbTypeUtilisateur.SelectedValue = utilisateur.idTypeUtilisateur;
            this.txt_email.Text = utilisateur.email;
            this.txt_prenom.Text = utilisateur.prenom;
            this.txt_nom.Text = utilisateur.nom;
            this.txt_phone.Text = utilisateur.telephone;
            this.txt_username.Text = utilisateur.username;
            this.txt_password.Text = utilisateur.pwd.ToString();
            if(utilisateur.sexe == 'F')
            {
                rdFemme.Checked = true;
            }
        }

        private void btnModifier_MouseHover(object sender, EventArgs e)
        {
            btnFermer.BackColor = Color.Black;
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordStatut_Click(object sender, EventArgs e)
        {
            isVisible = !isVisible;
            if (isVisible)
            {
                passwordStatut.Image = Resources.hidePassword;
                txt_password.PasswordChar = '\0';
            }
            else
            {
                passwordStatut.Image = Resources.showPassword;
                txt_password.PasswordChar = '•';
            }
        }
        Point lastPoint;
        private void ConsulterUtilisateur_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void ConsulterUtilisateur_MouseDown(object sender, MouseEventArgs e)
        {

            lastPoint = new Point(e.X, e.Y);
        }
    }
}
