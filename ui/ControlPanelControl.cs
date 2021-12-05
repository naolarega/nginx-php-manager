using System;
using System.Windows.Forms;
using nginx_php_manager.Properties;
using nginx_php_manager.lib;

namespace nginx_php_manager.ui
{
    public partial class ControlPanelControl : UserControl
    {
        private enum ProcessStatus
        {
            RUNNING,
            PAUSED,
            STOPPED
        };
        private ProcessStatus nginxStatus = ProcessStatus.STOPPED;
        private ProcessStatus phpStatus = ProcessStatus.STOPPED;

        public ControlPanelControl()
        {
            InitializeComponent();
        }

        private void nginxStartButton_Click(object sender, EventArgs e)
        {
            if (ProcessManagement.startNginxProcess())
            {
                changeNginxStatus(ProcessStatus.RUNNING);
            }
            else
            {
                changeNginxStatus(ProcessStatus.STOPPED);
            }
        }

        private void ControlPanelControl_Load(object sender, EventArgs e)
        {
            if(ProcessManagement.isProcessAlreadyRunning(
                ProcessManagement.nginxProcessName
                ))
            {
                changeNginxStatus(ProcessStatus.RUNNING);
            }

            if(ProcessManagement.isProcessAlreadyRunning(
                ProcessManagement.phpProcessName
                ))
            {
                changephpStatus(ProcessStatus.RUNNING);
            }
            registerEvents();
            checkNginxStatus();
            checkPhpStatus();
        }

        private void changeNginxStatus(ProcessStatus status)
        {
            nginxStatus = status;
            checkNginxStatus();
        }

        private void changephpStatus(ProcessStatus status)
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
            if (ProcessManagement.startPhpProcess())
            {
                changephpStatus(ProcessStatus.RUNNING);
            }
        }

        private void phpStopButton_Click(object sender, EventArgs e)
        {
            ProcessManagement.stopPhpProcess();
        }

        private void registerEvents()
        {
            ProcessManagement.nginxDataRecieved += onNginxDataRecieved;
            ProcessManagement.nginxErrorRecieved += onNginxErrorRecieved;
            ProcessManagement.nginxExited += onNginxExited;

            ProcessManagement.phpDataRecieved += onPhpDataRecieved;
            ProcessManagement.phpErrorRecieved += onPhpErrorRecieved;
            ProcessManagement.phpExited += onPhpExited;
        }
        
        public void onNginxDataRecieved(string e)
        {
            MessageBox.Show(
                e,
                "Nginx message",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        public void onNginxErrorRecieved(string e)
        {
            MessageBox.Show(
                e,
                "Nginx error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }

        public void onNginxExited(int e)
        {
            changeNginxStatus(ProcessStatus.STOPPED);
            MessageBox.Show(
                string.Format("Exited with : {0}", e),
                "Nginx exited",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        public void onPhpDataRecieved(string e)
        {
            MessageBox.Show(
                e,
                "Php message",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        public void onPhpErrorRecieved(string e)
        {
            MessageBox.Show(
                e,
                "Php error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }

        public void onPhpExited(int e)
        {
            changephpStatus(ProcessStatus.STOPPED);
            MessageBox.Show(
                string.Format("Exited with : {0}", e),
                "Php exited",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }
}
