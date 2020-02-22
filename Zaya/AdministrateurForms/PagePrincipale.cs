﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zaya.Controls;

namespace Zaya.AdministrateurForms
{
    public partial class PagePrincipale : Form
    {
        private Color HOVER_COLOR = Color.FromArgb(30, 182, 201);
        private Color TRANSPARENT_COLOR = Color.Transparent;
        private Utilisateur utilisateur;
        private LoginForm frm;
        public PagePrincipale(Utilisateur utilisateur)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
            frm = new LoginForm();
            btnLesson.PerformLayout();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLesson_Click(object sender, MouseEventArgs e)
        {
            panelLeft.Height = btnLesson.Height;
            panelLeft.Top = btnLesson.Top;
            txtNavigation.Text = "Leçons";
            
            panelContenu.Controls.Clear();
            panelContenu.Controls.Add(new LeconsModel());
        }

        private void btnAjouterLecon(object sender, EventArgs e)
        {
            new CommunForms.AjouterLecon(utilisateur).ShowDialog();
        }

        private void btnQuiz_MouseClick(object sender, MouseEventArgs e)
        {
            panelLeft.Height = btnQuiz.Height;
            panelLeft.Top = btnQuiz.Top;
            txtNavigation.Text = "Quiz";
            panelContenu.Controls.Clear();
            Button btnJouerQuiz = new Button();
            btnJouerQuiz.Text = "+";
            btnJouerQuiz.Click += JouezQuizClick;
            panelContenu.Controls.Add(btnJouerQuiz);
        }

        private void JouezQuizClick(object sender, EventArgs e)
        {
            new CommunForms.MenuQuiz(utilisateur).ShowDialog();
        }

        private void btnModels_MouseClick(object sender, MouseEventArgs e)
        {
            panelLeft.Height = btnModels.Height;
            panelLeft.Top = btnModels.Top;
            txtNavigation.Text = "Matières";

            panelContenu.Controls.Clear();

            int y = 0;
            Button btnAjouter = new Button();
            btnAjouter.Text = "+";
            
            Point p = btnAjouter.Location;
            p.X = panelContenu.Width - btnAjouter.Width - 50;
            btnAjouter.Location = p;
            y += p.Y + 20;
            btnAjouter.Click += (s, e1) => {
                new AjouterMatiere().ShowDialog();
            };
            panelContenu.Controls.Add(btnAjouter);

            var matieres = from m in DataBaseConfiguration.Context.Matiere
                           select m;
            foreach (Matiere m in matieres)
            {
                ModuleModel leconModel = new ModuleModel(m, true);
                p = leconModel.Location;
                p.Y = y;
                y += leconModel.Height + 5;
                leconModel.Location = p;
                panelContenu.Controls.Add(leconModel);
            }
        }

        private void btnLesson_MouseHover(object sender, EventArgs e)
        {
            btnLesson.BackColor = HOVER_COLOR;
        }

        private void btnQuiz_MouseHover(object sender, EventArgs e)
        {
            btnQuiz.BackColor = HOVER_COLOR;
        }

        private void btnModels_MouseHover(object sender, EventArgs e)
        {
            btnModels.BackColor = HOVER_COLOR;
        }


        private void btnLesson_MouseLeave(object sender, EventArgs e)
        {
            btnLesson.BackColor = TRANSPARENT_COLOR;
        }

        private void btnQuiz_MouseLeave(object sender, EventArgs e)
        {
            btnQuiz.BackColor = TRANSPARENT_COLOR;
        }

        private void btnModels_MouseLeave(object sender, EventArgs e)
        {
            btnModels.BackColor = TRANSPARENT_COLOR;
        }

        private void PagePricipale(object obj)
        {
            Application.Run(frm);
        }

        private void btnUtilisateurs_MouseClick(object sender, MouseEventArgs e)
        {
            panelLeft.Height = btnUtilisateurs.Height;
            panelLeft.Top = btnUtilisateurs.Top;
            txtNavigation.Text = "Utilisateurs";

            panelContenu.Controls.Clear();

            int y = 0;

            var utilisateurs = from u in DataBaseConfiguration.Context.Utilisateur
                           select u;
            Point p = panelContenu.Location;
            foreach (Utilisateur u in utilisateurs)
            {
                UtilisateurModel utilisateurModel = new UtilisateurModel(u);
                p = utilisateurModel.Location;
                p.Y = y;
                y += utilisateurModel.Height + 5;
                utilisateurModel.Location = p;
                panelContenu.Controls.Add(utilisateurModel);
            }
        }

        private void btnDeconnecte_MouseClick(object sender, MouseEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Voulez-vous vraiment déconnecté ?", "Message de confirmtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
                Thread thread = new Thread(PagePricipale);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void btnUtilisateurs_MouseHover(object sender, EventArgs e)
        {
            btnUtilisateurs.BackColor = HOVER_COLOR;
        }

        private void btnUtilisateurs_MouseLeave(object sender, EventArgs e)
        {
            btnUtilisateurs.BackColor = TRANSPARENT_COLOR;
        }

        private void btnDeconnecte_MouseLeave(object sender, EventArgs e)
        {
            btnDeconnecte.BackColor = TRANSPARENT_COLOR;
        }

        private void btnDeconnecte_MouseHover(object sender, EventArgs e)
        {
            btnDeconnecte.BackColor = TRANSPARENT_COLOR;
        }

        private void btnLesson_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            
        }

    }
}
