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

namespace Zaya
{
    public partial class LoginForm : MaterialSkin.Controls.MaterialForm
    {
        private Thread thread;
        private Form frm;
        public LoginForm()
        {
            InitializeComponent();

            frm = null;
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            using (InscriptionForm If = new InscriptionForm())
            {
                If.ShowDialog();
            }
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
    }
}