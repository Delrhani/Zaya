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
    public partial class AjouterQuestion : Form
    {
        public AjouterQuestion()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtReponse.Text.Trim().Length > 0)
                listeReponse.Items.Add(txtReponse.Text, valide.Checked);
            else
                MessageBox.Show("Merci d'ajouter la reponce", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AjouterQuestion_Load(object sender, EventArgs e)
        {
            var resultat = from m in DataBaseConfiguration.Context.Matieres
                           select new { m.libelle, m.idMatiere };
            cmbMatiere.DisplayMember = "libelle";
            cmbMatiere.ValueMember = "idMatiere";
            cmbMatiere.DataSource = resultat;
        }

        private void cmbMatiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            var resultat = from l in DataBaseConfiguration.Context.Lecons
                           where l.idLecon == int.Parse(cmbMatiere.SelectedValue.ToString())
                           select new { l.libelle, l.idLecon };
            cmbLecon.DisplayMember = "libelle";
            cmbLecon.ValueMember = "idLecon";
            cmbLecon.DataSource = resultat;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(txtQuestion.Text.Trim().Length > 0)
            {
                Question question = new Question();
                question.idLecon = int.Parse(cmbLecon.SelectedValue.ToString());
                question.textQuestion = txtQuestion.Text;
                if(listeReponse.Items.Count == 0)
                {
                    MessageBox.Show("Please add one or more answers", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(listeReponse.Items.Count == 1)
                {
                    question.idTypeQuestion = (from t in DataBaseConfiguration.Context.TypeQuestions
                                              where t.libelle == "text"
                                              select new { t.idTypeQuestion }).First().idTypeQuestion; 
                }
                else
                {
                    if(listeReponse.CheckedItems.Count == 1)
                    {
                        question.idTypeQuestion = (from t in DataBaseConfiguration.Context.TypeQuestions
                                                   where t.libelle == "single"
                                                   select new { t.idTypeQuestion }).First().idTypeQuestion;
                    }
                    else
                    {
                        question.idTypeQuestion = (from t in DataBaseConfiguration.Context.TypeQuestions
                                                   where t.libelle == "multiple"
                                                   select new { t.idTypeQuestion }).First().idTypeQuestion;
                    }
                }
                foreach(var v in listeReponse.Items)
                {
                    Reponse reponse = new Reponse();
                    reponse.txtReponse = v.ToString();
                    reponse.valider = listeReponse.GetItemChecked(listeReponse.Items.IndexOf(v));
                    question.Reponses.Add(reponse);
                }
                DataBaseConfiguration.Context.Questions.InsertOnSubmit(question);
                DataBaseConfiguration.Context.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Please add a question", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
