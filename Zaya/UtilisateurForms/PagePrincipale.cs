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

namespace Zaya.UtilisateurForms
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
            btnLesson_Click(null, null);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Voulez-vous vraiment fermer l'application ?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void btnLesson_Click(object sender, MouseEventArgs e)
        {
            panelLeft.Height = btnLesson.Height;
            panelLeft.Top = btnLesson.Top;
            txtNavigation.Text = "Leçons";
            
            panelContenu.Controls.Clear();
            panelContenu.Controls.Add(new LeconsModel(utilisateur));
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

        
        private void btnLesson_MouseHover(object sender, EventArgs e)
        {
            btnLesson.BackColor = HOVER_COLOR;
        }

        private void btnQuiz_MouseHover(object sender, EventArgs e)
        {
            btnQuiz.BackColor = HOVER_COLOR;
        }


        private void btnLesson_MouseLeave(object sender, EventArgs e)
        {
            btnLesson.BackColor = TRANSPARENT_COLOR;
        }

        private void btnQuiz_MouseLeave(object sender, EventArgs e)
        {
            btnQuiz.BackColor = TRANSPARENT_COLOR;
        }

        private void PagePricipale(object obj)
        {
            Application.Run(frm);
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

        private void btnDeconnecte_MouseLeave(object sender, EventArgs e)
        {
            btnDeconnecte.BackColor = TRANSPARENT_COLOR;
        }

        private void btnDeconnecte_MouseHover(object sender, EventArgs e)
        {
            btnDeconnecte.BackColor = TRANSPARENT_COLOR;
        }

        private void btnProfil_Click(object sender, MouseEventArgs e)
        {
            panelLeft.Height = btnProfil.Height;
            panelLeft.Top = btnProfil.Top;
            txtNavigation.Text = "Profil";
            panelContenu.Controls.Clear();
            panelContenu.Controls.Add(new ModifierProfil(utilisateur));
        }

        private void btnProfil_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnProfil_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
