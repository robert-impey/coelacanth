namespace Coelacanth
{
    partial class PasswordGenerationForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordGenerationPanel = new Coelacanth.PasswordGenerationPanel();
            this.lengthNmericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lcCheckBox = new System.Windows.Forms.CheckBox();
            this.ucCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.digitsCheckBox = new System.Windows.Forms.CheckBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.clipboardCheckBox = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNmericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordGenerationPanel
            // 
            this.passwordGenerationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordGenerationPanel.Location = new System.Drawing.Point(0, 0);
            this.passwordGenerationPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.passwordGenerationPanel.Name = "passwordGenerationPanel";
            this.passwordGenerationPanel.Size = new System.Drawing.Size(349, 204);
            this.passwordGenerationPanel.TabIndex = 0;
            this.passwordGenerationPanel.Load += new System.EventHandler(this.passwordGenerationPanel_Load);
            this.passwordGenerationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lengthNmericUpDown
            // 
            this.lengthNmericUpDown.Location = new System.Drawing.Point(133, 53);
            this.lengthNmericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.lengthNmericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lengthNmericUpDown.Name = "lengthNmericUpDown";
            this.lengthNmericUpDown.Size = new System.Drawing.Size(50, 22);
            this.lengthNmericUpDown.TabIndex = 14;
            this.lengthNmericUpDown.Value = new decimal(new int[] {
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
            this.lcCheckBox.Location = new System.Drawing.Point(6, 29);
            this.lcCheckBox.Name = "lcCheckBox";
            this.lcCheckBox.Size = new System.Drawing.Size(78, 17);
            this.lcCheckBox.TabIndex = 4;
            this.lcCheckBox.Text = "Lowercase";
            this.lcCheckBox.UseVisualStyleBackColor = true;
            // 
            // ucCheckBox
            // 
            this.ucCheckBox.AutoSize = true;
            this.ucCheckBox.Checked = true;
            this.ucCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ucCheckBox.Location = new System.Drawing.Point(6, 6);
            this.ucCheckBox.Name = "ucCheckBox";
            this.ucCheckBox.Size = new System.Drawing.Size(78, 17);
            this.ucCheckBox.TabIndex = 3;
            this.ucCheckBox.Text = "Uppercase";
            this.ucCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(66, 108);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(163, 22);
            this.passwordTextBox.TabIndex = 13;
            // 
            // digitsCheckBox
            // 
            this.digitsCheckBox.AutoSize = true;
            this.digitsCheckBox.Checked = true;
            this.digitsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.digitsCheckBox.Location = new System.Drawing.Point(6, 52);
            this.digitsCheckBox.Name = "digitsCheckBox";
            this.digitsCheckBox.Size = new System.Drawing.Size(52, 17);
            this.digitsCheckBox.TabIndex = 5;
            this.digitsCheckBox.Text = "Digits";
            this.digitsCheckBox.UseVisualStyleBackColor = true;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(87, 53);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(40, 13);
            this.lengthLabel.TabIndex = 12;
            this.lengthLabel.Text = "Length";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(6, 79);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(78, 23);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            // 
            // clipboardCheckBox
            // 
            this.clipboardCheckBox.AutoSize = true;
            this.clipboardCheckBox.Checked = true;
            this.clipboardCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clipboardCheckBox.Location = new System.Drawing.Point(90, 6);
            this.clipboardCheckBox.Name = "clipboardCheckBox";
            this.clipboardCheckBox.Size = new System.Drawing.Size(70, 17);
            this.clipboardCheckBox.TabIndex = 10;
            this.clipboardCheckBox.Text = "Clipboard";
            this.clipboardCheckBox.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(90, 79);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(78, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(7, 111);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password";
            // 
            // PasswordGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 204);
            this.Controls.Add(this.passwordGenerationPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PasswordGenerationForm";
            this.Text = "PasswordGenerationForm";
            ((System.ComponentModel.ISupportInitialize)(this.lengthNmericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PasswordGenerationPanel passwordGenerationPanel;
        private System.Windows.Forms.NumericUpDown lengthNmericUpDown;
        private System.Windows.Forms.CheckBox lcCheckBox;
        private System.Windows.Forms.CheckBox ucCheckBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox digitsCheckBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.CheckBox clipboardCheckBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label passwordLabel;
    }
}