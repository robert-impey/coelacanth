using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Coelacanth
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 
            generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordGenerationForm passwordGenerationForm = new PasswordGenerationForm();

            passwordGenerationForm.Show();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Choose the file.

            // Open the file
            TextReader passwordFileTextReader = new StreamReader("date.txt");

            // Read the contents of the file.

            // Close the stream.
            passwordFileTextReader.Close();
        }
    }
}
