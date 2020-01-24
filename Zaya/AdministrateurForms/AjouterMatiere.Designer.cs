namespace Zaya.AdministrateurForms
{
    partial class AjouterMatiere
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatiere = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matière :";
            // 
            // txtMatiere
            // 
            this.txtMatiere.Location = new System.Drawing.Point(66, 33);
            this.txtMatiere.Name = "txtMatiere";
            this.txtMatiere.Size = new System.Drawing.Size(243, 20);
            this.txtMatiere.TabIndex = 1;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(234, 59);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // AjouterMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 90);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtMatiere);
            this.Controls.Add(this.label1);
            this.Name = "AjouterMatiere";
            this.Text = "AjouterMatiere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatiere;
        private System.Windows.Forms.Button btnValider;
    }
}