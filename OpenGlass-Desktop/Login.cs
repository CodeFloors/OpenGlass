using Microsoft.Win32;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OpenGlass_Desktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            RegistryKey readRememberMe = Registry.CurrentUser.OpenSubKey(@"Software\OpenGlass\Remember");
            if (readRememberMe != null)
            {
                TxtEmail.Text = readRememberMe.GetValue("UN").ToString();
                readRememberMe.Close();
                TxtPassword.Select();
                chkRememberMe.Checked = true;
            }
        }

        private void ClearInputs()
        {
            TxtEmail.Text = string.Empty;
            TxtPassword.Text = string.Empty;
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // setup remember user email
            if (chkRememberMe.Checked)
            {
                Registry.CurrentUser.DeleteSubKey(@"Software\OpenGlass\Remember", false);
                RegistryKey writeRememberMe = Registry.CurrentUser.CreateSubKey(@"Software\OpenGlass\Remember");
                writeRememberMe.SetValue("UN", TxtEmail.Text);
                writeRememberMe.Close();
            }
            else
            {
                Registry.CurrentUser.DeleteSubKey(@"Software\Remember", false);
            }

            if (ValidateInputs())
            {

            }
        }

        private bool IsValidEmail()
        {
            return Regex.Match(TxtEmail.Text, @"^\w+\@\w+\.[a-zA-Z]+$").Success;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(TxtEmail.Text) && string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                lblError.Text = "Email is Required !!";
                return false;
            }
            else if (string.IsNullOrEmpty(TxtPassword.Text) && string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                lblError.Text = "Password is Required !!";
                return false;
            }
            else if (!IsValidEmail())
            {
                lblError.Text = "\t\tInvalid Email !!";
                return false;
            }
            else
            {
                lblError.Text = string.Empty;
                return true;
            }
        }

        private void BtnCloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LonginOnPressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(sender, e);
            }
        }
    }
}
