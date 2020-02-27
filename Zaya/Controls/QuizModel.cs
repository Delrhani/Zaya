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
    public partial class QuizModel : UserControl
    {
        private Quiz quiz;
        
        public QuizModel(Quiz quiz) : this()
        {
            this.quiz = quiz;
            BindingData();
        }

        public QuizModel()
        {
            InitializeComponent();
        }

        private void BindingData()
        {
            this.txtDate.Text = quiz.dateQuiz.ToString();
            this.txtMatiere.Text = quiz.Matiere.libelle;
            this.txtTempEstime.Text = quiz.tempsEstime.ToString();
            score.Value = (int) quiz.score;
            score.Text = quiz.score + "%";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            CommunForms.QuizReport report = new CommunForms.QuizReport();
            report.SetDatabaseLogon("sa", "123456");
            Utilisateur utilisateur = quiz.Utilisateur;
            report.SetParameterValue("nom", utilisateur.nom);
            report.SetParameterValue("prenom", utilisateur.prenom);
            report.SetParameterValue("username", utilisateur.username);
            report.SetParameterValue("score", quiz.score + "%");
            report.SetParameterValue("dateQuiz", quiz.dateQuiz);
            report.SetParameterValue("libelle", quiz.Matiere.libelle);
            report.SetParameterValue("applicationPath", Application.StartupPath + "\\");
            CommunForms.QuizReportViewer viewer = new CommunForms.QuizReportViewer(report);
            viewer.Viewer.SelectionFormula = "{ Quiz.idQuiz } = " + quiz.idQuiz;

            viewer.ShowDialog();
        }

        private void txtNomProfesseur_Click(object sender, EventArgs e)
        {

        }
    }
}
