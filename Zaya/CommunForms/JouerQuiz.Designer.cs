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
            this.button1 = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.Label();
            this.panelReponse = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
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
            // 
            // panelQuestion
            // 
            this.panelQuestion.Controls.Add(this.panelReponse);
            this.panelQuestion.Controls.Add(this.txtQuestion);
            this.panelQuestion.Location = new System.Drawing.Point(12, 25);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(506, 213);
            this.panelQuestion.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Suivant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // panelReponse
            // 
            this.panelReponse.Location = new System.Drawing.Point(3, 25);
            this.panelReponse.Name = "panelReponse";
            this.panelReponse.Size = new System.Drawing.Size(500, 185);
            this.panelReponse.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(362, 244);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(521, 198);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(69, 69);
            this.bunifuCircleProgressbar1.TabIndex = 1;
            this.bunifuCircleProgressbar1.Value = 10;
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // JouerQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 276);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelQuestion);
            this.Controls.Add(this.tempEstime);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.Name = "JouerQuiz";
            this.Text = "JouerQuiz";
            this.Load += new System.EventHandler(this.JouerQuiz_Load);
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private Bunifu.Framework.UI.BunifuProgressBar tempEstime;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Label txtQuestion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelReponse;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer;
    }
}