namespace Zaya.Controls
{
    partial class HistoriqueQuiz
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
            this.historiqueLigne2 = new Zaya.Controls.HistoriqueLigne();
            this.historiqueLigne1 = new Zaya.Controls.HistoriqueLigne();
            this.btnValider = new ePOSOne.btnProduct.Button_WOC();
            this.historiqueLigne3 = new Zaya.Controls.HistoriqueLigne();
            this.SuspendLayout();
            // 
            // historiqueLigne2
            // 
            this.historiqueLigne2.Location = new System.Drawing.Point(0, 114);
            this.historiqueLigne2.Name = "historiqueLigne2";
            this.historiqueLigne2.Size = new System.Drawing.Size(492, 120);
            this.historiqueLigne2.TabIndex = 1;
            // 
            // historiqueLigne1
            // 
            this.historiqueLigne1.Location = new System.Drawing.Point(0, -1);
            this.historiqueLigne1.Name = "historiqueLigne1";
            this.historiqueLigne1.Size = new System.Drawing.Size(492, 115);
            this.historiqueLigne1.TabIndex = 0;
            // 
            // btnValider
            // 
            this.btnValider.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(155)))));
            this.btnValider.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(182)))), ((int)(((byte)(200)))));
            this.btnValider.FlatAppearance.BorderSize = 0;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(336, 414);
            this.btnValider.Name = "btnValider";
            this.btnValider.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnValider.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnValider.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnValider.Size = new System.Drawing.Size(115, 31);
            this.btnValider.TabIndex = 15;
            this.btnValider.Text = "Jouer Quiz";
            this.btnValider.TextColor = System.Drawing.Color.White;
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // historiqueLigne3
            // 
            this.historiqueLigne3.Location = new System.Drawing.Point(0, 230);
            this.historiqueLigne3.Name = "historiqueLigne3";
            this.historiqueLigne3.Size = new System.Drawing.Size(492, 120);
            this.historiqueLigne3.TabIndex = 16;
            // 
            // HistoriqueQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 521);
            this.Controls.Add(this.historiqueLigne3);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.historiqueLigne2);
            this.Controls.Add(this.historiqueLigne1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoriqueQuiz";
            this.ResumeLayout(false);

        }

        #endregion

        private HistoriqueLigne historiqueLigne1;
        private HistoriqueLigne historiqueLigne2;
        private ePOSOne.btnProduct.Button_WOC btnValider;
        private HistoriqueLigne historiqueLigne3;
    }
}