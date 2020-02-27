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
    public partial class CommentaireModel : UserControl
    {
        private Commentaire commentaire;
        public CommentaireModel(Commentaire commentaire)
        {
            this.commentaire = commentaire;
            InitializeComponent();
        }

        private void CommentaireModel_Load(object sender, EventArgs e)
        {
            this.txtCommentaire.Text = commentaire.textCommentaire;
            this.nomUtilisateur.Text = commentaire.Utilisateur.nom + " " + commentaire.Utilisateur.prenom;
            this.dateCommentaire.Text = commentaire.dateCommentaire.ToString();
        }
    }
}
