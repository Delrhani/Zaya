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
            this.custumProgresssBar1 = new Zaya.Controls.CustumProgresssBar();
            this.panelReponse = new System.Windows.Forms.Panel();
            this.txtQuestion = new System.Windows.Forms.Label();
            this.score = new Zaya.Controls.ProgressBarEx();
            this.btnSuivant = new System.Windows.Forms.Button();
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
            this.panelQuestion.Controls.Add(this.custumProgresssBar1);
            this.panelQuestion.Controls.Add(this.panelReponse);
            this.panelQuestion.Controls.Add(this.txtQuestion);
            this.panelQuestion.Controls.Add(this.score);
            this.panelQuestion.Location = new System.Drawing.Point(27, 61);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(533, 371);
            this.panelQuestion.TabIndex = 3;
            // 
            // custumProgresssBar1
            // 
            this.custumProgresssBar1.Location = new System.Drawing.Point(408, 97);
            this.custumProgresssBar1.Name = "custumProgresssBar1";
            this.custumProgresssBar1.Size = new System.Drawing.Size(110, 101);
            this.custumProgresssBar1.TabIndex = 2;
            // 
            // panelReponse
            // 
            this.panelReponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(184)))), ((int)(((byte)(201)))));
            this.panelReponse.Location = new System.Drawing.Point(29, 25);
            this.panelReponse.Name = "panelReponse";
            this.panelReponse.Size = new System.Drawing.Size(356, 281);
            this.panelReponse.TabIndex = 1;
            // 
            // txtQuestion
            // 
            this.txtQuestion.AutoSize = true;
            this.txtQuestion.Location = new System.Drawing.Point(153, 5);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(156, 13);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.Text = "Comment déclarer un variable ?";
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.Gainsboro;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.SeaGreen;
            this.score.Location = new System.Drawing.Point(408, 97);
            this.score.Margin = new System.Windows.Forms.Padding(0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(110, 101);
            this.score.TabIndex = 1;
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(222, 353);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(10, 10);
            this.btnSuivant.TabIndex = 4;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
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
            this.panel8.Controls.Add(this.panelQuestion);
            this.panel8.Controls.Add(this.tempEstime);
            this.panel8.Controls.Add(this.btnSuivant);
            this.panel8.Location = new System.Drawing.Point(146, 34);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(640, 442);
            this.panel8.TabIndex = 6;
            // 
            // tempEstime
            // 
            this.tempEstime.BackColor = System.Drawing.Color.White;
            this.tempEstime.Location = new System.Drawing.Point(27, 29);
            this.tempEstime.Name = "tempEstime";
            this.tempEstime.Size = new System.Drawing.Size(523, 10);
            this.tempEstime.TabIndex = 2;
            this.tempEstime.Value = 100;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(789, 0);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(39, 36);
            this.metroButton1.TabIndex = 7;
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
            this.Text = "JouerQuiz";
            this.Load += new System.EventHandler(this.JouerQuiz_Load);
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ProgressBarEx score;
        private Controls.ProgressBarEx tempEstime;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Label txtQuestion;
        private System.Windows.Forms.Button btnSuivant;
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
        private Controls.CustumProgresssBar custumProgresssBar1;
        private System.Windows.Forms.Panel panel8;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}