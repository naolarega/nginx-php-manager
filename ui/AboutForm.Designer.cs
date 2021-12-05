namespace nginx_php_manager.ui
{
    partial class AboutForm
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
            this.aboutLabel = new System.Windows.Forms.Label();
            this.aboutRichTextBox = new System.Windows.Forms.RichTextBox();
            this.aboutCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.aboutLabel.Location = new System.Drawing.Point(12, 9);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(163, 21);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = "Nginx php manager";
            // 
            // aboutRichTextBox
            // 
            this.aboutRichTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.aboutRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutRichTextBox.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutRichTextBox.Location = new System.Drawing.Point(12, 50);
            this.aboutRichTextBox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.aboutRichTextBox.Name = "aboutRichTextBox";
            this.aboutRichTextBox.ReadOnly = true;
            this.aboutRichTextBox.Size = new System.Drawing.Size(240, 170);
            this.aboutRichTextBox.TabIndex = 1;
            this.aboutRichTextBox.Text = "A gui manager for nginx and php.";
            // 
            // aboutCloseButton
            // 
            this.aboutCloseButton.Location = new System.Drawing.Point(177, 226);
            this.aboutCloseButton.Name = "aboutCloseButton";
            this.aboutCloseButton.Size = new System.Drawing.Size(75, 23);
            this.aboutCloseButton.TabIndex = 2;
            this.aboutCloseButton.Text = "Close";
            this.aboutCloseButton.UseVisualStyleBackColor = true;
            this.aboutCloseButton.Click += new System.EventHandler(this.aboutCloseButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.aboutCloseButton);
            this.Controls.Add(this.aboutRichTextBox);
            this.Controls.Add(this.aboutLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(280, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(280, 300);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.RichTextBox aboutRichTextBox;
        private System.Windows.Forms.Button aboutCloseButton;
    }
}