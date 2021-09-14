namespace OpenGlass_Desktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TxtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            ((System.ComponentModel.ISupportInitialize)(this.picUserLoginImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsername
            // 
            this.TxtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtUsername.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtUsername.HintForeColor = System.Drawing.Color.Empty;
            this.TxtUsername.HintText = "";
            this.TxtUsername.isPassword = false;
            this.TxtUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(109)))));
            this.TxtUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtUsername.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.TxtUsername.LineThickness = 3;
            this.TxtUsername.Location = new System.Drawing.Point(254, 32);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsername.MaxLength = 32767;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(186, 30);
            this.TxtUsername.TabIndex = 2;
            this.TxtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyStrokeValidate);
            this.TxtUsername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LonginOnPressEnter);
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
            this.TxtPassword.Location = new System.Drawing.Point(254, 81);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.MaxLength = 32767;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(186, 30);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyStrokeValidate);
            this.TxtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LonginOnPressEnter);
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(109)))));
            this.chkRememberMe.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(109)))));
            this.chkRememberMe.Checked = false;
            this.chkRememberMe.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.chkRememberMe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chkRememberMe.Location = new System.Drawing.Point(254, 118);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(20, 20);
            this.chkRememberMe.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(281, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Remember me";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label2.Location = new System.Drawing.Point(166, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label3.Location = new System.Drawing.Point(168, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(64)))));
            this.lblError.Location = new System.Drawing.Point(207, 167);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(200, 17);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "Invalid Username or Password";
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
            this.BtnCloseApplication.Location = new System.Drawing.Point(317, 196);
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
            this.BtnLogin.Location = new System.Drawing.Point(171, 196);
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
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(469, 263);
            this.Controls.Add(this.picUserLoginImage);
            this.Controls.Add(this.BtnCloseApplication);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkRememberMe);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUserLoginImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtUsername;
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
    }
}