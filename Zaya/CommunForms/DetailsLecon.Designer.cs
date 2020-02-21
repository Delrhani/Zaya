namespace Zaya.CommunForms
{
    partial class DetailsLecon
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLibelle = new System.Windows.Forms.Label();
            this.txtNomUtilisateur = new System.Windows.Forms.Label();
            this.txtDateAjoute = new System.Windows.Forms.Label();
            this.txtLecon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLibelle
            // 
            this.txtLibelle.AutoSize = true;
            this.txtLibelle.Location = new System.Drawing.Point(53, 25);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(37, 13);
            this.txtLibelle.TabIndex = 0;
            this.txtLibelle.Text = "Libelle";
            // 
            // txtNomUtilisateur
            // 
            this.txtNomUtilisateur.AutoSize = true;
            this.txtNomUtilisateur.Location = new System.Drawing.Point(53, 58);
            this.txtNomUtilisateur.Name = "txtNomUtilisateur";
            this.txtNomUtilisateur.Size = new System.Drawing.Size(35, 13);
            this.txtNomUtilisateur.TabIndex = 1;
            this.txtNomUtilisateur.Text = "label2";
            // 
            // txtDateAjoute
            // 
            this.txtDateAjoute.AutoSize = true;
            this.txtDateAjoute.Location = new System.Drawing.Point(53, 106);
            this.txtDateAjoute.Name = "txtDateAjoute";
            this.txtDateAjoute.Size = new System.Drawing.Size(35, 13);
            this.txtDateAjoute.TabIndex = 2;
            this.txtDateAjoute.Text = "label3";
            // 
            // txtLecon
            // 
            this.txtLecon.AutoSize = true;
            this.txtLecon.Location = new System.Drawing.Point(55, 246);
            this.txtLecon.Name = "txtLecon";
            this.txtLecon.Size = new System.Drawing.Size(35, 13);
            this.txtLecon.TabIndex = 3;
            this.txtLecon.Text = "label4";
            // 
            // DetailsLecon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLecon);
            this.Controls.Add(this.txtDateAjoute);
            this.Controls.Add(this.txtNomUtilisateur);
            this.Controls.Add(this.txtLibelle);
            this.Name = "DetailsLecon";
            this.Text = "DetailsLecon";
            this.Load += new System.EventHandler(this.DetailsLecon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtLibelle;
        private System.Windows.Forms.Label txtNomUtilisateur;
        private System.Windows.Forms.Label txtDateAjoute;
        private System.Windows.Forms.Label txtLecon;
    }
}