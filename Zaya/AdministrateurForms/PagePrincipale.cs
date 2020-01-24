﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Zaya.AdministrateurForms
{
    public partial class PagePrincipale : MaterialSkin.Controls.MaterialForm
    {
        private Utilisateur administrateur;
        public PagePrincipale(Utilisateur utilisateur)
        {
            InitializeComponent();
            this.administrateur = utilisateur;
        }

        private void PagePrincipale_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to leave ?", "Confirmation message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                Environment.Exit(0);
            }
        }

        private void txtNomComplet_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLesson_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnQuiz_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void wd(object sender, PaintEventArgs e)
        {

        }

        private void btnModels_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnUnites_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnQuizPlayed_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void btnLesson_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            CommunForms.AjouterLecon ajouterLecon = new CommunForms.AjouterLecon(this.administrateur);
            ajouterLecon.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new CommunForms.AjouterLecon(administrateur).ShowDialog();
        }
    }
}
