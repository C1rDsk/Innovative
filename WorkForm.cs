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
    public partial class WorkForm : Form
    {
        public string login, password,workPath;
        bool offlineMode;
        private Int32 tmpX;
        private Int32 tmpY;
        private bool flMove = false;
        private void WorkForm_MouseDown(object sender, MouseEventArgs e)
        {
            tmpX = Cursor.Position.X;
            tmpY = Cursor.Position.Y;
            flMove = true;
        }

        private void WorkForm_MouseUp(object sender, MouseEventArgs e)
        {
            flMove = false;
        }

        private void WorkForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (flMove)
            {
                this.Left = this.Left + (Cursor.Position.X - tmpX);
                this.Top = this.Top + (Cursor.Position.Y - tmpY);

                tmpX = Cursor.Position.X;
                tmpY = Cursor.Position.Y;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ftp.LoadOnZip(workPath + login);
            ftp.ListZip(workPath + login,ref listFilesServer);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.Show();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
        }

        public WorkForm(string login, string password, bool offline,string path)
        {
            this.login = login;
            this.password = password;
            this.offlineMode = offline;
            this.workPath = path;
            InitializeComponent();
        }

        private void WorkForm_Load(object sender, EventArgs e)
        {
            workPath= ConfigurationManager.AppSettings.Get("path");
            this.loginLabel.Text = login;
            ftp.createZip(workPath + login);
            ftp.ListZip(workPath + login, ref listFilesServer);
        }
    }
}
