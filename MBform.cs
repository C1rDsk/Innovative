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
    public partial class MBform : Form
    {
        string message;
        public MBform(string message)
        {
            InitializeComponent();
            this.Show();
            label2.Text = message;
        }
        public MBform(string title,string message)
        {
            InitializeComponent();
            this.Show();
            label1.Text = title;
            label2.Text = message;
        }

        private void MBform_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
