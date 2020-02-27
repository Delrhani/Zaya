namespace Zaya.CommunForms
{
    partial class JouerQuiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JouerQuiz));
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.panelReponse = new System.Windows.Forms.Panel();
            this.txtQuestion = new System.Windows.Forms.Label();
            this.btnQuestionSuivant = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtWrongQuestion = new System.Windows.Forms.Label();
            this.txtTrueQuestion = new System.Windows.Forms.Label();
            this.tempEstime = new Zaya.Controls.ProgressBarEx();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panelQuestion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuestion
            // 
            this.panelQuestion.Controls.Add(this.panelReponse);
            this.panelQuestion.Controls.Add(this.txtQuestion);
            this.panelQuestion.Location = new System.Drawing.Point(3, 61);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(685, 347);
            this.panelQuestion.TabIndex = 3;
            // 
            // panelReponse
            // 
            this.panelReponse.BackColor = System.Drawing.Color.Transparent;
            this.panelReponse.Location = new System.Drawing.Point(3, 60);
            this.panelReponse.Name = "panelReponse";
            this.panelReponse.Size = new System.Drawing.Size(679, 284);
            this.panelReponse.TabIndex = 1;
            // 
            // txtQuestion
            // 
            this.txtQuestion.AutoSize = true;
            this.txtQuestion.Location = new System.Drawing.Point(21, 26);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(156, 13);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.Text = "Comment déclarer un variable ?";
            // 
            // btnQuestionSuivant
            // 
            this.btnQuestionSuivant.Location = new System.Drawing.Point(512, 414);
            this.btnQuestionSuivant.Name = "btnQuestionSuivant";
            this.btnQuestionSuivant.Size = new System.Drawing.Size(167, 34);
            this.btnQuestionSuivant.TabIndex = 4;
            this.btnQuestionSuivant.Text = "Suivant";
            this.btnQuestionSuivant.UseVisualStyleBackColor = true;
            this.btnQuestionSuivant.Click += new System.EventHandler(this.btnQuestionSuivant_Click);
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 502);
            this.panel1.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(184)))), ((int)(((byte)(201)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(-6, 429);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(138, 4);
            this.panel6.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(0, -13);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(114, 4);
            this.panel7.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(184)))), ((int)(((byte)(201)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(-7, 443);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(138, 4);
            this.panel4.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, -13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(114, 4);
            this.panel5.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(184)))), ((int)(((byte)(201)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-8, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 4);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, -13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 4);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtWrongQuestion);
            this.panel8.Controls.Add(this.txtTrueQuestion);
            this.panel8.Controls.Add(this.panelQuestion);
            this.panel8.Controls.Add(this.tempEstime);
            this.panel8.Controls.Add(this.btnQuestionSuivant);
            this.panel8.Location = new System.Drawing.Point(134, 42);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(691, 460);
            this.panel8.TabIndex = 6;
            // 
            // txtWrongQuestion
            // 
            this.txtWrongQuestion.AutoSize = true;
            this.txtWrongQuestion.Location = new System.Drawing.Point(592, 13);
            this.txtWrongQuestion.Name = "txtWrongQuestion";
            this.txtWrongQuestion.Size = new System.Drawing.Size(93, 13);
            this.txtWrongQuestion.TabIndex = 6;
            this.txtWrongQuestion.Text = "Incorrect : 5 / 100";
            // 
            // txtTrueQuestion
            // 
            this.txtTrueQuestion.AutoSize = true;
            this.txtTrueQuestion.Location = new System.Drawing.Point(24, 13);
            this.txtTrueQuestion.Name = "txtTrueQuestion";
            this.txtTrueQuestion.Size = new System.Drawing.Size(80, 13);
            this.txtTrueQuestion.TabIndex = 5;
            this.txtTrueQuestion.Text = "Passé : 5 / 100";
            // 
            // tempEstime
            // 
            this.tempEstime.BackColor = System.Drawing.Color.White;
            this.tempEstime.Location = new System.Drawing.Point(27, 29);
            this.tempEstime.Name = "tempEstime";
            this.tempEstime.Size = new System.Drawing.Size(661, 10);
            this.tempEstime.TabIndex = 2;
            this.tempEstime.Value = 100;
            // 
            // metroButton1
            // 
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Location = new System.Drawing.Point(796, -1);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(32, 28);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "X";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // JouerQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(828, 502);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JouerQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.JouerQuiz_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JouerQuiz_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.JouerQuiz_MouseMove);
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.ProgressBarEx tempEstime;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Label txtQuestion;
        private System.Windows.Forms.Button btnQuestionSuivant;
        private System.Windows.Forms.Panel panelReponse;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label txtTrueQuestion;
        private System.Windows.Forms.Label txtWrongQuestion;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}