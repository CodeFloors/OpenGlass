using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
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
            ClearInputs();

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
            lblError.Text = string.Empty;
            lblError.ForeColor = Color.Red;

            chkRememberMe.Checked = true;

            TxtEmail.Text = string.Empty;
            TxtPassword.Text = string.Empty;
        }
        private async void BtnLogin_ClickAsync(object sender, EventArgs e)
        {

            if (ValidateUrl())
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
                    try
                    {
                        var httpResponseMessage = await new HttpClient().SendAsync(new HttpRequestMessage()
                        {
                            RequestUri = new Uri($"http://{TxtUrl.Text}/accounts/login"),
                            Method = HttpMethod.Post,
                            Content = new StringContent(JsonConvert.SerializeObject(new
                            {
                                email = TxtEmail.Text,
                                password = TxtPassword.Text
                            }), Encoding.UTF8, "application/json")
                        });
                        if (httpResponseMessage.IsSuccessStatusCode)
                        {
                            lblError.ForeColor = Color.Green;
                            lblError.Text = "You are Successfully Login !!";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
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
                BtnLogin_ClickAsync(sender, e);
            }
        }

        private void lblCreateNewAccount_Click(object sender, EventArgs e)
        {
            if (ValidateUrl())
            {
                new Register(TxtUrl.Text).Show();
                this.Hide();
            }

        }

        private bool ValidateUrl()
        {

            if (string.IsNullOrEmpty(TxtUrl.Text) && string.IsNullOrWhiteSpace(TxtUrl.Text))
            {
                lblError.Text = "Please Enter Url of API";
                return false;
            }
            return true;
        }

        private void lblCreateNewAccount_MouseEnter(object sender, EventArgs e)
        {
            lblCreateNewAccount.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblCreateNewAccount_MouseLeave(object sender, EventArgs e)
        {
            lblCreateNewAccount.ForeColor = Color.Gray;
        }
    }
}
