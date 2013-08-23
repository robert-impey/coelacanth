using System;
using System.Windows.Forms;
using Coelacanth.Lib;

namespace Coelacanth
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            passwordTextBox.Text = string.Empty;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var passwordGenerator = new PasswordGenerator(
                ucCheckBox.Checked, lcCheckBox.Checked, digitsCheckBox.Checked, 
                (int)lengthNumericUpDown.Value);

            var newPassword = passwordGenerator.NewPassword();

            // Show the password
            passwordTextBox.Text = newPassword;

            // Optionally copy the new password to the clipboard.
            if (clipboardCheckBox.Checked)
            {
                Clipboard.SetText(newPassword);
            }
        }
    }
}
