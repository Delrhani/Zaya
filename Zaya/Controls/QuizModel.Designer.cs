namespace Zaya.Controls
{
    partial class QuizModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizModel));
            this.txtMatiere = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.score = new CircularProgressBar.CircularProgressBar();
            this.txtTempEstime = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMatiere
            // 
            this.txtMatiere.AutoSize = true;
            this.txtMatiere.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatiere.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMatiere.Location = new System.Drawing.Point(94, 10);
            this.txtMatiere.Name = "txtMatiere";
            this.txtMatiere.Size = new System.Drawing.Size(86, 31);
            this.txtMatiere.TabIndex = 0;
            this.txtMatiere.Text = "label1";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDate.Location = new System.Drawing.Point(132, 41);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(263, 23);
            this.txtDate.TabIndex = 2;
            this.txtDate.Text = "aaaaaaaaaaaabbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbaaaaaaaaaaaavvvvv4vv";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.score);
            this.groupBox1.Controls.Add(this.txtTempEstime);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Controls.Add(this.txtMatiere);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 89);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // score
            // 
            this.score.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.score.AnimationSpeed = 500;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.score.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.score.InnerMargin = 2;
            this.score.InnerWidth = -1;
            this.score.Location = new System.Drawing.Point(422, 5);
            this.score.Margin = new System.Windows.Forms.Padding(0);
            this.score.MarqueeAnimationSpeed = 2000;
            this.score.Name = "score";
            this.score.OuterColor = System.Drawing.Color.Gray;
            this.score.OuterMargin = -25;
            this.score.OuterWidth = 26;
            this.score.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(184)))), ((int)(((byte)(201)))));
            this.score.ProgressWidth = 5;
            this.score.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.score.Size = new System.Drawing.Size(75, 75);
            this.score.StartAngle = 90;
            this.score.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.score.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.score.SubscriptText = "";
            this.score.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.score.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.score.SuperscriptText = "";
            this.score.TabIndex = 5;
            this.score.Text = "100%";
            this.score.TextMargin = new System.Windows.Forms.Padding(0);
            this.score.Value = 68;
            // 
            // txtTempEstime
            // 
            this.txtTempEstime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempEstime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTempEstime.Location = new System.Drawing.Point(132, 63);
            this.txtTempEstime.Name = "txtTempEstime";
            this.txtTempEstime.Size = new System.Drawing.Size(263, 23);
            this.txtTempEstime.TabIndex = 4;
            this.txtTempEstime.Text = "aaaaaaaaaaaabbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbaaaaaaaaaaaavvvvv4vv";
            // 
            // btnModifier
            // 
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.Location = new System.Drawing.Point(521, 34);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(37, 31);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "...";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // QuizModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "QuizModel";
            this.Size = new System.Drawing.Size(564, 92);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtMatiere;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label txtTempEstime;
        private CircularProgressBar.CircularProgressBar score;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
