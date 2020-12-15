namespace Innovative
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginTabControl = new System.Windows.Forms.TabControl();
            this.autoTabPage = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.headingLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.authRecButton = new System.Windows.Forms.Button();
            this.authRegButton = new System.Windows.Forms.Button();
            this.autorizationButton = new System.Windows.Forms.Button();
            this.authPassTextBox = new System.Windows.Forms.TextBox();
            this.authLoginTextBox = new System.Windows.Forms.TextBox();
            this.regTabPage = new System.Windows.Forms.TabPage();
            this.capchaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.headingLabel2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.regPassTextBox = new System.Windows.Forms.TextBox();
            this.regLoginTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passwordLabel2 = new System.Windows.Forms.Label();
            this.loginLabel2 = new System.Windows.Forms.Label();
            this.passwordLabel3 = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.registrationButton = new System.Windows.Forms.Button();
            this.confirmationTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.recTabPage = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.recoveryButton1 = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.FullScreenPanel = new System.Windows.Forms.Panel();
            this.loginTabControl.SuspendLayout();
            this.autoTabPage.SuspendLayout();
            this.regTabPage.SuspendLayout();
            this.recTabPage.SuspendLayout();
            this.FullScreenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTabControl
            // 
            this.loginTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.loginTabControl.Controls.Add(this.autoTabPage);
            this.loginTabControl.Controls.Add(this.regTabPage);
            this.loginTabControl.Controls.Add(this.recTabPage);
            this.loginTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.loginTabControl.Location = new System.Drawing.Point(-5, -12);
            this.loginTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.loginTabControl.Multiline = true;
            this.loginTabControl.Name = "loginTabControl";
            this.loginTabControl.SelectedIndex = 0;
            this.loginTabControl.Size = new System.Drawing.Size(537, 622);
            this.loginTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.loginTabControl.TabIndex = 0;
            // 
            // autoTabPage
            // 
            this.autoTabPage.BackgroundImage = global::Innovative.Properties.Resources._14;
            this.autoTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.autoTabPage.Controls.Add(this.button5);
            this.autoTabPage.Controls.Add(this.SettingsButton);
            this.autoTabPage.Controls.Add(this.checkBox2);
            this.autoTabPage.Controls.Add(this.buttonClose);
            this.autoTabPage.Controls.Add(this.headingLabel);
            this.autoTabPage.Controls.Add(this.checkBox1);
            this.autoTabPage.Controls.Add(this.passwordLabel);
            this.autoTabPage.Controls.Add(this.loginLabel);
            this.autoTabPage.Controls.Add(this.authRecButton);
            this.autoTabPage.Controls.Add(this.authRegButton);
            this.autoTabPage.Controls.Add(this.autorizationButton);
            this.autoTabPage.Controls.Add(this.authPassTextBox);
            this.autoTabPage.Controls.Add(this.authLoginTextBox);
            this.autoTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoTabPage.Location = new System.Drawing.Point(4, 5);
            this.autoTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoTabPage.Name = "autoTabPage";
            this.autoTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoTabPage.Size = new System.Drawing.Size(529, 613);
            this.autoTabPage.TabIndex = 0;
            this.autoTabPage.Text = "авторизация";
            this.autoTabPage.UseVisualStyleBackColor = true;
            this.autoTabPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FullScreenPanel_MouseDown);
            this.autoTabPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FullScreenPanel_MouseMove);
            this.autoTabPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FullScreenPanel_MouseUp);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.Location = new System.Drawing.Point(463, 550);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 12;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.BackgroundImage = global::Innovative.Properties.Resources.shes55x552;
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SettingsButton.Location = new System.Drawing.Point(1, 551);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(65, 59);
            this.SettingsButton.TabIndex = 7;
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.checkBox2.FlatAppearance.BorderSize = 2;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(170, 293);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(196, 29);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Зайти автономно";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Image = global::Innovative.Properties.Resources.exit2;
            this.buttonClose.Location = new System.Drawing.Point(469, 6);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(53, 49);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.Close);
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.BackColor = System.Drawing.Color.Transparent;
            this.headingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.headingLabel.Location = new System.Drawing.Point(132, 59);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(245, 42);
            this.headingLabel.TabIndex = 9;
            this.headingLabel.Text = "Авторизация";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.checkBox1.FlatAppearance.BorderSize = 2;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(170, 260);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 29);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Запомнить";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(39, 221);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(80, 25);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Пароль";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(39, 175);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(121, 25);
            this.loginLabel.TabIndex = 10;
            this.loginLabel.Text = "Login/E-mail";
            // 
            // authRecButton
            // 
            this.authRecButton.BackColor = System.Drawing.Color.Transparent;
            this.authRecButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authRecButton.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.authRecButton.FlatAppearance.BorderSize = 2;
            this.authRecButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authRecButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authRecButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.authRecButton.Location = new System.Drawing.Point(144, 345);
            this.authRecButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authRecButton.Name = "authRecButton";
            this.authRecButton.Size = new System.Drawing.Size(242, 36);
            this.authRecButton.TabIndex = 5;
            this.authRecButton.Text = "Забыли пароль?";
            this.authRecButton.UseVisualStyleBackColor = false;
            this.authRecButton.Click += new System.EventHandler(this.authRecButton_Click_1);
            // 
            // authRegButton
            // 
            this.authRegButton.BackColor = System.Drawing.Color.Transparent;
            this.authRegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authRegButton.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.authRegButton.FlatAppearance.BorderSize = 2;
            this.authRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authRegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authRegButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.authRegButton.Location = new System.Drawing.Point(144, 398);
            this.authRegButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authRegButton.Name = "authRegButton";
            this.authRegButton.Size = new System.Drawing.Size(242, 36);
            this.authRegButton.TabIndex = 6;
            this.authRegButton.Text = "Зарегистрироваться";
            this.authRegButton.UseVisualStyleBackColor = false;
            this.authRegButton.Click += new System.EventHandler(this.authRegButton_Click_1);
            // 
            // autorizationButton
            // 
            this.autorizationButton.BackColor = System.Drawing.Color.Transparent;
            this.autorizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autorizationButton.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.autorizationButton.FlatAppearance.BorderSize = 2;
            this.autorizationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autorizationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autorizationButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.autorizationButton.Location = new System.Drawing.Point(156, 492);
            this.autorizationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autorizationButton.Name = "autorizationButton";
            this.autorizationButton.Size = new System.Drawing.Size(219, 39);
            this.autorizationButton.TabIndex = 2;
            this.autorizationButton.Text = "Войти";
            this.autorizationButton.UseVisualStyleBackColor = false;
            this.autorizationButton.Click += new System.EventHandler(this.autorizationButton_Click);
            // 
            // authPassTextBox
            // 
            this.authPassTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.authPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.authPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authPassTextBox.Location = new System.Drawing.Point(184, 219);
            this.authPassTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authPassTextBox.Name = "authPassTextBox";
            this.authPassTextBox.PasswordChar = '*';
            this.authPassTextBox.Size = new System.Drawing.Size(270, 30);
            this.authPassTextBox.TabIndex = 1;
            this.authPassTextBox.UseSystemPasswordChar = true;
            this.authPassTextBox.Enter += new System.EventHandler(this.Entr);
            this.authPassTextBox.Leave += new System.EventHandler(this.LiavMistyRose);
            // 
            // authLoginTextBox
            // 
            this.authLoginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.authLoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.authLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authLoginTextBox.ForeColor = System.Drawing.Color.Black;
            this.authLoginTextBox.Location = new System.Drawing.Point(184, 172);
            this.authLoginTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authLoginTextBox.Name = "authLoginTextBox";
            this.authLoginTextBox.Size = new System.Drawing.Size(270, 30);
            this.authLoginTextBox.TabIndex = 0;
            this.authLoginTextBox.Enter += new System.EventHandler(this.Entr);
            this.authLoginTextBox.Leave += new System.EventHandler(this.LiavMistyRose);
            // 
            // regTabPage
            // 
            this.regTabPage.BackgroundImage = global::Innovative.Properties.Resources._15;
            this.regTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regTabPage.Controls.Add(this.capchaTextBox);
            this.regTabPage.Controls.Add(this.label1);
            this.regTabPage.Controls.Add(this.webBrowser1);
            this.regTabPage.Controls.Add(this.phoneMaskedTextBox);
            this.regTabPage.Controls.Add(this.button3);
            this.regTabPage.Controls.Add(this.button1);
            this.regTabPage.Controls.Add(this.headingLabel2);
            this.regTabPage.Controls.Add(this.nameTextBox);
            this.regTabPage.Controls.Add(this.regPassTextBox);
            this.regTabPage.Controls.Add(this.regLoginTextBox);
            this.regTabPage.Controls.Add(this.phoneLabel);
            this.regTabPage.Controls.Add(this.nameLabel);
            this.regTabPage.Controls.Add(this.passwordLabel2);
            this.regTabPage.Controls.Add(this.loginLabel2);
            this.regTabPage.Controls.Add(this.passwordLabel3);
            this.regTabPage.Controls.Add(this.emailLabel);
            this.regTabPage.Controls.Add(this.registrationButton);
            this.regTabPage.Controls.Add(this.confirmationTextBox);
            this.regTabPage.Controls.Add(this.emailTextBox);
            this.regTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regTabPage.Location = new System.Drawing.Point(4, 5);
            this.regTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regTabPage.Name = "regTabPage";
            this.regTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regTabPage.Size = new System.Drawing.Size(529, 613);
            this.regTabPage.TabIndex = 1;
            this.regTabPage.Text = "регистрация";
            this.regTabPage.UseVisualStyleBackColor = true;
            this.regTabPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FullScreenPanel_MouseDown);
            this.regTabPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FullScreenPanel_MouseMove);
            this.regTabPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FullScreenPanel_MouseUp);
            // 
            // capchaTextBox
            // 
            this.capchaTextBox.BackColor = System.Drawing.Color.Honeydew;
            this.capchaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.capchaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capchaTextBox.Location = new System.Drawing.Point(346, 517);
            this.capchaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.capchaTextBox.Name = "capchaTextBox";
            this.capchaTextBox.Size = new System.Drawing.Size(152, 30);
            this.capchaTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Введите код с картинки";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(194, 342);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(304, 170);
            this.webBrowser1.TabIndex = 16;
            this.webBrowser1.Url = new System.Uri("https://innosite.000webhostapp.com/", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.BackColor = System.Drawing.Color.Honeydew;
            this.phoneMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(215, 305);
            this.phoneMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneMaskedTextBox.Mask = "+7 (999) 000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(283, 30);
            this.phoneMaskedTextBox.TabIndex = 5;
            this.phoneMaskedTextBox.Enter += new System.EventHandler(this.Entr);
            this.phoneMaskedTextBox.Leave += new System.EventHandler(this.LiavGreen);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Image = global::Innovative.Properties.Resources.exitik1;
            this.button3.Location = new System.Drawing.Point(0, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 49);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Back);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = global::Innovative.Properties.Resources.exit2;
            this.button1.Location = new System.Drawing.Point(469, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 49);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Close);
            // 
            // headingLabel2
            // 
            this.headingLabel2.AutoSize = true;
            this.headingLabel2.BackColor = System.Drawing.Color.Transparent;
            this.headingLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headingLabel2.ForeColor = System.Drawing.Color.Black;
            this.headingLabel2.Location = new System.Drawing.Point(135, 36);
            this.headingLabel2.Name = "headingLabel2";
            this.headingLabel2.Size = new System.Drawing.Size(239, 42);
            this.headingLabel2.TabIndex = 9;
            this.headingLabel2.Text = "Регистрация";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Honeydew;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(215, 265);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(283, 30);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.Enter += new System.EventHandler(this.Entr);
            this.nameTextBox.Leave += new System.EventHandler(this.LiavGreen);
            // 
            // regPassTextBox
            // 
            this.regPassTextBox.BackColor = System.Drawing.Color.Honeydew;
            this.regPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regPassTextBox.Location = new System.Drawing.Point(215, 165);
            this.regPassTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regPassTextBox.Name = "regPassTextBox";
            this.regPassTextBox.Size = new System.Drawing.Size(283, 30);
            this.regPassTextBox.TabIndex = 2;
            this.regPassTextBox.Enter += new System.EventHandler(this.Entr);
            this.regPassTextBox.Leave += new System.EventHandler(this.LiavGreen);
            // 
            // regLoginTextBox
            // 
            this.regLoginTextBox.BackColor = System.Drawing.Color.Honeydew;
            this.regLoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLoginTextBox.Location = new System.Drawing.Point(215, 125);
            this.regLoginTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regLoginTextBox.Name = "regLoginTextBox";
            this.regLoginTextBox.Size = new System.Drawing.Size(283, 30);
            this.regLoginTextBox.TabIndex = 1;
            this.regLoginTextBox.Enter += new System.EventHandler(this.Entr);
            this.regLoginTextBox.Leave += new System.EventHandler(this.LiavGreen);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.Location = new System.Drawing.Point(17, 307);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(99, 25);
            this.phoneLabel.TabIndex = 15;
            this.phoneLabel.Text = "Телефон";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(20, 267);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(54, 25);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "Имя";
            // 
            // passwordLabel2
            // 
            this.passwordLabel2.AutoSize = true;
            this.passwordLabel2.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel2.Location = new System.Drawing.Point(17, 167);
            this.passwordLabel2.Name = "passwordLabel2";
            this.passwordLabel2.Size = new System.Drawing.Size(80, 25);
            this.passwordLabel2.TabIndex = 12;
            this.passwordLabel2.Text = "Пароль";
            // 
            // loginLabel2
            // 
            this.loginLabel2.AutoSize = true;
            this.loginLabel2.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel2.Location = new System.Drawing.Point(20, 127);
            this.loginLabel2.Name = "loginLabel2";
            this.loginLabel2.Size = new System.Drawing.Size(68, 25);
            this.loginLabel2.TabIndex = 11;
            this.loginLabel2.Text = "Логин";
            // 
            // passwordLabel3
            // 
            this.passwordLabel3.AutoSize = true;
            this.passwordLabel3.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel3.Location = new System.Drawing.Point(17, 205);
            this.passwordLabel3.Name = "passwordLabel3";
            this.passwordLabel3.Size = new System.Drawing.Size(171, 50);
            this.passwordLabel3.TabIndex = 13;
            this.passwordLabel3.Text = "Подтверждение \r\nпароля";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(17, 87);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(67, 25);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "E-mail";
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.Transparent;
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.Location = new System.Drawing.Point(142, 550);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(245, 50);
            this.registrationButton.TabIndex = 6;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // confirmationTextBox
            // 
            this.confirmationTextBox.BackColor = System.Drawing.Color.Honeydew;
            this.confirmationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmationTextBox.Location = new System.Drawing.Point(215, 205);
            this.confirmationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmationTextBox.Name = "confirmationTextBox";
            this.confirmationTextBox.Size = new System.Drawing.Size(283, 30);
            this.confirmationTextBox.TabIndex = 3;
            this.confirmationTextBox.Enter += new System.EventHandler(this.Entr);
            this.confirmationTextBox.Leave += new System.EventHandler(this.LiavGreen);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.Honeydew;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(215, 85);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(283, 30);
            this.emailTextBox.TabIndex = 0;
            this.emailTextBox.Enter += new System.EventHandler(this.Entr);
            this.emailTextBox.Leave += new System.EventHandler(this.LiavGreen);
            // 
            // recTabPage
            // 
            this.recTabPage.BackgroundImage = global::Innovative.Properties.Resources._16;
            this.recTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recTabPage.Controls.Add(this.button4);
            this.recTabPage.Controls.Add(this.button2);
            this.recTabPage.Controls.Add(this.label2);
            this.recTabPage.Controls.Add(this.label3);
            this.recTabPage.Controls.Add(this.recoveryButton1);
            this.recTabPage.Controls.Add(this.loginTextBox);
            this.recTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recTabPage.Location = new System.Drawing.Point(4, 5);
            this.recTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recTabPage.Name = "recTabPage";
            this.recTabPage.Size = new System.Drawing.Size(529, 613);
            this.recTabPage.TabIndex = 2;
            this.recTabPage.Text = "восстановление";
            this.recTabPage.UseVisualStyleBackColor = true;
            this.recTabPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FullScreenPanel_MouseDown);
            this.recTabPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FullScreenPanel_MouseMove);
            this.recTabPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FullScreenPanel_MouseUp);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Image = global::Innovative.Properties.Resources.exitik1;
            this.button4.Location = new System.Drawing.Point(-1, 5);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 49);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Back);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Image = global::Innovative.Properties.Resources.exit2;
            this.button2.Location = new System.Drawing.Point(468, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 49);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Close);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login/E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(442, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "Восстановление пароля";
            // 
            // recoveryButton1
            // 
            this.recoveryButton1.BackColor = System.Drawing.Color.Transparent;
            this.recoveryButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recoveryButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recoveryButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recoveryButton1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.recoveryButton1.Location = new System.Drawing.Point(269, 327);
            this.recoveryButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recoveryButton1.Name = "recoveryButton1";
            this.recoveryButton1.Size = new System.Drawing.Size(197, 39);
            this.recoveryButton1.TabIndex = 1;
            this.recoveryButton1.Text = "Восстановить";
            this.recoveryButton1.UseVisualStyleBackColor = false;
            this.recoveryButton1.Click += new System.EventHandler(this.recoveryButton1_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(172, 245);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(294, 30);
            this.loginTextBox.TabIndex = 0;
            // 
            // FullScreenPanel
            // 
            this.FullScreenPanel.AutoSize = true;
            this.FullScreenPanel.BackColor = System.Drawing.Color.Transparent;
            this.FullScreenPanel.Controls.Add(this.loginTabControl);
            this.FullScreenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FullScreenPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullScreenPanel.Location = new System.Drawing.Point(0, 0);
            this.FullScreenPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FullScreenPanel.Name = "FullScreenPanel";
            this.FullScreenPanel.Size = new System.Drawing.Size(523, 604);
            this.FullScreenPanel.TabIndex = 0;
            this.FullScreenPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FullScreenPanel_MouseDown);
            this.FullScreenPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FullScreenPanel_MouseMove);
            this.FullScreenPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FullScreenPanel_MouseUp);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 604);
            this.Controls.Add(this.FullScreenPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.logForm_Load);
            this.loginTabControl.ResumeLayout(false);
            this.autoTabPage.ResumeLayout(false);
            this.autoTabPage.PerformLayout();
            this.regTabPage.ResumeLayout(false);
            this.regTabPage.PerformLayout();
            this.recTabPage.ResumeLayout(false);
            this.recTabPage.PerformLayout();
            this.FullScreenPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl loginTabControl;
        private System.Windows.Forms.TabPage regTabPage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label headingLabel2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox regPassTextBox;
        private System.Windows.Forms.TextBox regLoginTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passwordLabel2;
        private System.Windows.Forms.Label loginLabel2;
        private System.Windows.Forms.Label passwordLabel3;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.TextBox confirmationTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TabPage autoTabPage;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button authRecButton;
        private System.Windows.Forms.Button authRegButton;
        private System.Windows.Forms.Button autorizationButton;
        private System.Windows.Forms.TextBox authPassTextBox;
        private System.Windows.Forms.TextBox authLoginTextBox;
        private System.Windows.Forms.TabPage recTabPage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button recoveryButton1;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Panel FullScreenPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox capchaTextBox;
        private System.Windows.Forms.Label label1;
    }
}

