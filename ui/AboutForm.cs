using System;
using System.Windows.Forms;

namespace nginx_php_manager.ui
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void aboutCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
