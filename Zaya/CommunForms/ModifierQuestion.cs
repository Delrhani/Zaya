﻿using System;
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
    public partial class ModifierQuestion : Form
    {
        private Question question;
        public ModifierQuestion(Question question)
        {
            InitializeComponent();
            this.question = question;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
        }

        private void AjouterQuestion_Load(object sender, EventArgs e)
        {
            var resultat = from m in DataBaseConfiguration.Context.Matiere
                           select new { m.libelle, m.idMatiere };
            cmbMatiere.DisplayMember = "libelle";
            cmbMatiere.ValueMember = "idMatiere";
            cmbMatiere.DataSource = resultat;
            cmbMatiere.SelectedValue = question.Lecon.Matiere.idMatiere;
            cmbLecon.SelectedValue = question.idLecon;
            txtQuestion.Text = question.textQuestion;
            foreach(Reponse reponse in question.Reponse)
            {
                listeReponse.Items.Add(reponse.txtReponse, reponse.valider);
            }
        }

        private void cmbMatiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            
        }

        private void listeReponse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtReponse_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbLecon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var resultat = from l in DataBaseConfiguration.Context.Lecon
                           where l.idLecon == int.Parse(cmbMatiere.SelectedValue.ToString())
                           select new { l.libelle, l.idLecon };
            cmbLecon.DisplayMember = "libelle";
            cmbLecon.ValueMember = "idLecon";
            cmbLecon.DataSource = resultat;
        }

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {






































































        }

        private void valide_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            if (txtReponse.Text.Trim().Length > 0)
                listeReponse.Items.Add(txtReponse.Text, valide.Checked);
            else
                MessageBox.Show("Merci d'ajouter la reponce", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
            if (txtQuestion.Text.Trim().Length > 0)
            {
                Question question = new Question();
                question.idLecon = int.Parse(cmbLecon.SelectedValue.ToString());
                question.textQuestion = txtQuestion.Text;
                if (listeReponse.Items.Count == 0)
                {
                    MessageBox.Show("Please add one or more answers", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (listeReponse.Items.Count == 1)
                {
                    question.idTypeQuestion = (from t in DataBaseConfiguration.Context.TypeQuestion
                                               where t.libelle == "text"
                                               select new { t.idTypeQuestion }).First().idTypeQuestion;
                }
                else
                {
                    if (listeReponse.CheckedItems.Count == 1)
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
                foreach (var v in listeReponse.Items)
                {
                    Reponse reponse = new Reponse();
                    reponse.txtReponse = v.ToString();
                    reponse.valider = listeReponse.GetItemChecked(listeReponse.Items.IndexOf(v));
                    question.Reponse.Add(reponse);
                }
                DataBaseConfiguration.Context.Question.InsertOnSubmit(question);
                DataBaseConfiguration.Context.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Please add a question", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
