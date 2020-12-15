using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innovative
{
    public partial class SettingsForm : Form
    {
        public string path;
        public SettingsForm()
        {
            InitializeComponent();
            this.Show();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void recoveryButton1_Click(object sender, EventArgs e)
        {
            string path = null;
            using (var dialog = new FolderBrowserDialog())
                if (dialog.ShowDialog() == DialogResult.OK)
                    path = dialog.SelectedPath + "\\";
            ConfigurationManager.AppSettings.Set("path", path);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
