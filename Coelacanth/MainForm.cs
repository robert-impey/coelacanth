﻿using System;
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

        private void 
            generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordGenerationForm passwordGenerationForm = new PasswordGenerationForm();

            passwordGenerationForm.Show();
        }
    }
}
