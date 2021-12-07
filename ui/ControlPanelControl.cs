using System;
using System.Windows.Forms;
using nginx_php_manager.lib;
using nginx_php_manager.Properties;

namespace nginx_php_manager.ui
{
    public partial class ControlPanelControl : UserControl
    {
        private enum ProcessStatus
        {
            RUNNING,
            PAUSED,
            STOPPED,
            NONE
        };
        private ProcessStatus nginxStatus = ProcessStatus.NONE;
        private ProcessStatus phpStatus = ProcessStatus.NONE;

        public ControlPanelControl()
        {
            InitializeComponent();
        }

        private void nginxStartButton_Click(object sender, EventArgs e)
        {
            ProcessManagement.startNginxProcess();
        }

        private void ControlPanelControl_Load(object sender, EventArgs e)
        {
            registerEvents();
        }

        private void checkSettings()
        {
            if (Config.config != null)
            {
                if (!ProcessManagement.isPathValid(
                        Config.config.php.directory.Trim('\\'),
                        ProcessManagement.phpExecutable
                        )
                    )
                {
                    changePhpStatus(ProcessStatus.NONE);
                }
                else if (ProcessManagement.isProcessAlreadyRunning(
                    ProcessManagement.phpProcessName
                    ))
                {
                    changePhpStatus(ProcessStatus.RUNNING);
                }
                else
                {
                    changePhpStatus(ProcessStatus.STOPPED);
                }

                if (!ProcessManagement.isPathValid(
                        Config.config.nginx.directory.Trim('\\'),
                        ProcessManagement.nginxExecutable
                        )
                    )
                {
                    changeNginxStatus(ProcessStatus.NONE);
                }
                else if (ProcessManagement.isProcessAlreadyRunning(
                    ProcessManagement.nginxProcessName
                    ))
                {
                    changeNginxStatus(ProcessStatus.RUNNING);
                }
                else
                {
                    changeNginxStatus(ProcessStatus.STOPPED);
                }
            }
            else
            {
                changeNginxStatus(ProcessStatus.NONE);
                changePhpStatus(ProcessStatus.NONE);
            }
            checkPhpStatus();
            checkNginxStatus();
        }

        private void changeNginxStatus(ProcessStatus status)
        {
            nginxStatus = status;
            checkNginxStatus();
        }

        private void changePhpStatus(ProcessStatus status)
        {
            phpStatus = status;
            checkPhpStatus();
        }

        private void checkNginxStatus()
        {
            if(nginxStatus == ProcessStatus.RUNNING)
            {
                nginxStatusPictureBox.PerformSafely(() => nginxStatusPictureBox.Image = Resources.running);
                nginxStopButton.PerformSafely(() => nginxStopButton.Enabled = true);
                nginxStartButton.PerformSafely(() => nginxStartButton.Enabled = false);
            }
            else if (nginxStatus == ProcessStatus.NONE)
            {
                nginxStatusPictureBox.PerformSafely(() => nginxStatusPictureBox.Image = Resources.stopped);
                nginxStopButton.PerformSafely(() => nginxStopButton.Enabled = false);
                nginxStartButton.PerformSafely(() => nginxStartButton.Enabled = false);
            }
            else
            {
                nginxStatusPictureBox.PerformSafely(() => nginxStatusPictureBox.Image = Resources.stopped);
                nginxStopButton.PerformSafely(() => nginxStopButton.Enabled = false);
                nginxStartButton.PerformSafely(() => nginxStartButton.Enabled = true);
            }
        }

        private void checkPhpStatus()
        {
            if (phpStatus == ProcessStatus.RUNNING)
            {
                phpStatusPictureBox.PerformSafely(() => phpStatusPictureBox.Image = Resources.running);
                phpStopButton.PerformSafely(() => phpStopButton.Enabled = true);
                phpStartButton.PerformSafely(() => phpStartButton.Enabled = false);
            }
            else if (phpStatus == ProcessStatus.NONE)
            {
                phpStatusPictureBox.PerformSafely(() => phpStatusPictureBox.Image = Resources.stopped);
                phpStopButton.PerformSafely(() => phpStopButton.Enabled = false);
                phpStartButton.PerformSafely(() => phpStartButton.Enabled = false);
            }
            else
            {
                phpStatusPictureBox.PerformSafely(() => phpStatusPictureBox.Image = Resources.stopped);
                phpStopButton.PerformSafely(() => phpStopButton.Enabled = false);
                phpStartButton.PerformSafely(() => phpStartButton.Enabled = true);
            }
        }

        private void nginxStopButton_Click(object sender, EventArgs e)
        {
            ProcessManagement.stopNginxProcess();
        }

        private void phpStartButton_Click(object sender, EventArgs e)
        {
            ProcessManagement.startPhpProcess();
        }

        private void phpStopButton_Click(object sender, EventArgs e)
        {
            ProcessManagement.stopPhpProcess();
        }

        private void registerEvents()
        {
            Config.configRead += onConfigRead;

            ProcessManagement.nginxDataRecieved += onNginxDataRecieved;
            ProcessManagement.nginxErrorRecieved += onNginxErrorRecieved;
            ProcessManagement.nginxStarted += onNginxStarted;
            ProcessManagement.nginxStopped += onNginxStopped;

            ProcessManagement.phpDataRecieved += onPhpDataRecieved;
            ProcessManagement.phpErrorRecieved += onPhpErrorRecieved;
            ProcessManagement.phpStarted += onPhpStarted;
            ProcessManagement.phpStopped += onPhpStopped;
        }

        private void onConfigRead(object read)
        {
            checkSettings();
        }

        private void onPhpStarted(bool started)
        {
            if (started)
            {
                changePhpStatus(ProcessStatus.RUNNING);
            }
            else
            {
                changePhpStatus(ProcessStatus.STOPPED);
            }
        }

        private void onPhpStopped(bool stopped)
        {
            if (stopped)
            {
                changePhpStatus(ProcessStatus.STOPPED);
            }
            else
            {
                changePhpStatus(ProcessStatus.RUNNING);
            }
        }

        private void onNginxStarted(bool started)
        {
            if (started)
            {
                changeNginxStatus(ProcessStatus.RUNNING);
            }
            else
            {
                changeNginxStatus(ProcessStatus.STOPPED);
            }
        }

        private void onNginxStopped(bool stopped)
        {
            if (stopped)
            {
                changeNginxStatus(ProcessStatus.STOPPED);
            }
            else
            {
                changeNginxStatus(ProcessStatus.RUNNING);
            }
        }
        
        private void onNginxDataRecieved(string e)
        {
            MessageBox.Show(
                e,
                "Nginx message",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void onNginxErrorRecieved(string e)
        {
            MessageBox.Show(
                e,
                "Nginx error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }

        private void onPhpDataRecieved(string e)
        {
            MessageBox.Show(
                e,
                "Php message",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void onPhpErrorRecieved(string e)
        {
            MessageBox.Show(
                e,
                "Php error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }
    }
}
