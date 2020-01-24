using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Zaya
{
    public partial class InscriptionForm : MaterialSkin.Controls.MaterialForm

    {
        public InscriptionForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Utilisateur utilisateur = connect();
            Form frm = null;
            if (utilisateur == null)
            {
                MessageBox.Show("Le login ou le mot de passe est incorrect ", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch(utilisateur.TypeUtilisateur.libelle)
            {
                case "Administrateur":
                    frm = new AdministrateurForms.PagePrincipale(utilisateur);
                    break;
                case "Utilisateur":
                    frm = new UtilisateurForms.PagePrincipale(utilisateur);
                    break;
            }
            frm.Show();
            this.Visible = false;
        }

        private Utilisateur connect()
        {
            /*string login = txtLogin.Text;
            string password = txtPassword.Text;
            var personne = (from c in DataBaseConfiguration.Context.Personnes
                        where ((c.username.Equals(login) || c.email.Equals(login)) && c.password.Equals(DataBaseConfiguration.Context.encrypt(password)))
                        select c);
            if(personne.Count() > 0)
                return personne.First();*/
            return null;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
          
        }

        private void btnValiderInscription_Click(object sender, EventArgs e)
        {
            try
            {
                Utilisateur ul = new Utilisateur();
                ul.dateInscription = DateTime.Now;
                if (txt_nom.Text.Trim().Length == 0)
                    throw new Exception("Your last name should be contain 4 characters");
                ul.nom = txt_nom.Text;

                if (txt_prenom.Text.Trim().Length == 0)
                    throw new Exception("Your first name should be contain 4 characters");
                ul.prenom = txt_prenom.Text;
                ///^[\.-)( ]*([0-9]{3})[\.-)( ]*([0-9]{3})[\.-)( ]*([0-9]{4})$/
                showMatch(txt_phone.Text, @"^(+212)[5-7][0-9]{8,8}");
                //throw new Exception("Your phone should be correct");
                ul.telephone = txt_phone.Text;
                ul.email = txt_email.Text;
                ul.username = txt_username.Text;
                if (rdHomme.Checked)
                    ul.sexe = 'M';
                else
                    ul.sexe = 'F';
                ul.pwd = DataBaseConfiguration.Context.encrypt(txt_password.Text);
                DataBaseConfiguration.Context.Utilisateurs.InsertOnSubmit(ul);
                //DataBaseConfiguration.Context.SubmitChanges();
                //this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            using (LoginForm lf = new LoginForm())
            {
                lf.ShowDialog();
            }
        }
        private static void showMatch(string text, string expr)
        {
            MatchCollection mc = Regex.Matches(text, expr);

            foreach (Match m in mc)
            {
                MessageBox.Show(m.ToString());
            }
        }
    }
}
