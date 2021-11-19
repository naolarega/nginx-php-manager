﻿namespace nginx_php_manager.ui
{
    partial class ControlPanelControl
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
            this.controlPanelLabel = new System.Windows.Forms.Label();
            this.controlPanelPanel = new System.Windows.Forms.Panel();
            this.informationGroupBox = new System.Windows.Forms.GroupBox();
            this.informationRichTextBox = new System.Windows.Forms.RichTextBox();
            this.phpStatusPictureBox = new System.Windows.Forms.PictureBox();
            this.nginxStatusPictureBox = new System.Windows.Forms.PictureBox();
            this.phpButton = new System.Windows.Forms.Button();
            this.phpLabel = new System.Windows.Forms.Label();
            this.nginxButton = new System.Windows.Forms.Button();
            this.nginxLabel = new System.Windows.Forms.Label();
            this.controlPanelPanel.SuspendLayout();
            this.informationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phpStatusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nginxStatusPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanelLabel
            // 
            this.controlPanelLabel.AutoSize = true;
            this.controlPanelLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.controlPanelLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.controlPanelLabel.Location = new System.Drawing.Point(3, 0);
            this.controlPanelLabel.Name = "controlPanelLabel";
            this.controlPanelLabel.Size = new System.Drawing.Size(140, 28);
            this.controlPanelLabel.TabIndex = 0;
            this.controlPanelLabel.Text = "Control panel";
            // 
            // controlPanelPanel
            // 
            this.controlPanelPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanelPanel.Controls.Add(this.informationGroupBox);
            this.controlPanelPanel.Controls.Add(this.phpStatusPictureBox);
            this.controlPanelPanel.Controls.Add(this.nginxStatusPictureBox);
            this.controlPanelPanel.Controls.Add(this.phpButton);
            this.controlPanelPanel.Controls.Add(this.phpLabel);
            this.controlPanelPanel.Controls.Add(this.nginxButton);
            this.controlPanelPanel.Controls.Add(this.nginxLabel);
            this.controlPanelPanel.Location = new System.Drawing.Point(3, 48);
            this.controlPanelPanel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.controlPanelPanel.Name = "controlPanelPanel";
            this.controlPanelPanel.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.controlPanelPanel.Size = new System.Drawing.Size(413, 205);
            this.controlPanelPanel.TabIndex = 1;
            // 
            // informationGroupBox
            // 
            this.informationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informationGroupBox.Controls.Add(this.informationRichTextBox);
            this.informationGroupBox.Location = new System.Drawing.Point(164, 13);
            this.informationGroupBox.Name = "informationGroupBox";
            this.informationGroupBox.Size = new System.Drawing.Size(246, 189);
            this.informationGroupBox.TabIndex = 6;
            this.informationGroupBox.TabStop = false;
            this.informationGroupBox.Text = "Info";
            // 
            // informationRichTextBox
            // 
            this.informationRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informationRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.informationRichTextBox.Location = new System.Drawing.Point(6, 22);
            this.informationRichTextBox.Name = "informationRichTextBox";
            this.informationRichTextBox.Size = new System.Drawing.Size(234, 161);
            this.informationRichTextBox.TabIndex = 0;
            this.informationRichTextBox.Text = "";
            // 
            // phpStatusPictureBox
            // 
            this.phpStatusPictureBox.Image = global::nginx_php_manager.Properties.Resources.running;
            this.phpStatusPictureBox.Location = new System.Drawing.Point(13, 42);
            this.phpStatusPictureBox.Name = "phpStatusPictureBox";
            this.phpStatusPictureBox.Size = new System.Drawing.Size(16, 16);
            this.phpStatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.phpStatusPictureBox.TabIndex = 5;
            this.phpStatusPictureBox.TabStop = false;
            // 
            // nginxStatusPictureBox
            // 
            this.nginxStatusPictureBox.Image = global::nginx_php_manager.Properties.Resources.stopped;
            this.nginxStatusPictureBox.Location = new System.Drawing.Point(13, 13);
            this.nginxStatusPictureBox.Name = "nginxStatusPictureBox";
            this.nginxStatusPictureBox.Size = new System.Drawing.Size(16, 16);
            this.nginxStatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nginxStatusPictureBox.TabIndex = 4;
            this.nginxStatusPictureBox.TabStop = false;
            // 
            // phpButton
            // 
            this.phpButton.Location = new System.Drawing.Point(83, 39);
            this.phpButton.Name = "phpButton";
            this.phpButton.Size = new System.Drawing.Size(75, 23);
            this.phpButton.TabIndex = 3;
            this.phpButton.Text = "Start";
            this.phpButton.UseVisualStyleBackColor = true;
            // 
            // phpLabel
            // 
            this.phpLabel.AutoSize = true;
            this.phpLabel.Location = new System.Drawing.Point(35, 43);
            this.phpLabel.Name = "phpLabel";
            this.phpLabel.Size = new System.Drawing.Size(31, 15);
            this.phpLabel.TabIndex = 2;
            this.phpLabel.Text = "Php:";
            // 
            // nginxButton
            // 
            this.nginxButton.Location = new System.Drawing.Point(83, 10);
            this.nginxButton.Name = "nginxButton";
            this.nginxButton.Size = new System.Drawing.Size(75, 23);
            this.nginxButton.TabIndex = 1;
            this.nginxButton.Text = "Start";
            this.nginxButton.UseVisualStyleBackColor = true;
            this.nginxButton.Click += new System.EventHandler(this.nginxButton_Click);
            // 
            // nginxLabel
            // 
            this.nginxLabel.AutoSize = true;
            this.nginxLabel.Location = new System.Drawing.Point(35, 14);
            this.nginxLabel.Name = "nginxLabel";
            this.nginxLabel.Size = new System.Drawing.Size(42, 15);
            this.nginxLabel.TabIndex = 0;
            this.nginxLabel.Text = "Nginx:";
            // 
            // ControlPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlPanelPanel);
            this.Controls.Add(this.controlPanelLabel);
            this.Name = "ControlPanelControl";
            this.Size = new System.Drawing.Size(419, 256);
            this.controlPanelPanel.ResumeLayout(false);
            this.controlPanelPanel.PerformLayout();
            this.informationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phpStatusPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nginxStatusPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label controlPanelLabel;
        private System.Windows.Forms.Panel controlPanelPanel;
        private System.Windows.Forms.PictureBox phpStatusPictureBox;
        private System.Windows.Forms.PictureBox nginxStatusPictureBox;
        private System.Windows.Forms.Button phpButton;
        private System.Windows.Forms.Label phpLabel;
        private System.Windows.Forms.Button nginxButton;
        private System.Windows.Forms.Label nginxLabel;
        private System.Windows.Forms.GroupBox informationGroupBox;
        private System.Windows.Forms.RichTextBox informationRichTextBox;
    }
}