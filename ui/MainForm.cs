using System;
using System.Windows.Forms;
using nginx_php_manager.lib;

namespace nginx_php_manager.ui
{
    public partial class MainForm : Form
    {
        public enum ProcessTypes
        {
            NGINX,
            PHP,
            NONE
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            registerEvents();
            loadConfig();
        }

        private void checkSettings()
        {
            if(Config.config != null)
            {
                if(!ProcessManagement.isPathValid(
                        Config.config.php.directory.Trim('\\'),
                        ProcessManagement.phpExecutable
                        )
                    )
                {
                    startPhpTrayToolStripMenuItem.Enabled = false;
                    stopPhpTrayToolStripMenuItem.Enabled = false;
                }
                else
                {
                    configTrayControl(ProcessTypes.PHP);
                }

                if(!ProcessManagement.isPathValid(
                        Config.config.nginx.directory.Trim('\\'),
                        ProcessManagement.nginxExecutable
                        )
                    )
                {
                    startNginxTrayToolStripMenuItem.Enabled = false;
                    stopNginxTrayToolStripMenuItem.Enabled = false;
                }
                else
                {
                    configTrayControl(ProcessTypes.NGINX);
                }
            }
            else
            {
                configTrayControl(ProcessTypes.NONE);
            }
        }

        private void configTrayControl(ProcessTypes process)
        {
            switch (process)
            {
                case ProcessTypes.PHP:
                    if (ProcessManagement.isProcessAlreadyRunning(
                        ProcessManagement.phpProcessName
                        ))
                    {
                        startPhpTrayToolStripMenuItem.Enabled = false;
                        stopPhpTrayToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        startPhpTrayToolStripMenuItem.Enabled = true;
                        stopPhpTrayToolStripMenuItem.Enabled = false;
                    }
                    break;
                case ProcessTypes.NGINX:
                    if (ProcessManagement.isProcessAlreadyRunning(
                        ProcessManagement.nginxProcessName
                        ))
                    {
                        startNginxTrayToolStripMenuItem.Enabled = false;
                        stopNginxTrayToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        startNginxTrayToolStripMenuItem.Enabled = true;
                        stopNginxTrayToolStripMenuItem.Enabled = false;
                    }
                    break;
                case ProcessTypes.NONE:
                    startPhpTrayToolStripMenuItem.Enabled = false;
                    stopPhpTrayToolStripMenuItem.Enabled = false;
                    startNginxTrayToolStripMenuItem.Enabled = false;
                    stopNginxTrayToolStripMenuItem.Enabled = false;
                    break;

            }
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
                }
                else if(result == DialogResult.Yes)
                {
                    Config.save();
                }

                if (!closeToTrayToolStripMenuItem.Checked)
                {
                    return;
                }
            }

            if (closeToTrayToolStripMenuItem.Checked && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                hideMainFormToTray();
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
            showMainFormFromTray();
        }

        private void hideMainFormToTray()
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            mainNotifyIcon.Visible = true;
        }

        private void showMainFormFromTray()
        {
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
            mainNotifyIcon.Visible = false;
        }

        private void showFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showMainFormFromTray();
        }

        private void exitTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startPhpTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessManagement.startPhpProcess();
        }

        private void stopPhpTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessManagement.stopPhpProcess();
        }

        private void startNginxTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessManagement.startNginxProcess();
        }

        private void stopNginxTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessManagement.stopNginxProcess();
        }

        private void registerEvents()
        {
            Config.configRead += onConfigRead;

            ProcessManagement.phpStarted += onPhpStarted;
            ProcessManagement.phpStopped += onPhpStopped;

            ProcessManagement.nginxStarted += onNginxStarted;
            ProcessManagement.nginxStopped += onNginxStopped;
        }

        private void changePhpStatus(ProcessManagement.ProcessStatus status)
        {
            if(status == ProcessManagement.ProcessStatus.RUNNING)
            {
                stopPhpTrayToolStripMenuItem.Enabled = true;
                startPhpTrayToolStripMenuItem.Enabled = false;
            }
            else
            {
                stopPhpTrayToolStripMenuItem.Enabled = false;
                startPhpTrayToolStripMenuItem.Enabled = true;
            }
        }

        private void changeNginxStatus(ProcessManagement.ProcessStatus status)
        {
            if(status == ProcessManagement.ProcessStatus.RUNNING)
            {
                stopNginxTrayToolStripMenuItem.Enabled = true;
                startNginxTrayToolStripMenuItem.Enabled = false;
            }
            else
            {
                stopNginxTrayToolStripMenuItem.Enabled = false;
                startNginxTrayToolStripMenuItem.Enabled = true;
            }
        }

        private void onConfigRead(object read)
        {
            checkSettings();
        }

        private void onPhpStarted(bool started)
        {
            if (started)
            {
                changePhpStatus(ProcessManagement.ProcessStatus.RUNNING);
            }
            else
            {
                changePhpStatus(ProcessManagement.ProcessStatus.STOPPED);
            }
        }

        private void onPhpStopped(bool stopped)
        {
            if (stopped)
            {
                changePhpStatus(ProcessManagement.ProcessStatus.STOPPED);
            }
            else
            {
                changePhpStatus(ProcessManagement.ProcessStatus.RUNNING);
            }
        }

        private void onNginxStarted(bool started)
        {
            if (started)
            {
                changeNginxStatus(ProcessManagement.ProcessStatus.RUNNING);
            }
            else
            {
                changeNginxStatus(ProcessManagement.ProcessStatus.STOPPED);
            }
        }

        private void onNginxStopped(bool stopped)
        {
            if (stopped)
            {
                changeNginxStatus(ProcessManagement.ProcessStatus.STOPPED);
            }
            else
            {
                changeNginxStatus(ProcessManagement.ProcessStatus.RUNNING);
            }
        }
    }
}
