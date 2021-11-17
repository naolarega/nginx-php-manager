using System.Windows.Forms;
using nginx_php_manager.lib;
using nginx_php_manager.model;

namespace nginx_php_manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
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

                Config.config = new ConfigModel();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Config.modified)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to exit without saving!",
                    "Notice",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation
                    );

                if (result == DialogResult.Cancel || result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainFormTabControl.SelectedTab = mainFormTabControl.TabPages["settingsTabPage"];
        }
    }
}
