﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;


namespace Zaya
{
    public partial class LoginForm : Form
    {
        private Thread thread;
        private Form frm;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new InscriptionForm().ShowDialog();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Utilisateur utilisateur = connect();

            if (utilisateur == null)
            {
                MessageBox.Show("Le login ou le mot de passe est incorrect ", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (utilisateur.TypeUtilisateur.libelle)
            {
                case "Administrateur":
                    frm = new AdministrateurForms.PagePrincipale(utilisateur);
                    break;
                case "Utilisateur":
                    frm = new UtilisateurForms.PagePrincipale(utilisateur);
                    break;
            }
            this.Close();
            thread = new Thread(PagePricipale);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void PagePricipale(object obj)
        {
            Application.Run(frm);
        }


        private Utilisateur connect()
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            var personne = (from c in DataBaseConfiguration.Context.Utilisateur
                            where ((c.username.Equals(login) || c.telephone.Equals(login) || c.email.Equals(login)) && c.pwd.Equals(DataBaseConfiguration.Context.encrypt(password)))
                            select c);
            if (personne.Count() > 0)
                return personne.First();
            return null;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
