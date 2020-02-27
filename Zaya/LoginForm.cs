using System;
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
using Zaya.Properties;

namespace Zaya
{
    public partial class LoginForm : Form
    {
        private Form frm;
        private bool isVisible = false;
        public LoginForm()
        {
            InitializeComponent();
            txtLogin.Hint = "Login";
            txtPassword.Hint = "Mot de passe";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new InscriptionForm().ShowDialog();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
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
            this.Activate();
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

        private void passwordStatut_Click(object sender, EventArgs e)
        {
            isVisible = !isVisible;
            if (isVisible)
            {
                passwordStatut.Image = Resources.hidePassword;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                passwordStatut.Image = Resources.showPassword;
                txtPassword.PasswordChar = '•';
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
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
            Thread thread = new Thread(PagePricipale);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void materialFlatButton1_MouseLeave(object sender, EventArgs e)
        {
            btn_Login.BackColor = Color.LightGray;
        }
        private void btn_Login_MouseHover(object sender, EventArgs e)
        {
            btn_Login.BackColor = Color.DarkGray;
        }
    }
}

