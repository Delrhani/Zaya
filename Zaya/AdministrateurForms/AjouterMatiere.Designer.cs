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
            this.btnValider = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMatiere = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matière :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(265, 168);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 28);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.panel2.Location = new System.Drawing.Point(1, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 4);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.panel1.Location = new System.Drawing.Point(0, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 12);
            this.panel1.TabIndex = 3;
            // 
            // txtMatiere
            // 
            this.txtMatiere.BackColor = System.Drawing.Color.White;
            this.txtMatiere.Depth = 0;
            this.txtMatiere.Hint = "Type Subject";
            this.txtMatiere.Location = new System.Drawing.Point(98, 127);
            this.txtMatiere.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMatiere.Name = "txtMatiere";
            this.txtMatiere.PasswordChar = '\0';
            this.txtMatiere.SelectedText = "";
            this.txtMatiere.SelectionLength = 0;
            this.txtMatiere.SelectionStart = 0;
            this.txtMatiere.Size = new System.Drawing.Size(267, 23);
            this.txtMatiere.TabIndex = 4;
            this.txtMatiere.UseSystemPasswordChar = false;
            // 
            // AjouterMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(376, 274);
            this.Controls.Add(this.txtMatiere);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AjouterMatiere";
            this.Sizable = false;
            this.Text = "AjouterMatiere";
            this.Load += new System.EventHandler(this.AjouterMatiere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnValider;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMatiere;
    }
}