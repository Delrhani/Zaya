namespace Zaya
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordStatut = new System.Windows.Forms.PictureBox();
            this.btn_Login = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordStatut)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Depth = 0;
            this.txtLogin.Hint = "Login";
            this.txtLogin.Location = new System.Drawing.Point(264, 78);
            this.txtLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.Size = new System.Drawing.Size(208, 23);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.TabStop = false;
            this.txtLogin.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "Password";
            this.txtPassword.Location = new System.Drawing.Point(264, 128);
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(208, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TabStop = false;
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(204, 245);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(326, 1);
            this.materialDivider1.TabIndex = 5;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(234, 270);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(194, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "you don\'t have an account ?";
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignUp.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.Gray;
            this.lblSignUp.Location = new System.Drawing.Point(432, 270);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(57, 17);
            this.lblSignUp.TabIndex = 5;
            this.lblSignUp.Text = "SignUp";
            this.lblSignUp.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 310);
            this.panel1.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(0, 285);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(176, 5);
            this.panel8.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(0, -13);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(114, 4);
            this.panel9.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(0, 272);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(176, 5);
            this.panel10.TabIndex = 14;
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(0, -13);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(114, 4);
            this.panel11.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 5);
            this.panel2.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(176, 5);
            this.panel4.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(176, 5);
            this.panel6.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(0, -13);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(114, 4);
            this.panel7.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, -13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(114, 4);
            this.panel5.TabIndex = 2;
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
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // passwordStatut
            // 
            this.passwordStatut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordStatut.Image = global::Zaya.Properties.Resources.showPassword;
            this.passwordStatut.Location = new System.Drawing.Point(443, 128);
            this.passwordStatut.Name = "passwordStatut";
            this.passwordStatut.Size = new System.Drawing.Size(29, 23);
            this.passwordStatut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordStatut.TabIndex = 33;
            this.passwordStatut.TabStop = false;
            this.passwordStatut.Click += new System.EventHandler(this.passwordStatut_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.AutoSize = true;
            this.btn_Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Depth = 0;
            this.btn_Login.Location = new System.Drawing.Point(397, 187);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Primary = false;
            this.btn_Login.Size = new System.Drawing.Size(75, 36);
            this.btn_Login.TabIndex = 34;
            this.btn_Login.Text = "Connect";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.materialFlatButton1_Click);
            this.btn_Login.MouseLeave += new System.EventHandler(this.materialFlatButton1_MouseLeave);
            this.btn_Login.MouseHover += new System.EventHandler(this.btn_Login_MouseHover);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(580, 310);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.passwordStatut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordStatut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox passwordStatut;
        private MaterialSkin.Controls.MaterialFlatButton btn_Login;
    }
}