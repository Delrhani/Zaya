using System;
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
    public partial class LeconsModel : UserControl
    {
        private Utilisateur utilisateur;
        public LeconsModel(Utilisateur utilisateur)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
        }

        private void LeconsModel_Load(object sender, EventArgs e)
        {
            var res = (from m in DataBaseConfiguration.Context.Matiere
                       select new { m.idMatiere, m.libelle }).ToList();
            res.Insert(0, new { idMatiere = 0, libelle = "Tout" });

            cmbMatieres.ValueMember = "idMatiere";
            cmbMatieres.DisplayMember = "libelle";
            cmbMatieres.DataSource = res;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            new CommunForms.AjouterLecon(utilisateur).ShowDialog();
        }

        private void cmbMatieres_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelContenu.Controls.Clear();
            InitListeLecon((int)cmbMatieres.SelectedValue);
        }

        private void InitListeLecon(int selectedValue)
        {
            int y = 0;
            var v = from l in DataBaseConfiguration.Context.Lecon
                    where selectedValue >= 1 ? l.idMatiere == selectedValue : l.idMatiere >= 1
                    select l;
            foreach (Lecon l in v)
            {
                LeconModel leconModel = new LeconModel(l);
                Point p = leconModel.Location;
                p.Y = y;
                y += leconModel.Height + 5;
                leconModel.Location = p;
                panelContenu.Controls.Add(leconModel);
            }
        }
    }
}
