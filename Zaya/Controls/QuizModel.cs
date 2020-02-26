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
            
        }

        private void txtNomProfesseur_Click(object sender, EventArgs e)
        {

        }
    }
}
