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
        private Quiz quiz;
        private int NBR_QUESTION = 20;

        public enum Difficulte
        {
            Facile,
            Moyen,
            Difficile
        }

        public JouerQuiz(Utilisateur utilisateur, Matiere matiere, Difficulte difficulte)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
            this.matiere = matiere;
            currentQuestion = 0;
            questions = new List<Question>();
            quiz = new Quiz();
            quiz.Utilisateur = utilisateur;
            quiz.Matiere = matiere;
            quiz.dateQuiz = DateTime.Now;
            switch(difficulte)
            {
                case Difficulte.Difficile:
                    NBR_QUESTION = 300;
                    break;
                case Difficulte.Moyen:
                    NBR_QUESTION = 80;
                    break;
            }
        }

        private void JouerQuiz_Load(object sender, EventArgs e)
        {
            var v = from q in DataBaseConfiguration.Context.Question
                    where q.Lecon.idMatiere == matiere.idMatiere
                    select q;
            List<Question> temp = v.ToList();
            for (int i = 0; i < NBR_QUESTION; i++)
            {
                Random rndGen = new Random();
                int random = rndGen.Next(0, temp.Count);
                questions.Add(temp.ElementAt(random));
                temp.RemoveAt(random);
            }
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tempEstime.Value -= 1;
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            Question question = null;
            if (currentQuestion > 0)
            {
                question = questions[currentQuestion - 1];
                ResultatQuiz resultat = new ResultatQuiz();
                resultat.Question = question;
                switch (question.TypeQuestion.libelle)
                {
                    case "text":
                        TextBox textBox = (TextBox)panelReponse.Controls[0];
                        if (question.Reponse[0].txtReponse.Equals(textBox.Text.Trim()))
                        {
                            score.Value += 10;
                        }

                        ReponseQuiz reponseQuiz = new ReponseQuiz();
                        reponseQuiz.textReponse = textBox.Text.Trim();
                        reponseQuiz.Reponse = question.Reponse[0];
                        resultat.ReponseQuiz.Add(reponseQuiz);
                        break;
                    case "multiple":
                        CheckedListBox lsReponse = (CheckedListBox)panelReponse.Controls[0];
                        for (int i = 0; i < lsReponse.Items.Count; i++)
                        {
                            if (lsReponse.GetItemChecked(i))
                            {
                                Reponse reponse = question.Reponse[i];
                                if(reponse.valider)
                                {
                                    score.Value += (int) 10.0 / question.Reponse.Count(); 
                                }
                                reponseQuiz = new ReponseQuiz();
                                reponseQuiz.Reponse = reponse;
                                resultat.ReponseQuiz.Add(reponseQuiz);
                            }
                            else if(!question.Reponse[i].valider)
                            {
                                score.Value += (int)10.0 / question.Reponse.Count();
                            }
                        }
                        break;
                    case "single":
                        bool exists = false;
                        foreach (RadioButton rd in panelReponse.Controls)
                        {
                            if(rd.Checked)
                            {
                                reponseQuiz = new ReponseQuiz();
                                reponseQuiz.Reponse = question.Reponse.Where(temp => temp.idReponse == int.Parse(rd.Name)).First();
                                resultat.ReponseQuiz.Add(reponseQuiz);
                                if(int.Parse(rd.Name) == question.Reponse.Where(temp => temp.valider).First().idReponse)
                                {
                                    score.Value += 10;
                                }
                                exists = true;
                                break;
                            }
                        }
                        if(!exists)
                        {
                            MessageBox.Show("Merci de choisir une reponse", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                }
                quiz.ResultatQuiz.Add(resultat);
            }

            if (currentQuestion != questions.Count)
            {
                question = questions[currentQuestion++];
                txtQuestion.Text = question.textQuestion;
                switch (question.TypeQuestion.libelle)
                {
                    case "text":
                        panelReponse.Controls.Clear();
                        TextBox t = new TextBox();
                        t.Name = "reponse";
                        panelReponse.Controls.Add(t);
                        break;
                    case "multiple":
                        panelReponse.Controls.Clear();
                        CheckedListBox listReponseMultiple = new CheckedListBox();

                        foreach (Reponse r in question.Reponse)
                        {
                            listReponseMultiple.Items.Add(r.txtReponse, false);
                        }
                        listReponseMultiple.Dock = DockStyle.Fill;
                        listReponseMultiple.Name = "reponse";
                        panelReponse.Controls.Add(listReponseMultiple);
                        break;
                    case "single":
                        panelReponse.Controls.Clear();
                        List<RadioButton> listReponseSingle = new List<RadioButton>();
                        int y = 0;

                        foreach (Reponse r in question.Reponse)
                        {
                            RadioButton rd = new RadioButton();
                            rd.Location = new Point(rd.Location.X, y);
                            rd.Width = 400;
                            y += 20;
                            rd.Text = r.txtReponse;
                            rd.Name = r.idReponse.ToString();
                            listReponseSingle.Add(rd);
                        }
                        panelReponse.Controls.AddRange(listReponseSingle.ToArray());

                        break;
                }
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Opla");
                quiz.tempsEstime = TimeSpan.FromMilliseconds((timer.Interval / 10 * (1 - tempEstime.Value / 100.0))*1000);
                MessageBox.Show(quiz.tempsEstime.TotalSeconds.ToString());
                DataBaseConfiguration.Context.Quiz.InsertOnSubmit(quiz);
                DataBaseConfiguration.Context.SubmitChanges();
            }
        }

        private void tempEstime_progressChanged(object sender, EventArgs e)
        {
            if (tempEstime.Value == 0)
            {
                MessageBox.Show("You lose in this quiz", "Lose Quiz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer.Stop();
            }
        }

        private void JouerQuiz_Load_1(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
