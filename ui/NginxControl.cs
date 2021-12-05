using System;
using System.Windows.Forms;
using nginx_php_manager.lib;

namespace nginx_php_manager.ui
{
    public partial class NginxControl : UserControl
    {
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
                if (Config.config != null)
                {
                    if (Config.config.nginx != null)
                    {
                        Config.config.nginx.directory = nginxDirectoryTextBox.Text;
                    }
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
                if(Config.config != null)
                {
                    if(Config.config.nginx != null)
                    {
                        Config.config.nginx.configFile = nginxConfigTextBox.Text;
                    }
                }
            }
        }

        private void assignValues()
        {
            nginxConfigTextBox.Text = Config.config.nginx.configFile;
            nginxDirectoryTextBox.Text = Config.config.nginx.directory;
        }

        private void NginxControl_Load(object sender, EventArgs e)
        {
            Config.init();
            assignValues();
        }
    }
}
