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
    public partial class MenuQuiz : Form
    {
        private Utilisateur utilisateur;
        public MenuQuiz(Utilisateur utilisateur)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
            cmbDifficulte.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Matiere matiere = (from m in DataBaseConfiguration.Context.Matiere
                               where m.idMatiere == (int)lsMatiere.SelectedValue
                               select m).First();
            JouerQuiz.Difficulte difficulte = JouerQuiz.Difficulte.Facile;
            if(cmbDifficulte.SelectedItem.ToString().Equals("Moyen"))
            {
                difficulte = JouerQuiz.Difficulte.Moyen;
            }
            else if(cmbDifficulte.SelectedItem.ToString().Equals("Difficile"))
            {
                difficulte = JouerQuiz.Difficulte.Difficile;
            }
            new JouerQuiz(utilisateur, matiere, difficulte).Show();
            this.Visible = false;
        }

        private void MenuQuiz_Load(object sender, EventArgs e)
        {
            var v = from m in DataBaseConfiguration.Context.Matiere
                    select new { m.idMatiere, m.libelle };
            lsMatiere.ValueMember = "idMatiere";
            lsMatiere.DisplayMember = "libelle";
            lsMatiere.DataSource = v;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
