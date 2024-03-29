﻿namespace OpenGlass_Desktop
{
    partial class Login
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
            this.TxtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.chkRememberMe = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.picUserLoginImage = new System.Windows.Forms.PictureBox();
            this.BtnCloseApplication = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TxtUrl = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCreateNewAccount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picUserLoginImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtEmail
            // 
            this.TxtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.TxtEmail.HintText = "";
            this.TxtEmail.isPassword = false;
            this.TxtEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(109)))));
            this.TxtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtEmail.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.TxtEmail.LineThickness = 3;
            this.TxtEmail.Location = new System.Drawing.Point(254, 47);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(186, 30);
            this.TxtEmail.TabIndex = 2;
            this.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LonginOnPressEnter);
            // 
            // TxtPassword
            // 
            this.TxtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.TxtPassword.HintText = "";
            this.TxtPassword.isPassword = true;
            this.TxtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(109)))));
            this.TxtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtPassword.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.TxtPassword.LineThickness = 3;
            this.TxtPassword.Location = new System.Drawing.Point(254, 85);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.MaxLength = 32767;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(186, 30);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LonginOnPressEnter);
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(109)))));
            this.chkRememberMe.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(109)))));
            this.chkRememberMe.Checked = false;
            this.chkRememberMe.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.chkRememberMe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chkRememberMe.Location = new System.Drawing.Point(254, 127);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(20, 20);
            this.chkRememberMe.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(281, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Remember me";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label2.Location = new System.Drawing.Point(184, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label3.Location = new System.Drawing.Point(168, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(217, 165);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(172, 17);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "Invalid Email or Password";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picUserLoginImage
            // 
            this.picUserLoginImage.BackColor = System.Drawing.Color.Transparent;
            this.picUserLoginImage.BackgroundImage = global::OpenGlass_Desktop.Properties.Resources.UserLogo;
            this.picUserLoginImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUserLoginImage.Location = new System.Drawing.Point(21, 59);
            this.picUserLoginImage.Name = "picUserLoginImage";
            this.picUserLoginImage.Size = new System.Drawing.Size(126, 125);
            this.picUserLoginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserLoginImage.TabIndex = 7;
            this.picUserLoginImage.TabStop = false;
            // 
            // BtnCloseApplication
            // 
            this.BtnCloseApplication.Active = true;
            this.BtnCloseApplication.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.BtnCloseApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.BtnCloseApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCloseApplication.BorderRadius = 7;
            this.BtnCloseApplication.ButtonText = "Close";
            this.BtnCloseApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseApplication.DisabledColor = System.Drawing.Color.Gray;
            this.BtnCloseApplication.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnCloseApplication.Iconimage = null;
            this.BtnCloseApplication.Iconimage_right = null;
            this.BtnCloseApplication.Iconimage_right_Selected = null;
            this.BtnCloseApplication.Iconimage_Selected = null;
            this.BtnCloseApplication.IconMarginLeft = 0;
            this.BtnCloseApplication.IconMarginRight = 0;
            this.BtnCloseApplication.IconRightVisible = true;
            this.BtnCloseApplication.IconRightZoom = 0D;
            this.BtnCloseApplication.IconVisible = false;
            this.BtnCloseApplication.IconZoom = 90D;
            this.BtnCloseApplication.IsTab = false;
            this.BtnCloseApplication.Location = new System.Drawing.Point(317, 194);
            this.BtnCloseApplication.Name = "BtnCloseApplication";
            this.BtnCloseApplication.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.BtnCloseApplication.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.BtnCloseApplication.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCloseApplication.selected = true;
            this.BtnCloseApplication.Size = new System.Drawing.Size(124, 45);
            this.BtnCloseApplication.TabIndex = 6;
            this.BtnCloseApplication.Text = "Close";
            this.BtnCloseApplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCloseApplication.Textcolor = System.Drawing.Color.White;
            this.BtnCloseApplication.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloseApplication.Click += new System.EventHandler(this.BtnCloseApplication_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Active = false;
            this.BtnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLogin.BorderRadius = 7;
            this.BtnLogin.ButtonText = "Login";
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.BtnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnLogin.Iconimage = null;
            this.BtnLogin.Iconimage_right = null;
            this.BtnLogin.Iconimage_right_Selected = null;
            this.BtnLogin.Iconimage_Selected = null;
            this.BtnLogin.IconMarginLeft = 0;
            this.BtnLogin.IconMarginRight = 0;
            this.BtnLogin.IconRightVisible = true;
            this.BtnLogin.IconRightZoom = 0D;
            this.BtnLogin.IconVisible = false;
            this.BtnLogin.IconZoom = 90D;
            this.BtnLogin.IsTab = false;
            this.BtnLogin.Location = new System.Drawing.Point(171, 194);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.BtnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.BtnLogin.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnLogin.selected = false;
            this.BtnLogin.Size = new System.Drawing.Size(130, 45);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLogin.Textcolor = System.Drawing.Color.White;
            this.BtnLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_ClickAsync);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TxtUrl
            // 
            this.TxtUrl.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtUrl.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtUrl.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtUrl.BorderThickness = 3;
            this.TxtUrl.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUrl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtUrl.isPassword = false;
            this.TxtUrl.Location = new System.Drawing.Point(85, 9);
            this.TxtUrl.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUrl.MaxLength = 32767;
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(371, 32);
            this.TxtUrl.TabIndex = 8;
            this.TxtUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(18, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Domain";
            // 
            // lblCreateNewAccount
            // 
            this.lblCreateNewAccount.AutoSize = true;
            this.lblCreateNewAccount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblCreateNewAccount.ForeColor = System.Drawing.Color.Gray;
            this.lblCreateNewAccount.Location = new System.Drawing.Point(239, 250);
            this.lblCreateNewAccount.Name = "lblCreateNewAccount";
            this.lblCreateNewAccount.Size = new System.Drawing.Size(146, 17);
            this.lblCreateNewAccount.TabIndex = 9;
            this.lblCreateNewAccount.Text = "Create New Account";
            this.lblCreateNewAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCreateNewAccount.Click += new System.EventHandler(this.lblCreateNewAccount_Click);
            this.lblCreateNewAccount.MouseEnter += new System.EventHandler(this.lblCreateNewAccount_MouseEnter);
            this.lblCreateNewAccount.MouseLeave += new System.EventHandler(this.lblCreateNewAccount_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(469, 284);
            this.Controls.Add(this.lblCreateNewAccount);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.picUserLoginImage);
            this.Controls.Add(this.BtnCloseApplication);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkRememberMe);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUserLoginImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPassword;
        private Bunifu.Framework.UI.BunifuCheckbox chkRememberMe;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnLogin;
        private Bunifu.Framework.UI.BunifuFlatButton BtnCloseApplication;
        private System.Windows.Forms.PictureBox picUserLoginImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblError;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCreateNewAccount;
    }
}