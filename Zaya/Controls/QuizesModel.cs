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
    public partial class QuizesModel : UserControl
    {
        private Utilisateur utilisateur;
        public QuizesModel(Utilisateur utilisateur)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
        }

        private void LeconsModel_Load(object sender, EventArgs e)
        {
            int y = 0;
            var v = from u in DataBaseConfiguration.Context.Quiz
                    where u.Utilisateur == utilisateur
                    select u;
            foreach (Quiz u in v)
            {
                QuizModel utilisateurModel = new QuizModel(u);
                Point p = utilisateurModel.Location;
                p.Y = y;
                y += utilisateurModel.Height + 5;
                utilisateurModel.Location = p;
                panelContenu.Controls.Add(utilisateurModel);
            }
        }

        private void panelContenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            new CommunForms.MenuQuiz(utilisateur).ShowDialog();
        }
    }
}
