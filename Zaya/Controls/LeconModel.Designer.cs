namespace Zaya.Controls
{
    partial class LeconModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeconModel));
            this.txtTitle = new System.Windows.Forms.Label();
            this.txtNomProfesseur = new System.Windows.Forms.Label();
            this.txtLesson = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtTitle.Location = new System.Drawing.Point(6, 11);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(126, 46);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "label1";
            // 
            // txtNomProfesseur
            // 
            this.txtNomProfesseur.AutoSize = true;
            this.txtNomProfesseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomProfesseur.ForeColor = System.Drawing.Color.DimGray;
            this.txtNomProfesseur.Location = new System.Drawing.Point(38, 59);
            this.txtNomProfesseur.Name = "txtNomProfesseur";
            this.txtNomProfesseur.Size = new System.Drawing.Size(51, 20);
            this.txtNomProfesseur.TabIndex = 1;
            this.txtNomProfesseur.Text = "label2";
            // 
            // txtLesson
            // 
            this.txtLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLesson.Location = new System.Drawing.Point(6, 89);
            this.txtLesson.Name = "txtLesson";
            this.txtLesson.Size = new System.Drawing.Size(552, 75);
            this.txtLesson.TabIndex = 2;
            this.txtLesson.Text = resources.GetString("txtLesson.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.txtLesson);
            this.groupBox1.Controls.Add(this.txtNomProfesseur);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 310);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LeconModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "LeconModel";
            this.Size = new System.Drawing.Size(564, 310);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Label txtNomProfesseur;
        private System.Windows.Forms.Label txtLesson;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
