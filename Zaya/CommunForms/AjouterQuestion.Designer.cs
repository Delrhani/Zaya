namespace Zaya.CommunForms
{
    partial class AjouterQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterQuestion));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnValider = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matière :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Leçon : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Question : ";
            // 
            // cmbMatiere
            // 
            this.cmbMatiere.FormattingEnabled = true;
            this.cmbMatiere.Location = new System.Drawing.Point(136, 97);
            this.cmbMatiere.Name = "cmbMatiere";
            this.cmbMatiere.Size = new System.Drawing.Size(290, 21);
            this.cmbMatiere.TabIndex = 3;
            this.cmbMatiere.SelectedIndexChanged += new System.EventHandler(this.cmbMatiere_SelectedIndexChanged);
            // 
            // cmbLecon
            // 
            this.cmbLecon.FormattingEnabled = true;
            this.cmbLecon.Location = new System.Drawing.Point(136, 124);
            this.cmbLecon.Name = "cmbLecon";
            this.cmbLecon.Size = new System.Drawing.Size(290, 21);
            this.cmbLecon.TabIndex = 4;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(136, 151);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(290, 20);
            this.txtQuestion.TabIndex = 5;
            // 
            // txtReponse
            // 
            this.txtReponse.Location = new System.Drawing.Point(136, 177);
            this.txtReponse.Name = "txtReponse";
            this.txtReponse.Size = new System.Drawing.Size(290, 20);
            this.txtReponse.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reponse : ";
            // 
            // valide
            // 
            this.valide.AutoSize = true;
            this.valide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valide.Location = new System.Drawing.Point(136, 203);
            this.valide.Name = "valide";
            this.valide.Size = new System.Drawing.Size(72, 20);
            this.valide.TabIndex = 8;
            this.valide.Text = "Valide";
            this.valide.UseVisualStyleBackColor = true;
            // 
            // listeReponse
            // 
            this.listeReponse.FormattingEnabled = true;
            this.listeReponse.Location = new System.Drawing.Point(136, 250);
            this.listeReponse.Name = "listeReponse";
            this.listeReponse.Size = new System.Drawing.Size(290, 169);
            this.listeReponse.TabIndex = 9;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(351, 203);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 28);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.panel1.Location = new System.Drawing.Point(-1, 474);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 16);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.panel2.Location = new System.Drawing.Point(0, 463);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 4);
            this.panel2.TabIndex = 12;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(351, 425);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 32);
            this.btnValider.TabIndex = 14;
            this.btnValider.Text = "Valider";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AjouterQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 490);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
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
            this.Name = "AjouterQuestion";
            this.Text = "AjouterQuestion";
            this.Load += new System.EventHandler(this.AjouterQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton btnValider;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}