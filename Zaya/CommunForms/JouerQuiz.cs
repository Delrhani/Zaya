using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Data.Objects.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaya.CommunForms
{
    public partial class JouerQuiz : Form
    {
        private Utilisateur utilisateur;
        private Matiere matiere;
        private List<Question> questions;
        private int currentQuestion;
        private int time;
        
        public JouerQuiz(Utilisateur utilisateur, Matiere matiere)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
            this.matiere = matiere;
            currentQuestion = 0;
            questions = new List<Question>();
        }

        private void JouerQuiz_Load(object sender, EventArgs e)
        {
            var v = from q in DataBaseConfiguration.Context.Questions
                    where q.Lecon.idMatiere == matiere.idMatiere
                    select q;
            List<Question> temp = v.ToList();
            for (int i = 0; i < 2; i++)
            {
                var rndGen = new Random();
                int random = rndGen.Next(0, temp.Count);
                questions.Add(temp.ElementAt(random));
                temp.RemoveAt(random);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            time = 30;
            if (currentQuestion != 0)
            {
                button1.PerformClick();
            }
            else
            {
                Question question = questions[currentQuestion];
                txtQuestion.Text = question.textQuestion;
                switch(question.TypeQuestion.libelle)
                {
                    case "text":
                        break;
                    case "multiple":
                        panelReponse.Controls.Clear();
                        CheckedListBox listReponse = new CheckedListBox();
                        
                        foreach(Reponse r in question.Reponses)
                        {
                            listReponse.Items.Add(r.txtReponse, false);
                        }
                        listReponse.Dock = DockStyle.Fill;
                        panelReponse.Controls.Add(listReponse);
                        break;
                    case "single":
                        break;
                }
            }
            timer.Start();
            currentQuestion++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
            time = 30;
            Question question = questions[currentQuestion];
            txtQuestion.Text = question.textQuestion;
            switch (question.TypeQuestion.libelle)
            {
                case "text":
                    break;
                case "multiple":
                    panelReponse.Controls.Clear();
                    CheckedListBox listReponse = new CheckedListBox();

                    foreach (Reponse r in question.Reponses)
                    {
                        listReponse.Items.Add(r.txtReponse, false);
                    }
                    listReponse.Dock = DockStyle.Fill;
                    panelReponse.Controls.Add(listReponse);
                    break;
                case "single":
                    break;
            }
            currentQuestion++;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (time != 0)
            {
                time--;
                tempEstime.Value = (time * timer.Interval * 1000) % 100;
            }
            else
            {

            }
        }
    }
}
