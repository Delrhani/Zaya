using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaya.Controls
{
    public partial class UtilisateurModel : UserControl
    {
        private Utilisateur utilisateur;
        /*private string title;
        private string professeurName;
        private string lesson;

        public string Title
        {
            get 
            {
                return title;
            }
            set 
            {
                value = value.Substring(0, 65);
                value = value.Substring(0, value.LastIndexOf(' '));
                title = value;

                BindingData();
            }
        }

        public string Lesson
        {
            get { return lesson; }
            set
            {
                lesson = value;
                BindingData();
            }
        }

        public string ProfesseurName
        {
            get { return professeurName; }
            set
            {
                professeurName = value;
                BindingData();
            }
        }

        public LeconModel(string title, string professeurName, string lesson) : this()
        {
            Title = title;
            ProfesseurName = professeurName;
            Lesson = lesson;
        }

        public LeconModel()
        {
            InitializeComponent();
            BindingData();
        }

        private void BindingData()
        {
            this.txtTitle.Text = Title;
            this.txtNomProfesseur.Text = ProfesseurName;
            this.txtLesson.Text = Lesson;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }


        public Label TextTitle
        {
            get { return txtTitle; }
        }
        */
        public UtilisateurModel(Utilisateur utilisateur) : this()
        {
            this.utilisateur = utilisateur;
            BindingData();
        }

        public UtilisateurModel()
        {
            InitializeComponent();
        }

        private void BindingData()
        {
            this.txtNom.Text = utilisateur.nom + " " + utilisateur.prenom;
            this.txtEmail.Text = utilisateur.email;
            this.txtTelephone.Text = utilisateur.telephone;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            new AdministrateurForms.ConsulterUtilisateur(utilisateur).ShowDialog();
        }

        private void txtNomProfesseur_Click(object sender, EventArgs e)
        {

        }
    }
}
