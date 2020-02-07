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
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Matiere matiere = (from m in DataBaseConfiguration.Context.Matiere
                               where m.idMatiere == (int)lsMatiere.SelectedValue
                               select m).First();
            new JouerQuiz(utilisateur, matiere, JouerQuiz.Difficulte.Facile).Show();
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
    }
}
