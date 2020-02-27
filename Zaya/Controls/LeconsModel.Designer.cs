namespace Zaya.Controls
{
    partial class LeconsModel
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
            this.cmbMatieres = new MetroFramework.Controls.MetroComboBox();
            this.panelContenu = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbMatieres
            // 
            this.cmbMatieres.FormattingEnabled = true;
            this.cmbMatieres.ItemHeight = 23;
            this.cmbMatieres.Location = new System.Drawing.Point(375, 3);
            this.cmbMatieres.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.cmbMatieres.Name = "cmbMatieres";
            this.cmbMatieres.Size = new System.Drawing.Size(190, 29);
            this.cmbMatieres.TabIndex = 0;
            this.cmbMatieres.SelectedIndexChanged += new System.EventHandler(this.cmbMatieres_SelectedIndexChanged);
            // 
            // panelContenu
            // 
            this.panelContenu.AutoScroll = true;
            this.panelContenu.Location = new System.Drawing.Point(3, 38);
            this.panelContenu.Name = "panelContenu";
            this.panelContenu.Size = new System.Drawing.Size(589, 447);
            this.panelContenu.TabIndex = 2;

            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAjouter.Location = new System.Drawing.Point(326, 3);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(43, 29);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "+";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // LeconsModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelContenu);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cmbMatieres);
            this.Name = "LeconsModel";
            this.Size = new System.Drawing.Size(595, 488);
            this.Load += new System.EventHandler(this.LeconsModel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbMatieres;
        private System.Windows.Forms.Panel panelContenu;
        private System.Windows.Forms.Button btnAjouter;
    }
}
