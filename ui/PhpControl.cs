using System;
using System.Windows.Forms;
using nginx_php_manager.lib;

namespace nginx_php_manager.ui
{
    public partial class PhpControl : UserControl
    {
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
                if (Config.config != null)
                {
                    if (Config.config.php != null)
                    {
                        Config.config.php.directory = phpDirectoryTextBox.Text;
                    }
                }
            }
        }

        private void phpAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            Config.config.php.address = phpAddressTextBox.Text;
        }

        private void phpPortNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Config.config.php.port = phpPortNumericUpDown.Value;
        }



        private void assignValues()
        {
            phpDirectoryTextBox.Text = Config.config.php.directory;
            phpAddressTextBox.Text = Config.config.php.address;
            phpPortNumericUpDown.Value = Config.config.php.port;
        }

        private void PhpControl_Load(object sender, EventArgs e)
        {
            Config.init();
            assignValues();
        }
    }
}
