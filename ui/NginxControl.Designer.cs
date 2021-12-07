
namespace nginx_php_manager.ui
{
    partial class NginxControl
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
            this.nginxLabel = new System.Windows.Forms.Label();
            this.nginxDirectoryLabel = new System.Windows.Forms.Label();
            this.nginxPanel = new System.Windows.Forms.Panel();
            this.descriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.nginxConfigButton = new System.Windows.Forms.Button();
            this.nginxConfigTextBox = new System.Windows.Forms.TextBox();
            this.nginxConfigLabel = new System.Windows.Forms.Label();
            this.nginxDirectoryButton = new System.Windows.Forms.Button();
            this.nginxDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.nginxPanel.SuspendLayout();
            this.descriptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nginxLabel
            // 
            this.nginxLabel.AutoSize = true;
            this.nginxLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nginxLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.nginxLabel.Location = new System.Drawing.Point(3, 0);
            this.nginxLabel.Name = "nginxLabel";
            this.nginxLabel.Size = new System.Drawing.Size(69, 28);
            this.nginxLabel.TabIndex = 0;
            this.nginxLabel.Text = "Nginx";
            // 
            // nginxDirectoryLabel
            // 
            this.nginxDirectoryLabel.AutoSize = true;
            this.nginxDirectoryLabel.Location = new System.Drawing.Point(3, 0);
            this.nginxDirectoryLabel.Name = "nginxDirectoryLabel";
            this.nginxDirectoryLabel.Size = new System.Drawing.Size(58, 15);
            this.nginxDirectoryLabel.TabIndex = 1;
            this.nginxDirectoryLabel.Text = "Directory:";
            // 
            // nginxPanel
            // 
            this.nginxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nginxPanel.Controls.Add(this.descriptionGroupBox);
            this.nginxPanel.Controls.Add(this.nginxConfigButton);
            this.nginxPanel.Controls.Add(this.nginxConfigTextBox);
            this.nginxPanel.Controls.Add(this.nginxConfigLabel);
            this.nginxPanel.Controls.Add(this.nginxDirectoryButton);
            this.nginxPanel.Controls.Add(this.nginxDirectoryTextBox);
            this.nginxPanel.Controls.Add(this.nginxDirectoryLabel);
            this.nginxPanel.Location = new System.Drawing.Point(3, 48);
            this.nginxPanel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.nginxPanel.Name = "nginxPanel";
            this.nginxPanel.Size = new System.Drawing.Size(432, 242);
            this.nginxPanel.TabIndex = 2;
            // 
            // descriptionGroupBox
            // 
            this.descriptionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionGroupBox.Controls.Add(this.descriptionRichTextBox);
            this.descriptionGroupBox.Location = new System.Drawing.Point(4, 94);
            this.descriptionGroupBox.Name = "descriptionGroupBox";
            this.descriptionGroupBox.Size = new System.Drawing.Size(425, 145);
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
            this.descriptionRichTextBox.Size = new System.Drawing.Size(413, 117);
            this.descriptionRichTextBox.TabIndex = 0;
            this.descriptionRichTextBox.Text = "N/A";
            // 
            // nginxConfigButton
            // 
            this.nginxConfigButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nginxConfigButton.Location = new System.Drawing.Point(317, 65);
            this.nginxConfigButton.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.nginxConfigButton.Name = "nginxConfigButton";
            this.nginxConfigButton.Size = new System.Drawing.Size(75, 23);
            this.nginxConfigButton.TabIndex = 6;
            this.nginxConfigButton.Text = "Select";
            this.nginxConfigButton.UseVisualStyleBackColor = true;
            this.nginxConfigButton.Click += new System.EventHandler(this.nginxConfigButton_Click);
            // 
            // nginxConfigTextBox
            // 
            this.nginxConfigTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nginxConfigTextBox.Location = new System.Drawing.Point(4, 64);
            this.nginxConfigTextBox.Name = "nginxConfigTextBox";
            this.nginxConfigTextBox.Size = new System.Drawing.Size(307, 23);
            this.nginxConfigTextBox.TabIndex = 5;
            this.nginxConfigTextBox.TextChanged += new System.EventHandler(this.nginxConfigFile_TextChanged);
            // 
            // nginxConfigLabel
            // 
            this.nginxConfigLabel.AutoSize = true;
            this.nginxConfigLabel.Location = new System.Drawing.Point(3, 45);
            this.nginxConfigLabel.Name = "nginxConfigLabel";
            this.nginxConfigLabel.Size = new System.Drawing.Size(65, 15);
            this.nginxConfigLabel.TabIndex = 4;
            this.nginxConfigLabel.Text = "Config file:";
            // 
            // nginxDirectoryButton
            // 
            this.nginxDirectoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nginxDirectoryButton.Location = new System.Drawing.Point(317, 19);
            this.nginxDirectoryButton.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.nginxDirectoryButton.Name = "nginxDirectoryButton";
            this.nginxDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.nginxDirectoryButton.TabIndex = 3;
            this.nginxDirectoryButton.Text = "Select";
            this.nginxDirectoryButton.UseVisualStyleBackColor = true;
            this.nginxDirectoryButton.Click += new System.EventHandler(this.nginxDirectoryButton_Click);
            // 
            // nginxDirectoryTextBox
            // 
            this.nginxDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nginxDirectoryTextBox.Location = new System.Drawing.Point(4, 19);
            this.nginxDirectoryTextBox.Name = "nginxDirectoryTextBox";
            this.nginxDirectoryTextBox.Size = new System.Drawing.Size(307, 23);
            this.nginxDirectoryTextBox.TabIndex = 2;
            this.nginxDirectoryTextBox.TextChanged += new System.EventHandler(this.nginxDirectory_TextChanged);
            // 
            // NginxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nginxPanel);
            this.Controls.Add(this.nginxLabel);
            this.Name = "NginxControl";
            this.Size = new System.Drawing.Size(438, 293);
            this.Load += new System.EventHandler(this.NginxControl_Load);
            this.nginxPanel.ResumeLayout(false);
            this.nginxPanel.PerformLayout();
            this.descriptionGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nginxLabel;
        private System.Windows.Forms.Label nginxDirectoryLabel;
        private System.Windows.Forms.Panel nginxPanel;
        private System.Windows.Forms.Button nginxConfigButton;
        private System.Windows.Forms.TextBox nginxConfigTextBox;
        private System.Windows.Forms.Label nginxConfigLabel;
        private System.Windows.Forms.Button nginxDirectoryButton;
        private System.Windows.Forms.TextBox nginxDirectoryTextBox;
        private System.Windows.Forms.GroupBox descriptionGroupBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
    }
}
