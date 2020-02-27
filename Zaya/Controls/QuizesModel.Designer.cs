namespace Zaya.Controls
{
    partial class QuizesModel
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
            this.panelContenu = new System.Windows.Forms.Panel();
            this.btnJouer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelContenu
            // 
            this.panelContenu.AutoScroll = true;
            this.panelContenu.Location = new System.Drawing.Point(3, 38);
            this.panelContenu.Name = "panelContenu";
            this.panelContenu.Size = new System.Drawing.Size(589, 447);
            this.panelContenu.TabIndex = 2;
            //
            // btnJouer
            // 
            this.btnJouer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnJouer.Location = new System.Drawing.Point(518, 3);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(43, 29);
            this.btnJouer.TabIndex = 2;
            this.btnJouer.Text = "+";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // QuizesModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnJouer);
            this.Controls.Add(this.panelContenu);
            this.Name = "QuizesModel";
            this.Size = new System.Drawing.Size(595, 488);
            this.Load += new System.EventHandler(this.LeconsModel_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenu;
        private System.Windows.Forms.Button btnJouer;
    }
}
