namespace Zaya.Controls
{
    partial class CommentairesModel
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
            this.SuspendLayout();
            // 
            // panelContenu
            // 
            this.panelContenu.AutoScroll = true;
            this.panelContenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenu.Location = new System.Drawing.Point(0, 0);
            this.panelContenu.Name = "panelContenu";
            this.panelContenu.Size = new System.Drawing.Size(771, 144);
            this.panelContenu.TabIndex = 2;
            // 
            // CommentairesModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelContenu);
            this.Name = "CommentairesModel";
            this.Size = new System.Drawing.Size(771, 144);
            this.Load += new System.EventHandler(this.LeconsModel_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenu;
    }
}
