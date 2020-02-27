namespace Zaya.Controls
{
    partial class CommentaireModel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nomUtilisateur = new MetroFramework.Controls.MetroLabel();
            this.dateCommentaire = new MetroFramework.Controls.MetroLabel();
            this.txtCommentaire = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // nomUtilisateur
            // 
            this.nomUtilisateur.AutoSize = true;
            this.nomUtilisateur.Location = new System.Drawing.Point(25, 20);
            this.nomUtilisateur.Name = "nomUtilisateur";
            this.nomUtilisateur.Size = new System.Drawing.Size(81, 19);
            this.nomUtilisateur.TabIndex = 0;
            this.nomUtilisateur.Text = "metroLabel1";
            // 
            // dateCommentaire
            // 
            this.dateCommentaire.AutoSize = true;
            this.dateCommentaire.Location = new System.Drawing.Point(57, 51);
            this.dateCommentaire.Name = "dateCommentaire";
            this.dateCommentaire.Size = new System.Drawing.Size(81, 19);
            this.dateCommentaire.TabIndex = 1;
            this.dateCommentaire.Text = "metroLabel1";
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(3, 79);
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(608, 60);
            this.txtCommentaire.TabIndex = 2;
            this.txtCommentaire.Text = "metroLabel1";
            // 
            // CommentaireModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCommentaire);
            this.Controls.Add(this.dateCommentaire);
            this.Controls.Add(this.nomUtilisateur);
            this.Name = "CommentaireModel";
            this.Size = new System.Drawing.Size(614, 150);
            this.Load += new System.EventHandler(this.CommentaireModel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel nomUtilisateur;
        private MetroFramework.Controls.MetroLabel dateCommentaire;
        private MetroFramework.Controls.MetroLabel txtCommentaire;
    }
}
