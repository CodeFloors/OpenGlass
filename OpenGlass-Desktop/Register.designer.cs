﻿namespace OpenGlass_Desktop
{
    partial class Register
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
            this.TxtRegEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtRegPasswordConfirm = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBackToLogin = new System.Windows.Forms.Label();
            this.PbUserRegister = new System.Windows.Forms.PictureBox();
            this.BtnRegister = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TxtRegPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenFD = new System.Windows.Forms.OpenFileDialog();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.lblErrorConfirmPassword = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbUserRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtRegEmail
            // 
            this.TxtRegEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtRegEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtRegEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtRegEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRegEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtRegEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtRegEmail.HintForeColor = System.Drawing.Color.Empty;
            this.TxtRegEmail.HintText = "";
            this.TxtRegEmail.isPassword = false;
            this.TxtRegEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(109)))));
            this.TxtRegEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtRegEmail.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.TxtRegEmail.LineThickness = 3;
            this.TxtRegEmail.Location = new System.Drawing.Point(135, 171);
            this.TxtRegEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRegEmail.MaxLength = 32767;
            this.TxtRegEmail.Name = "TxtRegEmail";
            this.TxtRegEmail.Size = new System.Drawing.Size(186, 30);
            this.TxtRegEmail.TabIndex = 2;
            this.TxtRegEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtRegPasswordConfirm
            // 
            this.TxtRegPasswordConfirm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtRegPasswordConfirm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtRegPasswordConfirm.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtRegPasswordConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRegPasswordConfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtRegPasswordConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtRegPasswordConfirm.HintForeColor = System.Drawing.Color.Empty;
            this.TxtRegPasswordConfirm.HintText = "";
            this.TxtRegPasswordConfirm.isPassword = true;
            this.TxtRegPasswordConfirm.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(109)))));
            this.TxtRegPasswordConfirm.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtRegPasswordConfirm.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.TxtRegPasswordConfirm.LineThickness = 3;
            this.TxtRegPasswordConfirm.Location = new System.Drawing.Point(135, 249);
            this.TxtRegPasswordConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRegPasswordConfirm.MaxLength = 32767;
            this.TxtRegPasswordConfirm.Name = "TxtRegPasswordConfirm";
            this.TxtRegPasswordConfirm.Size = new System.Drawing.Size(186, 30);
            this.TxtRegPasswordConfirm.TabIndex = 3;
            this.TxtRegPasswordConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label2.Location = new System.Drawing.Point(78, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label3.Location = new System.Drawing.Point(58, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm";
            // 
            // lblBackToLogin
            // 
            this.lblBackToLogin.AutoSize = true;
            this.lblBackToLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblBackToLogin.ForeColor = System.Drawing.Color.Gray;
            this.lblBackToLogin.Location = new System.Drawing.Point(163, 365);
            this.lblBackToLogin.Name = "lblBackToLogin";
            this.lblBackToLogin.Size = new System.Drawing.Size(96, 17);
            this.lblBackToLogin.TabIndex = 5;
            this.lblBackToLogin.Text = "Back To Login";
            this.lblBackToLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBackToLogin.Click += new System.EventHandler(this.lblBackToLogin_Click);
            this.lblBackToLogin.MouseEnter += new System.EventHandler(this.lblBackToLogin_MouseEnter);
            this.lblBackToLogin.MouseLeave += new System.EventHandler(this.lblBackToLogin_MouseLeave);
            // 
            // PbUserRegister
            // 
            this.PbUserRegister.BackColor = System.Drawing.Color.Transparent;
            this.PbUserRegister.BackgroundImage = global::OpenGlass_Desktop.Properties.Resources.UserLogo;
            this.PbUserRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbUserRegister.Location = new System.Drawing.Point(147, 21);
            this.PbUserRegister.Name = "PbUserRegister";
            this.PbUserRegister.Size = new System.Drawing.Size(126, 126);
            this.PbUserRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbUserRegister.TabIndex = 7;
            this.PbUserRegister.TabStop = false;
            this.PbUserRegister.Click += new System.EventHandler(this.PbUserRegister_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Active = false;
            this.BtnRegister.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.BtnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.BtnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegister.BorderRadius = 7;
            this.BtnRegister.ButtonText = "Register";
            this.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegister.DisabledColor = System.Drawing.Color.Gray;
            this.BtnRegister.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnRegister.Iconimage = null;
            this.BtnRegister.Iconimage_right = null;
            this.BtnRegister.Iconimage_right_Selected = null;
            this.BtnRegister.Iconimage_Selected = null;
            this.BtnRegister.IconMarginLeft = 0;
            this.BtnRegister.IconMarginRight = 0;
            this.BtnRegister.IconRightVisible = true;
            this.BtnRegister.IconRightZoom = 0D;
            this.BtnRegister.IconVisible = false;
            this.BtnRegister.IconZoom = 90D;
            this.BtnRegister.IsTab = false;
            this.BtnRegister.Location = new System.Drawing.Point(148, 309);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.BtnRegister.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.BtnRegister.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRegister.selected = false;
            this.BtnRegister.Size = new System.Drawing.Size(130, 45);
            this.BtnRegister.TabIndex = 6;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRegister.Textcolor = System.Drawing.Color.White;
            this.BtnRegister.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_ClickAsync);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TxtRegPassword
            // 
            this.TxtRegPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtRegPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtRegPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtRegPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRegPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtRegPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtRegPassword.HintForeColor = System.Drawing.Color.Empty;
            this.TxtRegPassword.HintText = "";
            this.TxtRegPassword.isPassword = true;
            this.TxtRegPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(109)))));
            this.TxtRegPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtRegPassword.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.TxtRegPassword.LineThickness = 3;
            this.TxtRegPassword.Location = new System.Drawing.Point(135, 209);
            this.TxtRegPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRegPassword.MaxLength = 32767;
            this.TxtRegPassword.Name = "TxtRegPassword";
            this.TxtRegPassword.Size = new System.Drawing.Size(186, 30);
            this.TxtRegPassword.TabIndex = 3;
            this.TxtRegPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label1.Location = new System.Drawing.Point(45, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password";
            // 
            // OpenFD
            // 
            this.OpenFD.FileName = "Image";
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblErrorEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorEmail.Location = new System.Drawing.Point(328, 184);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(65, 17);
            this.lblErrorEmail.TabIndex = 9;
            this.lblErrorEmail.Text = "Required";
            this.lblErrorEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorEmail.Visible = false;
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.AutoSize = true;
            this.lblErrorPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblErrorPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorPassword.Location = new System.Drawing.Point(328, 222);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(65, 17);
            this.lblErrorPassword.TabIndex = 9;
            this.lblErrorPassword.Text = "Required";
            this.lblErrorPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorPassword.Visible = false;
            // 
            // lblErrorConfirmPassword
            // 
            this.lblErrorConfirmPassword.AutoSize = true;
            this.lblErrorConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblErrorConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorConfirmPassword.Location = new System.Drawing.Point(328, 262);
            this.lblErrorConfirmPassword.Name = "lblErrorConfirmPassword";
            this.lblErrorConfirmPassword.Size = new System.Drawing.Size(79, 17);
            this.lblErrorConfirmPassword.TabIndex = 9;
            this.lblErrorConfirmPassword.Text = "Not match";
            this.lblErrorConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorConfirmPassword.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblError.ForeColor = System.Drawing.Color.Green;
            this.lblError.Location = new System.Drawing.Point(119, 285);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 9;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(420, 402);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblErrorConfirmPassword);
            this.Controls.Add(this.lblErrorPassword);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.PbUserRegister);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBackToLogin);
            this.Controls.Add(this.TxtRegPassword);
            this.Controls.Add(this.TxtRegPasswordConfirm);
            this.Controls.Add(this.TxtRegEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.PbUserRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtRegEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtRegPasswordConfirm;
        private Bunifu.Framework.UI.BunifuFlatButton BtnRegister;
        private System.Windows.Forms.PictureBox PbUserRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBackToLogin;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtRegPassword;
        private System.Windows.Forms.OpenFileDialog OpenFD;
        private System.Windows.Forms.Label lblErrorConfirmPassword;
        private System.Windows.Forms.Label lblErrorPassword;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblError;
    }
}