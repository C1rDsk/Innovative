using System;
using System.Collections.Generic;
using System.ComponentModel;
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
               saveFileDialog1.ShowDialog();
               path = saveFileDialog1.FileName;
               headingLabel.Text = path;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
