using System.Windows.Forms;
using nginx_php_manager.lib;

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
                    "No configuration availabel, do you want to exist!",
                    "Notice",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation
                    );

                if(result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Config.status == Config.ConfigStatus.SUCCESS)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure!",
                    "Notice",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation
                    );

                if (result == DialogResult.No)
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
