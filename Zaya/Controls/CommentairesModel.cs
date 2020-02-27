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
    public partial class CommentairesModel : UserControl
    {
        private Lecon lecon;
        public CommentairesModel(Lecon lecon)
        {
            InitializeComponent();
            this.lecon = lecon;
        }

        private void LeconsModel_Load(object sender, EventArgs e)
        {
            int y = 0;
            var v = from c in DataBaseConfiguration.Context.Commentaire
                    orderby c.dateCommentaire
                    where c.idLecon == lecon.idLecon
                    select c;
            foreach (Commentaire c in v)
            {
                CommentaireModel commentaireModel = new CommentaireModel(c);
                Point p = commentaireModel.Location;
                p.Y = y;
                y += commentaireModel.Height + 5;
                commentaireModel.Location = p;
                panelContenu.Controls.Add(commentaireModel);
            }
        }

    }
}
