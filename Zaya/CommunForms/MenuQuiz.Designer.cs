namespace Zaya.CommunForms
{
    partial class MenuQuiz
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lsMatiere = new System.Windows.Forms.ComboBox();
            this.cmbDifficulte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(75, 70);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(141, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Lancer";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(75, 99);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(141, 23);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matière : ";
            // 
            // lsMatiere
            // 
            this.lsMatiere.FormattingEnabled = true;
            this.lsMatiere.Location = new System.Drawing.Point(75, 6);
            this.lsMatiere.Name = "lsMatiere";
            this.lsMatiere.Size = new System.Drawing.Size(225, 21);
            this.lsMatiere.TabIndex = 3;
            // 
            // cmbDifficulte
            // 
            this.cmbDifficulte.FormattingEnabled = true;
            this.cmbDifficulte.Items.AddRange(new object[] {
            "Facile",
            "Moyen",
            "Difficile"});
            this.cmbDifficulte.Location = new System.Drawing.Point(75, 33);
            this.cmbDifficulte.Name = "cmbDifficulte";
            this.cmbDifficulte.Size = new System.Drawing.Size(225, 21);
            this.cmbDifficulte.TabIndex = 5;
            this.cmbDifficulte.Text = "Facile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Difficulté : ";
            // 
            // MenuQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 140);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDifficulte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsMatiere);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnStart);
            this.Name = "MenuQuiz";
            this.Text = "MenuQuiz";
            this.Load += new System.EventHandler(this.MenuQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lsMatiere;
        private System.Windows.Forms.ComboBox cmbDifficulte;
        private System.Windows.Forms.Label label2;
    }
}