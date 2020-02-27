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
    public partial class ModulesModel : UserControl
    {
        private bool hasPrivilages;
        public ModulesModel(bool hasPrivilages)
        {
            InitializeComponent();
            this.hasPrivilages = hasPrivilages;
            if (!hasPrivilages) btnAjouter.Visible = false;
        }

        private void LeconsModel_Load(object sender, EventArgs e)
        {
            LoadMatieres();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            new AdministrateurForms.AjouterMatiere().ShowDialog();
            LoadMatieres();
        }

        private void LoadMatieres()
        {
            int y = 0;
            var v = from l in DataBaseConfiguration.Context.Matiere
                    select l;
            foreach (Matiere m in v)
            {
                ModuleModel moduleModel = new ModuleModel(m, hasPrivilages);
                Point p = moduleModel.Location;
                p.Y = y;
                y += moduleModel.Height + 5;
                moduleModel.Location = p;
                panelContenu.Controls.Add(moduleModel);
            }
        }

    }
}
