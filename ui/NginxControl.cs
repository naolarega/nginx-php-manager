using System;
using System.Windows.Forms;
using nginx_php_manager.lib;

namespace nginx_php_manager.ui
{
    public partial class NginxControl : UserControl
    {
        public bool assigningFromConfig = false;

        public NginxControl()
        {
            InitializeComponent();
        }

        private void nginxDirectoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog nginxDirectoryDialog = new FolderBrowserDialog();

            if(nginxDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                nginxDirectoryTextBox.Text = nginxDirectoryDialog.SelectedPath;
                assignNginxDirectory(nginxDirectoryTextBox.Text);
            }
        }

        private void assignNginxDirectory(string path)
        {
            if (Config.config != null)
            {
                if (Config.config.nginx != null)
                {
                    Config.config.nginx.directory = path;
                }
            }
        }

        private void nginxConfigButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog nginxConfigFileDialog = new OpenFileDialog();
            nginxConfigFileDialog.Filter = "Nginx config (*.conf)|*.conf";
            nginxConfigFileDialog.Multiselect = false;

            if (nginxConfigFileDialog.ShowDialog() == DialogResult.OK)
            {
                nginxConfigTextBox.Text = nginxConfigFileDialog.FileName;
                assignNginxConfigFile(nginxConfigTextBox.Text);
            }
        }

        private void assignNginxConfigFile(string path)
        {
            if (Config.config != null)
            {
                if (Config.config.nginx != null)
                {
                    Config.config.nginx.configFile = path;
                }
            }
        }

        private void assignValues()
        {
            assigningFromConfig = true;
            nginxConfigTextBox.Text = Config.config.nginx.configFile;
            nginxDirectoryTextBox.Text = Config.config.nginx.directory;
            assigningFromConfig = false;
        }

        private void NginxControl_Load(object sender, EventArgs e)
        {
            Config.init();
            assignValues();
        }

        private void nginxConfigFile_TextChanged(object sender, EventArgs e)
        {
            assignNginxConfigFile(nginxConfigTextBox.Text);
            if (!assigningFromConfig)
            {
                Config.modified = true;
            }
        }

        private void nginxDirectory_TextChanged(object sender, EventArgs e)
        {
            assignNginxDirectory(nginxDirectoryTextBox.Text);
            if (!assigningFromConfig)
            {
                Config.modified = true;
            }
        }
    }
}
