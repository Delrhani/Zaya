﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zaya.Properties;

namespace Zaya.Controls
{
    public partial class ModifierProfil : UserControl
    {
        private Utilisateur utilisateur;
        private bool isVisible = false;
        public ModifierProfil(Utilisateur utilisateur)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez-vous vraiment valider les changement ?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                utilisateur.email = this.txt_email.Text;
                utilisateur.prenom = this.txt_prenom.Text;
                utilisateur.nom = this.txt_nom.Text;
                utilisateur.telephone = this.txt_phone.Text;
                utilisateur.username = this.txt_username.Text;
                if (utilisateur.sexe == 'F')
                {
                    utilisateur.sexe = 'M';
                }
                DataBaseConfiguration.Context.SubmitChanges();
            }
        }

        private void ConsulterUtilisateur_Load(object sender, EventArgs e)
        {
            this.txt_email.Text = utilisateur.email;
            this.txt_prenom.Text = utilisateur.prenom;
            this.txt_nom.Text = utilisateur.nom;
            this.txt_phone.Text = utilisateur.telephone;
            this.txt_username.Text = utilisateur.username;
            this.txt_password.Text = utilisateur.pwd.ToString();
            if(utilisateur.sexe == 'F')
            {
                rdFemme.Checked = true;
            }
        }

        private void passwordStatut_Click(object sender, EventArgs e)
        {
            isVisible = !isVisible;
            if (isVisible)
            {
                passwordStatut.Image = Resources.hidePassword;
                txt_password.PasswordChar = '\0';
            }
            else
            {
                passwordStatut.Image = Resources.showPassword;
                txt_password.PasswordChar = '•';
            }
        }

    }
}