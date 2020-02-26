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
        private Lecon lecon;
        public AjouterQuestion(Lecon l = null)
        {
            InitializeComponent();
            this.lecon = l;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtReponse.Text.Trim().Length > 0)
            {
                listeReponse.Items.Add(txtReponse.Text, valide.Checked);
            }
            else
            {
                MessageBox.Show("Merci de saisir la reponse", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AjouterQuestion_Load(object sender, EventArgs e)
        {
            var resultat = from m in DataBaseConfiguration.Context.Matiere
                           select new { m.libelle, m.idMatiere };
            cmbMatiere.DisplayMember = "libelle";
            cmbMatiere.ValueMember = "idMatiere";
            cmbMatiere.DataSource = resultat;
            if(lecon != null)
            {
                cmbMatiere.SelectedValue = lecon.idMatiere;
            }
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
                    question.idTypeQuestion = (from t in DataBaseConfiguration.Context.TypeQuestion
                                              where t.libelle == "text"
                                              select new { t.idTypeQuestion }).First().idTypeQuestion; 
                }
                else
                {
                    if(listeReponse.CheckedItems.Count == 1)
                    {
                        question.idTypeQuestion = (from t in DataBaseConfiguration.Context.TypeQuestion
                                                   where t.libelle == "single"
                                                   select new { t.idTypeQuestion }).First().idTypeQuestion;
                    }
                    else
                    {
                        question.idTypeQuestion = (from t in DataBaseConfiguration.Context.TypeQuestion
                                                   where t.libelle == "multiple"
                                                   select new { t.idTypeQuestion }).First().idTypeQuestion;
                    }
                }
                foreach(var v in listeReponse.Items)
                {
                    Reponse reponse = new Reponse();
                    reponse.txtReponse = v.ToString();
                    reponse.valider = listeReponse.GetItemChecked(listeReponse.Items.IndexOf(v));
                    question.Reponse.Add(reponse);
                }
                DataBaseConfiguration.Context.Question.InsertOnSubmit(question);
                DataBaseConfiguration.Context.SubmitChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please add a question", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Close_MouseHover(object sender, EventArgs e)
        {
            metroButton1.BackColor = Color.Red;
        }

        private void cmbMatiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            var resultat = from l in DataBaseConfiguration.Context.Lecon
                           where l.idMatiere == (int) cmbMatiere.SelectedValue
                           select new { l.libelle, l.idLecon };
            cmbLecon.DisplayMember = "libelle";
            cmbLecon.ValueMember = "idLecon";
            cmbLecon.DataSource = resultat;
            if(lecon != null) 
            {
                cmbLecon.SelectedValue = lecon.idLecon;
            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbLecon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
