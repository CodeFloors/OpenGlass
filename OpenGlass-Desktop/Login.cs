using Microsoft.Win32;
using System;
using System.Data;
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
            RegistryKey readRememberMe = Registry.CurrentUser.OpenSubKey(@"Software\Remember");
            if (readRememberMe != null)
            {
                TxtUsername.Text = readRememberMe.GetValue("UN").ToString();
                TxtPassword.Select();
                chkRememberMe.Checked = true;
                readRememberMe.Close();
            }
        }

        private void ClearInputs()
        {
            TxtUsername.Text = string.Empty;
            TxtPassword.Text = string.Empty;
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (chkRememberMe.Checked)
            {
                Registry.CurrentUser.DeleteSubKey(@"Software\Remember", false);
                RegistryKey writeRememberMe = Registry.CurrentUser.CreateSubKey(@"Software\Remember");
                writeRememberMe.SetValue("UN", TxtUsername.Text);
                writeRememberMe.Close();
            }
            else
            {
                Registry.CurrentUser.DeleteSubKey(@"Software\Remember", false);
            }
        }

        private void IsInputFieldsValidate()
        {

        }

        private void IsIdentified()
        {

        }

        private void DesignSetup()
        {

        }

        private void BtnCloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KeyStrokeValidate(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
               (e.KeyChar >= 'A' && e.KeyChar <= 'Z') ||
               (e.KeyChar >= '0' && e.KeyChar <= '9') ||
               e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
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
