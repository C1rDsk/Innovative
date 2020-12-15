namespace Innovative
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headingLabel = new System.Windows.Forms.Label();
            this.recoveryButton1 = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.BackColor = System.Drawing.Color.Transparent;
            this.headingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.headingLabel.Location = new System.Drawing.Point(171, 12);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(205, 42);
            this.headingLabel.TabIndex = 13;
            this.headingLabel.Text = "Настройки";
            // 
            // recoveryButton1
            // 
            this.recoveryButton1.BackColor = System.Drawing.Color.Transparent;
            this.recoveryButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recoveryButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recoveryButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recoveryButton1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.recoveryButton1.Location = new System.Drawing.Point(168, 400);
            this.recoveryButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recoveryButton1.Name = "recoveryButton1";
            this.recoveryButton1.Size = new System.Drawing.Size(197, 39);
            this.recoveryButton1.TabIndex = 14;
            this.recoveryButton1.Text = "Выбрать путь";
            this.recoveryButton1.UseVisualStyleBackColor = false;
            this.recoveryButton1.Click += new System.EventHandler(this.recoveryButton1_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Image = global::Innovative.Properties.Resources.exit2;
            this.closeButton.Location = new System.Drawing.Point(444, 4);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(53, 49);
            this.closeButton.TabIndex = 15;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 450);
            this.panel1.TabIndex = 16;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Innovative.Properties.Resources._16;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.recoveryButton1);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Button recoveryButton1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel1;
    }
}