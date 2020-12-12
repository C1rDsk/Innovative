using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Innovative
{
    public partial class LoginForm : Form
    {
        private InnoDB db = new InnoDB();
        private Validation vali = new Validation();
        private Int32 tmpX;
        private Int32 tmpY;
        private bool flMove = false;
        public string captchaValue;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void logForm_Load(object sender, EventArgs e)
        {
            loginTabControl.SelectedIndex = 0;
            //db.openConnection();
            ToolTip CloseToolTip = new ToolTip();
            CloseToolTip.SetToolTip(buttonClose, "Выход"); 
            ToolTip SettingsToolTip = new ToolTip();
            SettingsToolTip.SetToolTip(SettingsButton, "Настройки");
            webBrowser1.Navigate("https://innosite.000webhostapp.com");
            
            //    new MBform(webBrowser1.Document.Cookie);
            
        }

        private void autorizationButton_Click(object sender, EventArgs e)
        {
            db.openConnection();
            String login = authLoginTextBox.Text;
            String password = loginTextBox.Text;
            db.getAuthentication(login, password);
            if (db.getAuthentication(login, password))
            {
                new MBform("Отлично!", "Вход выполнен успешно.");
                this.Hide();
                WorkForm work = new WorkForm();
                work.Show();
            }
        }

        private void authRegButton_Click(object sender, EventArgs e)
        {
            authRegButton.ForeColor = Color.Black;
            loginTabControl.SelectedIndex = 1;
        }

        private void authRecButton_Click(object sender, EventArgs e)
        {
            authRecButton.ForeColor = Color.Black;
            loginTabControl.SelectedIndex = 2;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (captchaValue==capchaTextBox.Text)
            {
                if (vali.IsValidEmail(emailTextBox.Text))
                {
                    if (vali.IsValidLogin(regLoginTextBox.Text))
                    {
                        if (vali.IsValidPassword(regPassTextBox.Text))
                        {
                            db.openConnection();
                            //запись в таблицу БД
                            db.registration(regLoginTextBox.Text, regPassTextBox.Text, emailTextBox.Text, phoneMaskedTextBox.Text, nameTextBox.Text);
                            loginTabControl.SelectedIndex = 1;
                            emailTextBox.Text = "";
                            regLoginTextBox.Text = "";
                            regPassTextBox.Text = "";
                            confirmationTextBox.Text = "";
                            nameTextBox.Text = "";
                            phoneMaskedTextBox.Text = "";

                        }
                        else
                        {
                            new MBform("Пароль должен состоять минимум из 8 символов: \nтолько латинские символы, цифры и спецсимволы");
                        }
                    }
                    else
                    {
                        new MBform("Логин должен состоять минимум из 4 символов:\nнеобходимо использовать только латинские символы и цифры");
                    }
                }
                else
                {
                    new MBform("Некорректный почтовый адрес");
                }

            }
            else
            {

                webBrowser1.Refresh();
                string str = webBrowser1.Document.Cookie;
                string[] mas = new string[3];
                if (str != null)
                {
                    mas = str.Split('=');
                    captchaValue = mas[2];
                }
                new MBform("Некорректно введена capcha");
            }
        }
        private void authRegButton_Click_1(object sender, EventArgs e)
        {
            authRegButton.ForeColor = Color.Black;
            loginTabControl.SelectedIndex = 1;
        }

        private void authRecButton_Click_1(object sender, EventArgs e)
        {
            authRecButton.ForeColor = Color.Black;
            loginTabControl.SelectedIndex = 2;
        }

        private void recoveryButton1_Click(object sender, EventArgs e)
        {
            String login = loginTextBox.Text;
            db.recovery(login);  
        }

        public void Close(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Firebrick;
            System.Windows.Forms.Application.Exit();
        }
        public void Back(object sender, EventArgs e)
        {
            loginTabControl.SelectedIndex = 0;
        }
        public void Entr(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox tb = (TextBox)sender;
                tb.BackColor = Color.White;
            }
            else if (sender is MaskedTextBox)
            {
                MaskedTextBox rtb = (MaskedTextBox)sender;
                rtb.BackColor = Color.White;
            }
        }
        public void LiavMistyRose(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.MistyRose;
        }
        public void LiavGreen(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox tb = (TextBox)sender;
                tb.BackColor = Color.Honeydew;
            }
            else if (sender is MaskedTextBox)
            {
                MaskedTextBox rtb = (MaskedTextBox)sender;
                rtb.BackColor = Color.Honeydew;
            }
        }

        private void FullScreenPanel_MouseDown(object sender, MouseEventArgs e)
        {
            tmpX = Cursor.Position.X;
            tmpY = Cursor.Position.Y;
            flMove = true;
        }

        private void FullScreenPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (flMove)
            {
                this.Left = this.Left + (Cursor.Position.X - tmpX);
                this.Top = this.Top + (Cursor.Position.Y - tmpY);

                tmpX = Cursor.Position.X;
                tmpY = Cursor.Position.Y;
            }
        }

        private void FullScreenPanel_MouseUp(object sender, MouseEventArgs e)
        {
            flMove = false;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string[] mas= new string[3];
            string str = webBrowser1.Document.Cookie;
            if (str != null)
            {
                mas = str.Split('=');
                captchaValue = mas[2];
            }
        }
    }
    
}
