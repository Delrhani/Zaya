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

        private Matiere matiere;
        private List<Question> questions;
        private int currentQuestion;
        private Quiz quiz;
        private int NBR_QUESTION = 2;
        private int nbrWrongQuestion = 0;
        private int nbrTrueQuestion = 0;
        private bool isEnought = true;
        
        // Enumeration to know the difficulty choosed by the user
        public enum Difficulte
        {
            Facile,
            Moyen,
            Difficile
        }

        // Initialize components
        public JouerQuiz(Utilisateur utilisateur, Matiere matiere, Difficulte difficulte)
        {
            InitializeComponent();
            this.matiere = matiere;
            currentQuestion = -1;
            questions = new List<Question>();
            quiz = new Quiz();
            quiz.score = 0;
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
            this.Activate();
        }

        // Method to start the quiz
        private void StartGame()
        {
            LoadQuestions();
            if(!isEnought)
            {
                this.Close();
            }
            else
            {
                timer.Start();
                NextQuestion();
            }
        }

        // Method to move to next question
        private void NextQuestion()
        {
            currentQuestion++;
            if (currentQuestion < questions.Count)
            {
                Question question = questions[currentQuestion];
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
                ShowResult();
            }
            else
            {
                timer.Stop();
                quiz.tempsEstime = TimeSpan.FromMilliseconds((timer.Interval / 10 * (1 - tempEstime.Value / 100.0)) * 1000);
                quiz.score = Math.Floor(quiz.score);
                SaveQuiz();
                Close();
            }
        }

        // Load NBR_QUESTION of questions from database random
        private void LoadQuestions()
        {
            var v = from q in DataBaseConfiguration.Context.Question
                    where q.Lecon.idMatiere == matiere.idMatiere
                    select q;
            List<Question> temp = v.ToList();
            if (NBR_QUESTION > temp.Count)
            {
                MessageBox.Show("Le nombre de question est insuffisant pour ce quiz", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isEnought = false;
                return;
            }
            for (int i = 0; i < NBR_QUESTION; i++)
            {
                Random rndGen = new Random();
                int random = rndGen.Next(0, temp.Count);
                questions.Add(temp.ElementAt(random));
                temp.RemoveAt(random);
            }
        }

        // Timer tick listener
        private void timer_Tick(object sender, EventArgs e)
        {
            tempEstime.Value -= 1;
            if (tempEstime.Value == 0)
            {
                MessageBox.Show("You lose in this quiz", "Lose Quiz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer.Stop();
            }
        }

        // Method to move to the next question
        private void btnQuestionSuivant_Click(object sender, EventArgs e)
        {
            Question question = null;
            if (currentQuestion >= 0)
            {
                question = questions[currentQuestion];
                ResultatQuiz resultat = new ResultatQuiz();
                resultat.Question = question;
                switch (question.TypeQuestion.libelle)
                {
                    case "text":
                        TextBox textBox = (TextBox)panelReponse.Controls[0];
                        if (question.Reponse[0].txtReponse.Equals(textBox.Text.Trim()))
                        {
                            nbrTrueQuestion++;
                            quiz.score += 1.0 / NBR_QUESTION * 100;
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
                                    quiz.score += (1.0 / (NBR_QUESTION * lsReponse.Items.Count)) * 100;
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
                                    quiz.score += 1.0 / NBR_QUESTION * 100;
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
                ShowResult();
                if(currentQuestion + 1 == NBR_QUESTION)
                {
                    MessageBox.Show("Game Ended");
                }
                NextQuestion();
            }

        }

        // Show the result in the interface
        private void ShowResult()
        {
            txtTrueQuestion.Text = "Passé " + (nbrWrongQuestion + nbrTrueQuestion) + " / " + questions.Count;
            txtWrongQuestion.Text = "Incorrect " + nbrWrongQuestion + " / " + questions.Count;
        }

        // Method to save a new record of the quiz
        private void SaveQuiz()
        {
            DataBaseConfiguration.Context.Quiz.InsertOnSubmit(quiz);
            DataBaseConfiguration.Context.SubmitChanges();
            this.Close();
        }

        // Enumeration to know the answer level if the high or medium or low
        private enum AnswerLevel
        {
            ALL,
            NOTHING,
            MEDIUM
        }

        // Method to show an alert after the answering to a question
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

        // Button close application
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JouerQuiz_Load(object sender, EventArgs e)
        {
            StartGame();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Voulez-vous vraiment quitter ce quiz ?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }
        Point lastPoint;
        private void JouerQuiz_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void JouerQuiz_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
