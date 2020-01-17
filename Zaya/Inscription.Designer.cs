namespace Zaya
{
    partial class InscriptionForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnValiderInscription = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_phone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_nom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_prenom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.rdHomme = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdFemme = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Location = new System.Drawing.Point(0, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 50);
            this.panel1.TabIndex = 11;
            // 
            // btnValiderInscription
            // 
            this.btnValiderInscription.BackColor = System.Drawing.Color.DarkGray;
            this.btnValiderInscription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValiderInscription.Depth = 0;
            this.btnValiderInscription.Location = new System.Drawing.Point(399, 325);
            this.btnValiderInscription.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnValiderInscription.Name = "btnValiderInscription";
            this.btnValiderInscription.Primary = true;
            this.btnValiderInscription.Size = new System.Drawing.Size(75, 31);
            this.btnValiderInscription.TabIndex = 20;
            this.btnValiderInscription.Text = "Login";
            this.btnValiderInscription.UseVisualStyleBackColor = false;
            this.btnValiderInscription.Click += new System.EventHandler(this.btnValiderInscription_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_phone.Depth = 0;
            this.txt_phone.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_phone.Hint = "Phone";
            this.txt_phone.Location = new System.Drawing.Point(133, 158);
            this.txt_phone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PasswordChar = '\0';
            this.txt_phone.SelectedText = "";
            this.txt_phone.SelectionLength = 0;
            this.txt_phone.SelectionStart = 0;
            this.txt_phone.Size = new System.Drawing.Size(208, 23);
            this.txt_phone.TabIndex = 21;
            this.txt_phone.UseSystemPasswordChar = false;
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_nom.Depth = 0;
            this.txt_nom.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_nom.Hint = "Familly Name";
            this.txt_nom.Location = new System.Drawing.Point(133, 120);
            this.txt_nom.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.PasswordChar = '\0';
            this.txt_nom.SelectedText = "";
            this.txt_nom.SelectionLength = 0;
            this.txt_nom.SelectionStart = 0;
            this.txt_nom.Size = new System.Drawing.Size(208, 23);
            this.txt_nom.TabIndex = 22;
            this.txt_nom.UseSystemPasswordChar = false;
            // 
            // txt_prenom
            // 
            this.txt_prenom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_prenom.Depth = 0;
            this.txt_prenom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_prenom.Hint = "First Name";
            this.txt_prenom.Location = new System.Drawing.Point(133, 82);
            this.txt_prenom.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.PasswordChar = '\0';
            this.txt_prenom.SelectedText = "";
            this.txt_prenom.SelectionLength = 0;
            this.txt_prenom.SelectionStart = 0;
            this.txt_prenom.Size = new System.Drawing.Size(208, 23);
            this.txt_prenom.TabIndex = 23;
            this.txt_prenom.UseSystemPasswordChar = false;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_email.Depth = 0;
            this.txt_email.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_email.Hint = "Email";
            this.txt_email.Location = new System.Drawing.Point(133, 235);
            this.txt_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.Size = new System.Drawing.Size(208, 23);
            this.txt_email.TabIndex = 25;
            this.txt_email.UseSystemPasswordChar = false;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_username.Depth = 0;
            this.txt_username.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_username.Hint = "Username";
            this.txt_username.Location = new System.Drawing.Point(133, 275);
            this.txt_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.SelectedText = "";
            this.txt_username.SelectionLength = 0;
            this.txt_username.SelectionStart = 0;
            this.txt_username.Size = new System.Drawing.Size(208, 23);
            this.txt_username.TabIndex = 26;
            this.txt_username.UseSystemPasswordChar = false;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_password.Depth = 0;
            this.txt_password.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_password.Hint = "Password";
            this.txt_password.Location = new System.Drawing.Point(133, 315);
            this.txt_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.Size = new System.Drawing.Size(208, 23);
            this.txt_password.TabIndex = 28;
            this.txt_password.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(147, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(186, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "I already have an account !";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // rdHomme
            // 
            this.rdHomme.AutoSize = true;
            this.rdHomme.BackColor = System.Drawing.Color.White;
            this.rdHomme.Depth = 0;
            this.rdHomme.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdHomme.Location = new System.Drawing.Point(133, 202);
            this.rdHomme.Margin = new System.Windows.Forms.Padding(0);
            this.rdHomme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdHomme.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdHomme.Name = "rdHomme";
            this.rdHomme.Ripple = true;
            this.rdHomme.Size = new System.Drawing.Size(78, 30);
            this.rdHomme.TabIndex = 29;
            this.rdHomme.TabStop = true;
            this.rdHomme.Text = "Homme";
            this.rdHomme.UseVisualStyleBackColor = false;
            // 
            // rdFemme
            // 
            this.rdFemme.AutoSize = true;
            this.rdFemme.BackColor = System.Drawing.Color.White;
            this.rdFemme.Depth = 0;
            this.rdFemme.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdFemme.Location = new System.Drawing.Point(227, 202);
            this.rdFemme.Margin = new System.Windows.Forms.Padding(0);
            this.rdFemme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdFemme.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdFemme.Name = "rdFemme";
            this.rdFemme.Ripple = true;
            this.rdFemme.Size = new System.Drawing.Size(75, 30);
            this.rdFemme.TabIndex = 30;
            this.rdFemme.TabStop = true;
            this.rdFemme.Text = "Femme";
            this.rdFemme.UseVisualStyleBackColor = false;
            // 
            // InscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(182)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(507, 411);
            this.Controls.Add(this.rdFemme);
            this.Controls.Add(this.rdHomme);
            this.Controls.Add(this.btnValiderInscription);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(523, 450);
            this.Name = "InscriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign up";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnValiderInscription;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_phone;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_nom;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_prenom;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_email;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_username;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_password;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton rdHomme;
        private MaterialSkin.Controls.MaterialRadioButton rdFemme;
    }
}

