namespace Coelacanth
{
    partial class PasswordGenerationPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.digitsCheckBox = new System.Windows.Forms.CheckBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.clipboardCheckBox = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.lengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lcCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ucCheckBox
            // 
            this.ucCheckBox.AutoSize = true;
            this.ucCheckBox.Checked = true;
            this.ucCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ucCheckBox.Location = new System.Drawing.Point(14, 10);
            this.ucCheckBox.Name = "ucCheckBox";
            this.ucCheckBox.Size = new System.Drawing.Size(78, 17);
            this.ucCheckBox.TabIndex = 25;
            this.ucCheckBox.Text = "Uppercase";
            this.ucCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(74, 112);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(163, 20);
            this.passwordTextBox.TabIndex = 33;
            // 
            // digitsCheckBox
            // 
            this.digitsCheckBox.AutoSize = true;
            this.digitsCheckBox.Checked = true;
            this.digitsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.digitsCheckBox.Location = new System.Drawing.Point(14, 56);
            this.digitsCheckBox.Name = "digitsCheckBox";
            this.digitsCheckBox.Size = new System.Drawing.Size(52, 17);
            this.digitsCheckBox.TabIndex = 27;
            this.digitsCheckBox.Text = "Digits";
            this.digitsCheckBox.UseVisualStyleBackColor = true;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(95, 57);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(40, 13);
            this.lengthLabel.TabIndex = 32;
            this.lengthLabel.Text = "Length";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(14, 83);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(78, 23);
            this.generateButton.TabIndex = 28;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // clipboardCheckBox
            // 
            this.clipboardCheckBox.AutoSize = true;
            this.clipboardCheckBox.Checked = true;
            this.clipboardCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clipboardCheckBox.Location = new System.Drawing.Point(98, 10);
            this.clipboardCheckBox.Name = "clipboardCheckBox";
            this.clipboardCheckBox.Size = new System.Drawing.Size(70, 17);
            this.clipboardCheckBox.TabIndex = 31;
            this.clipboardCheckBox.Text = "Clipboard";
            this.clipboardCheckBox.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(98, 83);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(78, 23);
            this.clearButton.TabIndex = 29;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(15, 115);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 30;
            this.passwordLabel.Text = "Password";
            // 
            // lengthNumericUpDown
            // 
            this.lengthNumericUpDown.Location = new System.Drawing.Point(141, 57);
            this.lengthNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.lengthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lengthNumericUpDown.Name = "lengthNumericUpDown";
            this.lengthNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.lengthNumericUpDown.TabIndex = 34;
            this.lengthNumericUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lcCheckBox
            // 
            this.lcCheckBox.AutoSize = true;
            this.lcCheckBox.Checked = true;
            this.lcCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lcCheckBox.Location = new System.Drawing.Point(14, 33);
            this.lcCheckBox.Name = "lcCheckBox";
            this.lcCheckBox.Size = new System.Drawing.Size(78, 17);
            this.lcCheckBox.TabIndex = 26;
            this.lcCheckBox.Text = "Lowercase";
            this.lcCheckBox.UseVisualStyleBackColor = true;
            // 
            // PasswordGenerationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucCheckBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.digitsCheckBox);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.clipboardCheckBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.lengthNumericUpDown);
            this.Controls.Add(this.lcCheckBox);
            this.Name = "PasswordGenerationPanel";
            this.Size = new System.Drawing.Size(270, 179);
            this.Load += new System.EventHandler(this.PasswordGenerationPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lengthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ucCheckBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox digitsCheckBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.CheckBox clipboardCheckBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.NumericUpDown lengthNumericUpDown;
        private System.Windows.Forms.CheckBox lcCheckBox;
    }
}
