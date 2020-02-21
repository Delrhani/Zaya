using System;
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
            var v = from l in DataBaseConfiguration.Context.Lecon
                    select l;
            panelContenu.Controls.Clear();
            int y = 0;
            foreach(Lecon l in v)
            {
                LeconModel leconModel = new LeconModel(l);
                Point p = leconModel.Location;
                p.Y = y;
                y += leconModel.Height + 5;
                leconModel.Location = p;
                panelContenu.Controls.Add(leconModel);
            }
        }

        private void btnQuiz_MouseClick(object sender, MouseEventArgs e)
        {
           panelLeft.Height = btnQuiz.Height;
            panelLeft.Top = btnQuiz.Top;
           txtNavigation.Text = "Quiz";

            HistoriqueQuiz hq = new HistoriqueQuiz();
            hq.ShowDialog();
        }

        private void btnModels_MouseClick(object sender, MouseEventArgs e)
        {
            panelLeft.Height = btnModels.Height;
            panelLeft.Top = btnModels.Top;
            txtNavigation.Text = "Modules";
            panelLeft.Height = btnUtilisateurs.Height;
            panelLeft.Top = btnUtilisateurs.Top;
            ListBox listBox = new ListBox();
            var v = from m in DataBaseConfiguration.Context.Matiere
                    select new { m.libelle, m.idMatiere };
            listBox.DisplayMember = "libelle";
            listBox.ValueMember = "idMatiere";
            listBox.DataSource = v;
            listBox.Dock = DockStyle.Fill;
            panelContenu.Controls.Clear();
            panelContenu.Controls.Add(listBox);
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
            ListBox listBox = new ListBox();
            var v = from u in DataBaseConfiguration.Context.Utilisateur
                    orderby u.TypeUtilisateur.idTypeUtilisateur
                    select new { nomComplet = u.nom + " " + u.prenom, u.idUtilisateur };
            listBox.DisplayMember = "nomComplet";
            listBox.ValueMember = "idUtilisateur";
            listBox.DataSource = v;
            listBox.Dock = DockStyle.Fill;
            panelContenu.Controls.Clear();
            panelContenu.Controls.Add(listBox);
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
            HistoriqueQuiz hq = new HistoriqueQuiz();
            hq.ShowDialog();
        }
    }
}
