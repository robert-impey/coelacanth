﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coelacanth
{
    public partial class PasswordGenerationPanel : UserControl
    {
        public PasswordGenerationPanel()
        {
            InitializeComponent();
        }

        private void PasswordGenerationPanel_Load(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = "";

            // Should the clipboard also be cleared?
        }


        private void generateButton_Click(object sender, EventArgs e)
        {
            StringBuilder newPassword = new StringBuilder();

            //newPassword = "Generated Password";

            // Make the string of the available characters.
            StringBuilder availableCharacters = new StringBuilder();

            if (ucCheckBox.Checked)
            {
                for (int i = 'A'; i <= 'Z'; i++)
                {
                    availableCharacters.Append(Convert.ToChar(i));
                }
            }

            if (lcCheckBox.Checked)
            {
                for (int i = 'a'; i <= 'z'; i++)
                {
                    availableCharacters.Append(Convert.ToChar(i));
                }
            }

            if (digitsCheckBox.Checked)
            {
                for (int i = 0; i <= 9; i++)
                {
                    availableCharacters.Append(i);
                }
            }

            // Make the password.

            if (availableCharacters.Length > 0)
            {
                Random random = new Random();

                for (int i = 0; i < lengthNumericUpDown.Value; i++)
                {
                    int randomIndex
                        = random.Next(0, availableCharacters.Length);
                    newPassword.Append(
                        Convert.ToChar(availableCharacters[randomIndex])
                    );
                }
            }
            // Show the password
            passwordTextBox.Text = newPassword.ToString();

            // Optionally copy the new password to the clipboard.
            if (clipboardCheckBox.Checked)
            {
                Clipboard.SetDataObject(newPassword.ToString(), true);
            }
        }
    }
}