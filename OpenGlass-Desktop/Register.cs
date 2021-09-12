using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OpenGlass_Desktop
{
    public partial class Register : Form
    {
        private byte[] imageByteArray;
        public Register()
        {
            imageByteArray = new byte[] { };
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, System.EventArgs e)
        {
            if (ValidateInputs())
            {

            }

        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(TxtRegEmail.Text) && string.IsNullOrWhiteSpace(TxtRegEmail.Text))
            {
                lblErrorEmail.Text = "Required";
                lblErrorEmail.Show();
                TxtRegEmail.Focus();
                return false;
            }
            else if (!IsValidEmail())
            {
                lblErrorEmail.Text = "Invalid";
                TxtRegEmail.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(TxtRegPassword.Text) && string.IsNullOrWhiteSpace(TxtRegPassword.Text))
            {
                lblErrorEmail.Hide();
                lblErrorPassword.Show();
                TxtRegPassword.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(TxtRegPasswordConfirm.Text) && string.IsNullOrWhiteSpace(TxtRegPasswordConfirm.Text))
            {
                lblErrorEmail.Hide();
                lblErrorPassword.Hide();
                lblErrorConfirmPassword.Text = "Required";
                lblErrorConfirmPassword.Show();
                TxtRegPasswordConfirm.Focus();
                return false;
            }
            else if (!TxtRegPasswordConfirm.Text.Equals(TxtRegPassword.Text))
            {
                lblErrorEmail.Hide();
                lblErrorPassword.Hide();
                lblErrorConfirmPassword.Text = "Not match";
                lblErrorConfirmPassword.Show();
                TxtRegPasswordConfirm.Focus();
                return false;
            }
            else
            {
                lblErrorEmail.Hide();
                lblErrorPassword.Hide();
                lblErrorConfirmPassword.Hide();
                return true;
            }
        }
        private bool IsValidEmail()
        {
            return Regex.Match(TxtRegEmail.Text, @"^\w+\@\w+\.[a-zA-Z]+$").Success;
        }

        private void PbUserRegister_Click(object sender, System.EventArgs e)
        {
            OpenFD.Filter = "Image (*.jpg,*.jpeg,*.png) | *.jpg;*.jpeg;*.png";
            OpenFD.InitialDirectory = @"c:\";
            OpenFD.ValidateNames = true;
            OpenFD.Multiselect = false;
            DialogResult result = OpenFD.ShowDialog();
            if (result == DialogResult.OK)
            {
                string imageFilePath = Path.GetFullPath(OpenFD.FileName);
                Bitmap bitmap = new Bitmap(imageFilePath);
                if (bitmap != null)
                {
                    PbUserRegister.Image = bitmap;
                    MemoryStream memoryStream = new MemoryStream();
                    bitmap.Save(memoryStream, ImageFormat.Jpeg);
                    imageByteArray = memoryStream.ToArray();
                }
            }
        }
    }
}
