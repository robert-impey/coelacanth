using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            var newPassword = new StringBuilder();

            // Make the string of the available characters.
            var availableCharacters = new StringBuilder();

            if (ucCheckBox.Checked)
            {
                for (var i = 'A'; i <= 'Z'; i++)
                {
                    availableCharacters.Append(Convert.ToChar(i));
                }
            }

            if (lcCheckBox.Checked)
            {
                for (var i = 'a'; i <= 'z'; i++)
                {
                    availableCharacters.Append(Convert.ToChar(i));
                }
            }

            if (digitsCheckBox.Checked)
            {
                for (var i = 0; i <= 9; i++)
                {
                    availableCharacters.Append(i);
                }
            }

            // Make the password.
            if (availableCharacters.Length > 0)
            {
                var random = new Random();
                for (var i = 0; i < lengthNmericUpDown.Value; i++)
                {
                    var randomIndex = random.Next(0, availableCharacters.Length);
                    newPassword.Append(Convert.ToChar(availableCharacters[randomIndex]));
                }
            }

            // Show the password
            passwordTextBox.Text = newPassword.ToString();

            // Optionally copy the new password to the clipboard.
            if (clipboardCheckBox.Checked)
            {
                Clipboard.SetText(newPassword.ToString());
            }
        }
    }
}
