namespace Zaya.UtilisateurForms
{
    partial class PagePrincipale
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
            this.customPanel1 = new Zaya.UI.CustomPanel();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.ColorBottom = System.Drawing.Color.Empty;
            this.customPanel1.ColorTop = System.Drawing.Color.Empty;
            this.customPanel1.Location = new System.Drawing.Point(12, 12);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(512, 181);
            this.customPanel1.TabIndex = 0;
            // 
            // PagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customPanel1);
            this.Name = "PagePrincipale";
            this.Text = "PagePrincipale";
            this.Load += new System.EventHandler(this.PagePrincipale_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.CustomPanel customPanel1;
    }
}