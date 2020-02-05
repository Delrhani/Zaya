namespace Zaya.CommunForms
{
    partial class ModifierQuestion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMatiere = new System.Windows.Forms.ComboBox();
            this.cmbLecon = new System.Windows.Forms.ComboBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtReponse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.valide = new System.Windows.Forms.CheckBox();
            this.listeReponse = new System.Windows.Forms.CheckedListBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matière :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Leçon : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Question : ";
            // 
            // cmbMatiere
            // 
            this.cmbMatiere.FormattingEnabled = true;
            this.cmbMatiere.Location = new System.Drawing.Point(84, 28);
            this.cmbMatiere.Name = "cmbMatiere";
            this.cmbMatiere.Size = new System.Drawing.Size(256, 21);
            this.cmbMatiere.TabIndex = 3;
            this.cmbMatiere.SelectedIndexChanged += new System.EventHandler(this.cmbMatiere_SelectedIndexChanged);
            // 
            // cmbLecon
            // 
            this.cmbLecon.FormattingEnabled = true;
            this.cmbLecon.Location = new System.Drawing.Point(84, 55);
            this.cmbLecon.Name = "cmbLecon";
            this.cmbLecon.Size = new System.Drawing.Size(256, 21);
            this.cmbLecon.TabIndex = 4;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(84, 82);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(256, 20);
            this.txtQuestion.TabIndex = 5;
            // 
            // txtReponse
            // 
            this.txtReponse.Location = new System.Drawing.Point(84, 108);
            this.txtReponse.Name = "txtReponse";
            this.txtReponse.Size = new System.Drawing.Size(256, 20);
            this.txtReponse.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reponse : ";
            // 
            // valide
            // 
            this.valide.AutoSize = true;
            this.valide.Location = new System.Drawing.Point(84, 134);
            this.valide.Name = "valide";
            this.valide.Size = new System.Drawing.Size(55, 17);
            this.valide.TabIndex = 8;
            this.valide.Text = "Valide";
            this.valide.UseVisualStyleBackColor = true;
            // 
            // listeReponse
            // 
            this.listeReponse.FormattingEnabled = true;
            this.listeReponse.Location = new System.Drawing.Point(23, 163);
            this.listeReponse.Name = "listeReponse";
            this.listeReponse.Size = new System.Drawing.Size(317, 154);
            this.listeReponse.TabIndex = 9;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(265, 134);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(265, 323);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 11;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // ModifierQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 352);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.listeReponse);
            this.Controls.Add(this.valide);
            this.Controls.Add(this.txtReponse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.cmbLecon);
            this.Controls.Add(this.cmbMatiere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifierQuestion";
            this.Text = "AjouterQuestion";
            this.Load += new System.EventHandler(this.AjouterQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMatiere;
        private System.Windows.Forms.ComboBox cmbLecon;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtReponse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox valide;
        private System.Windows.Forms.CheckedListBox listeReponse;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnValider;
    }
}