namespace nginx_php_manager.ui
{
    partial class PhpControl
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
            this.descriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.phpAddressTextBox = new System.Windows.Forms.TextBox();
            this.phpBinPathLabel = new System.Windows.Forms.Label();
            this.phpDirectoryButton = new System.Windows.Forms.Button();
            this.phpDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.phpDirectoryLabel = new System.Windows.Forms.Label();
            this.nginxPanel = new System.Windows.Forms.Panel();
            this.phpPortNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.phpPortLabel = new System.Windows.Forms.Label();
            this.phpAddressLabel = new System.Windows.Forms.Label();
            this.phpLabel = new System.Windows.Forms.Label();
            this.descriptionGroupBox.SuspendLayout();
            this.nginxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phpPortNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionGroupBox
            // 
            this.descriptionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionGroupBox.Controls.Add(this.descriptionRichTextBox);
            this.descriptionGroupBox.Location = new System.Drawing.Point(4, 94);
            this.descriptionGroupBox.Name = "descriptionGroupBox";
            this.descriptionGroupBox.Size = new System.Drawing.Size(500, 154);
            this.descriptionGroupBox.TabIndex = 7;
            this.descriptionGroupBox.TabStop = false;
            this.descriptionGroupBox.Text = "Description";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.descriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionRichTextBox.Location = new System.Drawing.Point(6, 22);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.ReadOnly = true;
            this.descriptionRichTextBox.Size = new System.Drawing.Size(488, 126);
            this.descriptionRichTextBox.TabIndex = 0;
            this.descriptionRichTextBox.Text = "N/A";
            // 
            // phpAddressTextBox
            // 
            this.phpAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phpAddressTextBox.Location = new System.Drawing.Point(61, 65);
            this.phpAddressTextBox.Name = "phpAddressTextBox";
            this.phpAddressTextBox.Size = new System.Drawing.Size(264, 23);
            this.phpAddressTextBox.TabIndex = 5;
            this.phpAddressTextBox.TextChanged += new System.EventHandler(this.phpAddressTextBox_TextChanged);
            // 
            // phpBinPathLabel
            // 
            this.phpBinPathLabel.AutoSize = true;
            this.phpBinPathLabel.Location = new System.Drawing.Point(3, 45);
            this.phpBinPathLabel.Name = "phpBinPathLabel";
            this.phpBinPathLabel.Size = new System.Drawing.Size(61, 15);
            this.phpBinPathLabel.TabIndex = 4;
            this.phpBinPathLabel.Text = "Bind path:";
            // 
            // phpDirectoryButton
            // 
            this.phpDirectoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phpDirectoryButton.Location = new System.Drawing.Point(392, 19);
            this.phpDirectoryButton.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.phpDirectoryButton.Name = "phpDirectoryButton";
            this.phpDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.phpDirectoryButton.TabIndex = 3;
            this.phpDirectoryButton.Text = "Select";
            this.phpDirectoryButton.UseVisualStyleBackColor = true;
            this.phpDirectoryButton.Click += new System.EventHandler(this.phpDirectoryButton_Click);
            // 
            // phpDirectoryTextBox
            // 
            this.phpDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phpDirectoryTextBox.Location = new System.Drawing.Point(4, 19);
            this.phpDirectoryTextBox.Name = "phpDirectoryTextBox";
            this.phpDirectoryTextBox.Size = new System.Drawing.Size(382, 23);
            this.phpDirectoryTextBox.TabIndex = 2;
            this.phpDirectoryTextBox.TextChanged += new System.EventHandler(this.phpDirectory_TextChanged);
            // 
            // phpDirectoryLabel
            // 
            this.phpDirectoryLabel.AutoSize = true;
            this.phpDirectoryLabel.Location = new System.Drawing.Point(3, 0);
            this.phpDirectoryLabel.Name = "phpDirectoryLabel";
            this.phpDirectoryLabel.Size = new System.Drawing.Size(58, 15);
            this.phpDirectoryLabel.TabIndex = 1;
            this.phpDirectoryLabel.Text = "Directory:";
            // 
            // nginxPanel
            // 
            this.nginxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nginxPanel.Controls.Add(this.phpPortNumericUpDown);
            this.nginxPanel.Controls.Add(this.phpPortLabel);
            this.nginxPanel.Controls.Add(this.phpAddressLabel);
            this.nginxPanel.Controls.Add(this.descriptionGroupBox);
            this.nginxPanel.Controls.Add(this.phpAddressTextBox);
            this.nginxPanel.Controls.Add(this.phpBinPathLabel);
            this.nginxPanel.Controls.Add(this.phpDirectoryButton);
            this.nginxPanel.Controls.Add(this.phpDirectoryTextBox);
            this.nginxPanel.Controls.Add(this.phpDirectoryLabel);
            this.nginxPanel.Location = new System.Drawing.Point(3, 48);
            this.nginxPanel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.nginxPanel.Name = "nginxPanel";
            this.nginxPanel.Size = new System.Drawing.Size(507, 251);
            this.nginxPanel.TabIndex = 4;
            // 
            // phpPortNumericUpDown
            // 
            this.phpPortNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phpPortNumericUpDown.Location = new System.Drawing.Point(369, 65);
            this.phpPortNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.phpPortNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.phpPortNumericUpDown.Name = "phpPortNumericUpDown";
            this.phpPortNumericUpDown.Size = new System.Drawing.Size(98, 23);
            this.phpPortNumericUpDown.TabIndex = 10;
            this.phpPortNumericUpDown.ValueChanged += new System.EventHandler(this.phpPortNumericUpDown_ValueChanged);
            // 
            // phpPortLabel
            // 
            this.phpPortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phpPortLabel.AutoSize = true;
            this.phpPortLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.phpPortLabel.Location = new System.Drawing.Point(331, 67);
            this.phpPortLabel.Name = "phpPortLabel";
            this.phpPortLabel.Size = new System.Drawing.Size(32, 15);
            this.phpPortLabel.TabIndex = 9;
            this.phpPortLabel.Text = "Port:";
            // 
            // phpAddressLabel
            // 
            this.phpAddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phpAddressLabel.AutoSize = true;
            this.phpAddressLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.phpAddressLabel.Location = new System.Drawing.Point(3, 68);
            this.phpAddressLabel.Name = "phpAddressLabel";
            this.phpAddressLabel.Size = new System.Drawing.Size(52, 15);
            this.phpAddressLabel.TabIndex = 8;
            this.phpAddressLabel.Text = "Address:";
            // 
            // phpLabel
            // 
            this.phpLabel.AutoSize = true;
            this.phpLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phpLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.phpLabel.Location = new System.Drawing.Point(3, 0);
            this.phpLabel.Name = "phpLabel";
            this.phpLabel.Size = new System.Drawing.Size(92, 28);
            this.phpLabel.TabIndex = 3;
            this.phpLabel.Text = "Php fpm";
            // 
            // PhpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nginxPanel);
            this.Controls.Add(this.phpLabel);
            this.Name = "PhpControl";
            this.Size = new System.Drawing.Size(513, 302);
            this.Load += new System.EventHandler(this.PhpControl_Load);
            this.descriptionGroupBox.ResumeLayout(false);
            this.nginxPanel.ResumeLayout(false);
            this.nginxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phpPortNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox descriptionGroupBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.TextBox phpAddressTextBox;
        private System.Windows.Forms.Label phpBinPathLabel;
        private System.Windows.Forms.Button phpDirectoryButton;
        private System.Windows.Forms.TextBox phpDirectoryTextBox;
        private System.Windows.Forms.Label phpDirectoryLabel;
        private System.Windows.Forms.Panel nginxPanel;
        private System.Windows.Forms.Label phpLabel;
        private System.Windows.Forms.NumericUpDown phpPortNumericUpDown;
        private System.Windows.Forms.Label phpPortLabel;
        private System.Windows.Forms.Label phpAddressLabel;
    }
}
