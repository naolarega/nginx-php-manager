using System;
using System.Windows.Forms;
using nginx_php_manager.lib;

namespace nginx_php_manager.ui
{
    public partial class PhpControl : UserControl
    {
        private bool assigningFromConfig = false;

        public PhpControl()
        {
            InitializeComponent();
        }

        private void phpDirectoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog phpDirectoryDialog = new FolderBrowserDialog();

            if (phpDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                phpDirectoryTextBox.Text = phpDirectoryDialog.SelectedPath;
                assignPhpDirectory(phpDirectoryTextBox.Text);
            }
        }

        public void assignPhpDirectory(string path)
        {
            if (Config.config != null)
            {
                if (Config.config.php != null)
                {
                    Config.config.php.directory = path;
                }
            }
        }

        private void phpAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Config.config != null)
            {
                if (Config.config.php != null)
                {
                    Config.config.php.address = phpAddressTextBox.Text;
                    if (!assigningFromConfig)
                    {
                        Config.modified = true;
                    }
                }
            }
        }

        private void phpPortNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Config.config != null)
            {
                if (Config.config.php != null)
                {
                    Config.config.php.port = phpPortNumericUpDown.Value;
                    if (!assigningFromConfig)
                    {
                        Config.modified = true;
                    }
                }
            }
        }

        private void assignValues()
        {
            assigningFromConfig = true;
            phpDirectoryTextBox.Text = Config.config.php.directory;
            phpAddressTextBox.Text = Config.config.php.address;
            phpPortNumericUpDown.Value = Config.config.php.port;
            assigningFromConfig = false;
        }

        private void PhpControl_Load(object sender, EventArgs e)
        {
            Config.init();
            assignValues();
        }

        private void phpDirectory_TextChanged(object sender, EventArgs e)
        {
            assignPhpDirectory(phpDirectoryTextBox.Text);
            if (!assigningFromConfig)
            {
                Config.modified = true;
            }
        }
    }
}
