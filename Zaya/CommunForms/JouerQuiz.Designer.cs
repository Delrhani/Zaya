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
            this.tempEstime = new Bunifu.Framework.UI.BunifuProgressBar();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.panelReponse = new System.Windows.Forms.Panel();
            this.txtQuestion = new System.Windows.Forms.Label();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.score = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tempEstime
            // 
            this.tempEstime.BackColor = System.Drawing.Color.White;
            this.tempEstime.BorderRadius = 5;
            this.tempEstime.Location = new System.Drawing.Point(12, 9);
            this.tempEstime.MaximumValue = 100;
            this.tempEstime.Name = "tempEstime";
            this.tempEstime.ProgressColor = System.Drawing.Color.Teal;
            this.tempEstime.Size = new System.Drawing.Size(575, 10);
            this.tempEstime.TabIndex = 2;
            this.tempEstime.Value = 100;
            this.tempEstime.progressChanged += new System.EventHandler(this.tempEstime_progressChanged);
            // 
            // panelQuestion
            // 
            this.panelQuestion.Controls.Add(this.panelReponse);
            this.panelQuestion.Controls.Add(this.txtQuestion);
            this.panelQuestion.Controls.Add(this.score);
            this.panelQuestion.Location = new System.Drawing.Point(12, 25);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(575, 213);
            this.panelQuestion.TabIndex = 3;
            // 
            // panelReponse
            // 
            this.panelReponse.Location = new System.Drawing.Point(3, 25);
            this.panelReponse.Name = "panelReponse";
            this.panelReponse.Size = new System.Drawing.Size(500, 185);
            this.panelReponse.TabIndex = 1;
            // 
            // txtQuestion
            // 
            this.txtQuestion.AutoSize = true;
            this.txtQuestion.Location = new System.Drawing.Point(162, 9);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(156, 13);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.Text = "Comment déclarer un variable ?";
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(512, 244);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(75, 23);
            this.btnSuivant.TabIndex = 4;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // score
            // 
            this.score.animated = false;
            this.score.animationIterval = 5;
            this.score.animationSpeed = 300;
            this.score.BackColor = System.Drawing.Color.White;
            this.score.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("score.BackgroundImage")));
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.SeaGreen;
            this.score.LabelVisible = true;
            this.score.LineProgressThickness = 8;
            this.score.LineThickness = 5;
            this.score.Location = new System.Drawing.Point(506, 25);
            this.score.Margin = new System.Windows.Forms.Padding(0);
            this.score.MaxValue = 100;
            this.score.Name = "score";
            this.score.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.score.ProgressColor = System.Drawing.Color.SeaGreen;
            this.score.Size = new System.Drawing.Size(69, 69);
            this.score.TabIndex = 1;
            this.score.Value = 0;
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // JouerQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 276);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.panelQuestion);
            this.Controls.Add(this.tempEstime);
            this.Name = "JouerQuiz";
            this.Text = "JouerQuiz";
            this.Load += new System.EventHandler(this.JouerQuiz_Load);
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar score;
        private Bunifu.Framework.UI.BunifuProgressBar tempEstime;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Label txtQuestion;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Panel panelReponse;
        private System.Windows.Forms.Timer timer;
    }
}