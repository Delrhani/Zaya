﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaya.Controls
{
    public partial class LeconModel : UserControl
    {
        private Lecon lecon;
        /*private string title;
        private string professeurName;
        private string lesson;

        public string Title
        {
            get 
            {
                return title;
            }
            set 
            {
                value = value.Substring(0, 65);
                value = value.Substring(0, value.LastIndexOf(' '));
                title = value;

                BindingData();
            }
        }

        public string Lesson
        {
            get { return lesson; }
            set
            {
                lesson = value;
                BindingData();
            }
        }

        public string ProfesseurName
        {
            get { return professeurName; }
            set
            {
                professeurName = value;
                BindingData();
            }
        }

        public LeconModel(string title, string professeurName, string lesson) : this()
        {
            Title = title;
            ProfesseurName = professeurName;
            Lesson = lesson;
        }

        public LeconModel()
        {
            InitializeComponent();
            BindingData();
        }

        private void BindingData()
        {
            this.txtTitle.Text = Title;
            this.txtNomProfesseur.Text = ProfesseurName;
            this.txtLesson.Text = Lesson;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }


        public Label TextTitle
        {
            get { return txtTitle; }
        }
        */
        public LeconModel(Lecon lecon) : this()
        {
            this.lecon = lecon;
            BindingData();
        }

        public LeconModel()
        {
            InitializeComponent();
        }

        private void BindingData()
        {
            string value = lecon.textLecon;
            if (lecon.textLecon.Length > 60)
            {
                value = value.Substring(0, 60);
                value = value.Substring(0, value.LastIndexOf(' '));
            }
            this.txtTitle.Text = lecon.libelle;
            this.txtNomProfesseur.Text = lecon.Utilisateur.nom + ' ' + lecon.Utilisateur.prenom;
            this.txtLesson.Text = lecon.textLecon;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            new CommunForms.DetailsLecon(lecon).ShowDialog();
            /*
             aaaaaaaaaaaabbbbbbbbbbbbbbbbbbbbbbbbbbbbbbaaaaaaaaaaaavvvvv4vv
             */
        }

        private void txtNomProfesseur_Click(object sender, EventArgs e)
        {

        }
    }
}
