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
            if(nginxStatus == ProcessStatus.RUNNING)
            {
                changeNginxStatus(ProcessStatus.PAUSED);
            }
            else
            {
                ProcessManagement.startNginxProcess();
                changeNginxStatus(ProcessStatus.RUNNING);
            }
        }

        private void ControlPanelControl_Load(object sender, EventArgs e)
        {
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
                nginxStatusPictureBox.Image = Resources.running;
                nginxStartButton.Text = "Pause";
                nginxStopButton.Enabled = true;
            }
            else if (nginxStatus == ProcessStatus.PAUSED)
            {
                nginxStatusPictureBox.Image = Resources.paused;
                nginxStartButton.Text = "Continue";
                nginxStopButton.Enabled = true;
            }
            else
            {
                nginxStatusPictureBox.Image = Resources.stopped;
                nginxStartButton.Text = "Start";
                nginxStopButton.Enabled = false;
            }
        }

        private void checkPhpStatus()
        {
            if (phpStatus == ProcessStatus.RUNNING)
            {
                phpStatusPictureBox.Image = Resources.running;
                phpStartButton.Text = "Pause";
                phpStopButton.Enabled = true;
            }
            else if (phpStatus == ProcessStatus.PAUSED)
            {
                phpStatusPictureBox.Image = Resources.paused;
                phpStartButton.Text = "Continue";
                phpStopButton.Enabled = true;
            }
            else
            {
                phpStatusPictureBox.Image = Resources.stopped;
                phpStartButton.Text = "Start";
                phpStopButton.Enabled = false;
            }
        }

        private void nginxStopButton_Click(object sender, EventArgs e)
        {
            changeNginxStatus(ProcessStatus.STOPPED);
        }

        private void phpStartButton_Click(object sender, EventArgs e)
        {
            if(phpStatus == ProcessStatus.RUNNING)
            {
                changephpStatus(ProcessStatus.PAUSED);
            }
            else
            {
                ProcessManagement.startPhpProcess();
                changephpStatus(ProcessStatus.RUNNING);
            }
        }

        private void phpStopButton_Click(object sender, EventArgs e)
        {
            changephpStatus(ProcessStatus.STOPPED);
        }
    }
}
