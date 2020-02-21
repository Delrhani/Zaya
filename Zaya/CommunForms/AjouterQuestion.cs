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
        }

        private void cmbMatiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
            }
            else
            {
                MessageBox.Show("Please add a question", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAjouter_MouseHover(object sender, EventArgs e)
        {
            btnAjouter.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLecon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void listeReponse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnValider_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Close_MouseHover(object sender, EventArgs e)
        {
            btn_Close.BackColor = Color.Red;
        }

        private void valide_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_ForeColorChanged(object sender, EventArgs e)
        {
            
        }
    }
}
