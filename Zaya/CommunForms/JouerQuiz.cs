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
        private int NBR_QUESTION = 1;
        private int nbrWrongQuestion = 0;
        private int nbrTrueQuestion = 0;
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
            txtTrueQuestion.Text = "Passé " + (nbrWrongQuestion + nbrTrueQuestion) + " / " + NBR_QUESTION;
            txtWrongQuestion.Text = "Incorrect " + nbrWrongQuestion + " / " + NBR_QUESTION;
        }

        private void JouerQuiz_Load(object sender, EventArgs e)
        {
            var v = from q in DataBaseConfiguration.Context.Question
                    where q.Lecon.idMatiere == matiere.idMatiere
                    select q;
            List<Question> temp = v.ToList();
            if(NBR_QUESTION > temp.Count)
            {
                MessageBox.Show("Le nombre de question est insuffisant pour ce quiz", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnFermer.PerformClick();
            }
            for (int i = 0; i < NBR_QUESTION && i < temp.Count; i++)
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
                            nbrTrueQuestion++;
                            AlertQuestion(AnswerLevel.ALL);
                        } 
                        else
                        {
                            nbrWrongQuestion++;
                            AlertQuestion(AnswerLevel.NOTHING);
                        }

                        ReponseQuiz reponseQuiz = new ReponseQuiz();
                        reponseQuiz.textReponse = textBox.Text.Trim();
                        reponseQuiz.Reponse = question.Reponse[0];
                        resultat.ReponseQuiz.Add(reponseQuiz);
                        break;
                    case "multiple":
                        CheckedListBox lsReponse = (CheckedListBox)panelReponse.Controls[0];
                        bool hasValidAnswers = false;
                        bool hasInvalidAnswers = false;
                        for (int i = 0; i < lsReponse.Items.Count; i++)
                        {
                            if (lsReponse.GetItemChecked(i))
                            {
                                Reponse reponse = question.Reponse[i];
                                if(reponse.valider)
                                {
                                    hasValidAnswers = true;
                                }
                                else
                                {
                                    hasInvalidAnswers = true;
                                }
                                reponseQuiz = new ReponseQuiz();
                                reponseQuiz.Reponse = reponse;
                                resultat.ReponseQuiz.Add(reponseQuiz);
                            }
                        }
                        if(hasInvalidAnswers && hasInvalidAnswers)
                        {
                            nbrWrongQuestion++;
                            AlertQuestion(AnswerLevel.MEDIUM);
                        }
                        else if(hasValidAnswers)
                        {
                            nbrTrueQuestion++;
                            AlertQuestion(AnswerLevel.ALL);
                        }
                        else
                        {
                            nbrWrongQuestion++;
                            AlertQuestion(AnswerLevel.NOTHING);
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
                                    nbrTrueQuestion++;
                                    AlertQuestion(AnswerLevel.ALL);
                                }
                                else
                                {
                                    nbrWrongQuestion++;
                                    AlertQuestion(AnswerLevel.NOTHING);
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
            txtTrueQuestion.Text = "Passé " + (nbrWrongQuestion + nbrTrueQuestion) + " / " + NBR_QUESTION;
            txtWrongQuestion.Text = "Incorrect " + nbrWrongQuestion + " / " + NBR_QUESTION;
        }

        private void tempEstime_progressChanged(object sender, EventArgs e)
        {
            if (tempEstime.Value == 0)
            {
                MessageBox.Show("You lose in this quiz", "Lose Quiz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer.Stop();
            }
        }

        private enum AnswerLevel
        {
            ALL,
            NOTHING,
            MEDIUM
        }

        private void AlertQuestion(AnswerLevel level)
        {
            Form_Alert alert = new Form_Alert();
            Form_Alert.TypeMessage type = Form_Alert.TypeMessage.ERROR;
            string message = "Oops! Faire plus d'effort.";
            switch(level)
            {
                case AnswerLevel.ALL:
                    type = Form_Alert.TypeMessage.SUCCESS;
                    message = "Très bien! Vous êtes intelligent.";
                    break;
                case AnswerLevel.MEDIUM:
                    type = Form_Alert.TypeMessage.WARNING;
                    message = "Bien! Bon continuation.";
                    break;
            }
            alert.ShowAlert(message, type);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
