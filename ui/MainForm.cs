using System;
using System.Windows.Forms;
using nginx_php_manager.lib;

namespace nginx_php_manager.ui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadConfig();
        }

        private void loadConfig()
        {
            Config.read();
            if(Config.status == Config.ConfigStatus.FAILED)
            {
                MessageBox.Show(
                    "Unable to read configuration!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else if(Config.status == Config.ConfigStatus.NO_CONFIG)
            {
                DialogResult result = MessageBox.Show(
                    "No configuration available!",
                    "Notice",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );

                Config.init();
            }
            assignSettings();
        }

        private void assignSettings()
        {
            if(Config.config != null)
            {
                closeToTrayToolStripMenuItem.Checked = Config.config.general.closeToTray;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Config.modified)
            {
                DialogResult result = MessageBox.Show(
                    "You haven't saved your settings, do you want to save it!",
                    "Notice",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation
                    );

                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                else if(result == DialogResult.Yes)
                {
                    Config.save();
                    return;
                }
            }

            if (closeToTrayToolStripMenuItem.Checked)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                mainNotifyIcon.Visible = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config.save();
        }

        private void nginxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainFormTabControl.SelectedTab = mainFormTabControl.TabPages["nginxTabPage"];
        }

        private void phpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainFormTabControl.SelectedTab = mainFormTabControl.TabPages["phpTabPage"];
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutDialog = new AboutForm();
            aboutDialog.ShowDialog();
        }

        private void closeToTrayToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if(Config.config != null)
            {
                Config.config.general.closeToTray = closeToTrayToolStripMenuItem.Checked;
                Config.save();
            }
        }

        private void mainNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            mainNotifyIcon.Visible = false;
        }
    }
}
