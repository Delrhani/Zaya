﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin;

namespace Zaya.AdministrateurForms
{
    public partial class AjouterMatiere : Form
    {
        public AjouterMatiere()
        {
            InitializeComponent();
        }

        private void AjouterMatiere_Load(object sender, EventArgs e)
        {
            txtMatiere.Text = "Text";
            txtMatiere.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtMatiere.Text.Trim().Length > 0)
            {
                if(DialogResult.Yes == MessageBox.Show("Voulez-vous vraiment ajouter cette matière ?", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Matiere matiere = new Matiere();
                    matiere.libelle = txtMatiere.Text;
                    DataBaseConfiguration.Context.Matiere.InsertOnSubmit(matiere);
                    DataBaseConfiguration.Context.SubmitChanges();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Merci de saisir un nom à la matière", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnValider_MouseHover(object sender, EventArgs e)
        {
            btnValider.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void btnValider_MouseLeave(object sender, EventArgs e)
        {
            btnValider.BackColor = Color.Transparent;
        }

        private void btnAnnuler_MouseHover(object sender, EventArgs e)
        {
            btnAnnuler.BackColor = Color.DarkRed;
        }

        private void btnAnnuler_MouseLeave(object sender, EventArgs e)
        {
            btnAnnuler.BackColor = Color.Transparent;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;
        private void AjouterMatiere_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void AjouterMatiere_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
