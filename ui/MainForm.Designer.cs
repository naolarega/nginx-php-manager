
namespace nginx_php_manager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mainFormToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainFormToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.mainFormTabControl = new System.Windows.Forms.TabControl();
            this.controlTabPage = new System.Windows.Forms.TabPage();
            this.nginxTabPage = new System.Windows.Forms.TabPage();
            this.phpTabPage = new System.Windows.Forms.TabPage();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.nginxControl1 = new nginx_php_manager.ui.NginxControl();
            this.phpControl1 = new nginx_php_manager.ui.PhpControl();
            this.mainFormMenuStrip.SuspendLayout();
            this.mainFormStatusStrip.SuspendLayout();
            this.mainFormTabControl.SuspendLayout();
            this.nginxTabPage.SuspendLayout();
            this.phpTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormMenuStrip
            // 
            this.mainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainFormMenuStrip.Name = "mainFormMenuStrip";
            this.mainFormMenuStrip.Size = new System.Drawing.Size(624, 24);
            this.mainFormMenuStrip.TabIndex = 0;
            this.mainFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Setti&ngs";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // mainFormStatusStrip
            // 
            this.mainFormStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainFormToolStripStatusLabel,
            this.mainFormToolStripProgressBar});
            this.mainFormStatusStrip.Location = new System.Drawing.Point(0, 319);
            this.mainFormStatusStrip.Name = "mainFormStatusStrip";
            this.mainFormStatusStrip.Size = new System.Drawing.Size(624, 22);
            this.mainFormStatusStrip.TabIndex = 1;
            this.mainFormStatusStrip.Text = "statusStrip1";
            // 
            // mainFormToolStripStatusLabel
            // 
            this.mainFormToolStripStatusLabel.Name = "mainFormToolStripStatusLabel";
            this.mainFormToolStripStatusLabel.Size = new System.Drawing.Size(29, 17);
            this.mainFormToolStripStatusLabel.Text = "N/A";
            // 
            // mainFormToolStripProgressBar
            // 
            this.mainFormToolStripProgressBar.Name = "mainFormToolStripProgressBar";
            this.mainFormToolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // mainFormTabControl
            // 
            this.mainFormTabControl.Controls.Add(this.controlTabPage);
            this.mainFormTabControl.Controls.Add(this.nginxTabPage);
            this.mainFormTabControl.Controls.Add(this.phpTabPage);
            this.mainFormTabControl.Controls.Add(this.settingsTabPage);
            this.mainFormTabControl.Location = new System.Drawing.Point(13, 28);
            this.mainFormTabControl.Name = "mainFormTabControl";
            this.mainFormTabControl.SelectedIndex = 0;
            this.mainFormTabControl.Size = new System.Drawing.Size(599, 288);
            this.mainFormTabControl.TabIndex = 2;
            // 
            // controlTabPage
            // 
            this.controlTabPage.Location = new System.Drawing.Point(4, 24);
            this.controlTabPage.Name = "controlTabPage";
            this.controlTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.controlTabPage.Size = new System.Drawing.Size(591, 260);
            this.controlTabPage.TabIndex = 0;
            this.controlTabPage.Text = "Control";
            this.controlTabPage.UseVisualStyleBackColor = true;
            // 
            // nginxTabPage
            // 
            this.nginxTabPage.Controls.Add(this.nginxControl1);
            this.nginxTabPage.Location = new System.Drawing.Point(4, 24);
            this.nginxTabPage.Name = "nginxTabPage";
            this.nginxTabPage.Size = new System.Drawing.Size(591, 260);
            this.nginxTabPage.TabIndex = 1;
            this.nginxTabPage.Text = "Nginx";
            this.nginxTabPage.UseVisualStyleBackColor = true;
            // 
            // phpTabPage
            // 
            this.phpTabPage.Controls.Add(this.phpControl1);
            this.phpTabPage.Location = new System.Drawing.Point(4, 24);
            this.phpTabPage.Name = "phpTabPage";
            this.phpTabPage.Size = new System.Drawing.Size(591, 260);
            this.phpTabPage.TabIndex = 2;
            this.phpTabPage.Text = "Php";
            this.phpTabPage.UseVisualStyleBackColor = true;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Location = new System.Drawing.Point(4, 24);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Size = new System.Drawing.Size(591, 260);
            this.settingsTabPage.TabIndex = 3;
            this.settingsTabPage.Text = "Settings";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // nginxControl1
            // 
            this.nginxControl1.Location = new System.Drawing.Point(3, 3);
            this.nginxControl1.Name = "nginxControl1";
            this.nginxControl1.Size = new System.Drawing.Size(585, 254);
            this.nginxControl1.TabIndex = 0;
            // 
            // phpControl1
            // 
            this.phpControl1.Location = new System.Drawing.Point(3, 3);
            this.phpControl1.Name = "phpControl1";
            this.phpControl1.Size = new System.Drawing.Size(585, 254);
            this.phpControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 341);
            this.Controls.Add(this.mainFormTabControl);
            this.Controls.Add(this.mainFormStatusStrip);
            this.Controls.Add(this.mainFormMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainFormMenuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 380);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 380);
            this.Name = "MainForm";
            this.Text = "Nginx php manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainFormMenuStrip.ResumeLayout(false);
            this.mainFormMenuStrip.PerformLayout();
            this.mainFormStatusStrip.ResumeLayout(false);
            this.mainFormStatusStrip.PerformLayout();
            this.mainFormTabControl.ResumeLayout(false);
            this.nginxTabPage.ResumeLayout(false);
            this.phpTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainFormStatusStrip;
        private System.Windows.Forms.TabControl mainFormTabControl;
        private System.Windows.Forms.TabPage controlTabPage;
        private System.Windows.Forms.TabPage nginxTabPage;
        private System.Windows.Forms.TabPage phpTabPage;
        private System.Windows.Forms.ToolStripStatusLabel mainFormToolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar mainFormToolStripProgressBar;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private ui.NginxControl nginxControl1;
        private ui.PhpControl phpControl1;
    }
}

