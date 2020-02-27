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
            this.txt_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_prenom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_nom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_phone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnModifier = new System.Windows.Forms.Button();
            this.passwordStatut = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.rdFemme.Location = new System.Drawing.Point(322, 213);
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
            this.rdHomme.BackColor = System.Drawing.Color.White;
            this.rdHomme.Checked = true;
            this.rdHomme.Depth = 0;
            this.rdHomme.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdHomme.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdHomme.Location = new System.Drawing.Point(159, 213);
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
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_password.Depth = 0;
            this.txt_password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_password.Hint = "Mot de passe";
            this.txt_password.Location = new System.Drawing.Point(159, 353);
            this.txt_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '•';
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.Size = new System.Drawing.Size(238, 23);
            this.txt_password.TabIndex = 36;
            this.txt_password.TabStop = false;
            this.txt_password.UseSystemPasswordChar = false;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_username.Depth = 0;
            this.txt_username.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_username.Hint = "Nom d\'utilisateur";
            this.txt_username.Location = new System.Drawing.Point(159, 310);
            this.txt_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.SelectedText = "";
            this.txt_username.SelectionLength = 0;
            this.txt_username.SelectionStart = 0;
            this.txt_username.Size = new System.Drawing.Size(238, 23);
            this.txt_username.TabIndex = 35;
            this.txt_username.TabStop = false;
            this.txt_username.UseSystemPasswordChar = false;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_email.Depth = 0;
            this.txt_email.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_email.Hint = "Email";
            this.txt_email.Location = new System.Drawing.Point(159, 267);
            this.txt_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.Size = new System.Drawing.Size(238, 23);
            this.txt_email.TabIndex = 34;
            this.txt_email.TabStop = false;
            this.txt_email.UseSystemPasswordChar = false;
            // 
            // txt_prenom
            // 
            this.txt_prenom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_prenom.Depth = 0;
            this.txt_prenom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_prenom.Hint = "Prénom";
            this.txt_prenom.Location = new System.Drawing.Point(159, 67);
            this.txt_prenom.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.PasswordChar = '\0';
            this.txt_prenom.SelectedText = "";
            this.txt_prenom.SelectionLength = 0;
            this.txt_prenom.SelectionStart = 0;
            this.txt_prenom.Size = new System.Drawing.Size(238, 23);
            this.txt_prenom.TabIndex = 33;
            this.txt_prenom.TabStop = false;
            this.txt_prenom.UseSystemPasswordChar = false;
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_nom.Depth = 0;
            this.txt_nom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nom.Hint = "Nom";
            this.txt_nom.Location = new System.Drawing.Point(159, 117);
            this.txt_nom.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.PasswordChar = '\0';
            this.txt_nom.SelectedText = "";
            this.txt_nom.SelectionLength = 0;
            this.txt_nom.SelectionStart = 0;
            this.txt_nom.Size = new System.Drawing.Size(238, 23);
            this.txt_nom.TabIndex = 32;
            this.txt_nom.TabStop = false;
            this.txt_nom.UseSystemPasswordChar = false;
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_phone.Depth = 0;
            this.txt_phone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_phone.Hint = "Téléphone";
            this.txt_phone.Location = new System.Drawing.Point(159, 166);
            this.txt_phone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PasswordChar = '\0';
            this.txt_phone.SelectedText = "";
            this.txt_phone.SelectionLength = 0;
            this.txt_phone.SelectionStart = 0;
            this.txt_phone.Size = new System.Drawing.Size(238, 23);
            this.txt_phone.TabIndex = 31;
            this.txt_phone.TabStop = false;
            this.txt_phone.UseSystemPasswordChar = false;
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(315, 401);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(82, 34);
            this.btnModifier.TabIndex = 39;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // passwordStatut
            // 
            this.passwordStatut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordStatut.Image = global::Zaya.Properties.Resources.showPassword;
            this.passwordStatut.Location = new System.Drawing.Point(368, 353);
            this.passwordStatut.Name = "passwordStatut";
            this.passwordStatut.Size = new System.Drawing.Size(29, 23);
            this.passwordStatut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordStatut.TabIndex = 43;
            this.passwordStatut.TabStop = false;
            this.passwordStatut.Click += new System.EventHandler(this.passwordStatut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.passwordStatut);
            this.panel1.Controls.Add(this.txt_phone);
            this.panel1.Controls.Add(this.txt_nom);
            this.panel1.Controls.Add(this.rdFemme);
            this.panel1.Controls.Add(this.txt_prenom);
            this.panel1.Controls.Add(this.rdHomme);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 488);
            this.panel1.TabIndex = 44;
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
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_password;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_username;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_email;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_prenom;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_nom;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_phone;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.PictureBox passwordStatut;
        private System.Windows.Forms.Panel panel1;
    }
}