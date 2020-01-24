namespace Zaya.AdministrateurForms
{
    partial class ModifierMatiere
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
            this.btnValider = new MetroFramework.Controls.MetroButton();
            this.txtMatiere = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(265, 166);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 28);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            // 
            // txtMatiere
            // 
            this.txtMatiere.BackColor = System.Drawing.Color.White;
            this.txtMatiere.Depth = 0;
            this.txtMatiere.Hint = "Type Subject";
            this.txtMatiere.Location = new System.Drawing.Point(97, 125);
            this.txtMatiere.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMatiere.Name = "txtMatiere";
            this.txtMatiere.PasswordChar = '\0';
            this.txtMatiere.SelectedText = "";
            this.txtMatiere.SelectionLength = 0;
            this.txtMatiere.SelectionStart = 0;
            this.txtMatiere.Size = new System.Drawing.Size(243, 23);
            this.txtMatiere.TabIndex = 7;
            this.txtMatiere.UseSystemPasswordChar = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(160)))), ((int)(((byte)(61)))));
            this.panel3.Location = new System.Drawing.Point(-2, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 15);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(160)))), ((int)(((byte)(61)))));
            this.panel4.Location = new System.Drawing.Point(-1, 256);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 4);
            this.panel4.TabIndex = 8;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matière :";
            // 
            // ModifierMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtMatiere);
            this.Controls.Add(this.btnValider);
            this.Name = "ModifierMatiere";
            this.Text = "ModifierMatiere";
            this.Load += new System.EventHandler(this.ModifierMatiere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnValider;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMatiere;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
    }
}