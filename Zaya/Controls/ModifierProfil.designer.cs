namespace Zaya.Controls
{
    partial class ModifierProfil
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
            this.rdFemme = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdHomme = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnModifier = new System.Windows.Forms.Button();
            this.passwordStatut = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_username = new MetroFramework.Controls.MetroTextBox();
            this.txt_email = new MetroFramework.Controls.MetroTextBox();
            this.txt_phone = new MetroFramework.Controls.MetroTextBox();
            this.txt_nom = new MetroFramework.Controls.MetroTextBox();
            this.txt_prenom = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.passwordStatut)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdFemme
            // 
            this.rdFemme.AutoSize = true;
            this.rdFemme.BackColor = System.Drawing.Color.White;
            this.rdFemme.Depth = 0;
            this.rdFemme.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdFemme.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdFemme.Location = new System.Drawing.Point(326, 152);
            this.rdFemme.Margin = new System.Windows.Forms.Padding(0);
            this.rdFemme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdFemme.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdFemme.Name = "rdFemme";
            this.rdFemme.Ripple = true;
            this.rdFemme.Size = new System.Drawing.Size(75, 30);
            this.rdFemme.TabIndex = 38;
            this.rdFemme.Text = "Femme";
            this.rdFemme.UseVisualStyleBackColor = false;
            // 
            // rdHomme
            // 
            this.rdHomme.AutoSize = true;
            this.rdHomme.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rdHomme.Checked = true;
            this.rdHomme.Depth = 0;
            this.rdHomme.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdHomme.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdHomme.Location = new System.Drawing.Point(213, 151);
            this.rdHomme.Margin = new System.Windows.Forms.Padding(0);
            this.rdHomme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdHomme.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdHomme.Name = "rdHomme";
            this.rdHomme.Ripple = true;
            this.rdHomme.Size = new System.Drawing.Size(78, 30);
            this.rdHomme.TabIndex = 37;
            this.rdHomme.TabStop = true;
            this.rdHomme.Text = "Homme";
            this.rdHomme.UseVisualStyleBackColor = false;
            // 
            // btnModifier
            // 
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(431, 436);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(82, 34);
            this.btnModifier.TabIndex = 39;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            this.btnModifier.MouseHover += new System.EventHandler(this.btnModifier_MouseHover);
            // 
            // passwordStatut
            // 
            this.passwordStatut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordStatut.Image = global::Zaya.Properties.Resources.showPassword;
            this.passwordStatut.Location = new System.Drawing.Point(404, 373);
            this.passwordStatut.Name = "passwordStatut";
            this.passwordStatut.Size = new System.Drawing.Size(32, 23);
            this.passwordStatut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordStatut.TabIndex = 43;
            this.passwordStatut.TabStop = false;
            this.passwordStatut.Click += new System.EventHandler(this.passwordStatut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.txt_phone);
            this.panel1.Controls.Add(this.txt_nom);
            this.panel1.Controls.Add(this.txt_prenom);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.passwordStatut);
            this.panel1.Controls.Add(this.rdFemme);
            this.panel1.Controls.Add(this.rdHomme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 488);
            this.panel1.TabIndex = 44;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(94, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 55;
            this.label6.Text = "Mot de passe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(59, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 21);
            this.label5.TabIndex = 54;
            this.label5.Text = "Nom d\'utilisateur :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(159, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 53;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(119, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "Téléphone :";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(227, 373);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '•';
            this.txt_password.Size = new System.Drawing.Size(171, 23);
            this.txt_password.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(162, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(139, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Prénom :";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(227, 320);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(171, 23);
            this.txt_username.TabIndex = 48;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(227, 263);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(171, 23);
            this.txt_email.TabIndex = 47;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(227, 206);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(171, 23);
            this.txt_phone.TabIndex = 46;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(227, 105);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(171, 23);
            this.txt_nom.TabIndex = 45;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(229, 45);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(171, 23);
            this.txt_prenom.TabIndex = 44;
            // 
            // ModifierProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ModifierProfil";
            this.Size = new System.Drawing.Size(595, 488);
            this.Load += new System.EventHandler(this.ConsulterUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passwordStatut)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton rdFemme;
        private MaterialSkin.Controls.MaterialRadioButton rdHomme;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.PictureBox passwordStatut;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txt_username;
        private MetroFramework.Controls.MetroTextBox txt_email;
        private MetroFramework.Controls.MetroTextBox txt_phone;
        private MetroFramework.Controls.MetroTextBox txt_nom;
        private MetroFramework.Controls.MetroTextBox txt_prenom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}