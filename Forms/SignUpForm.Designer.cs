﻿namespace kursova
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.usersPasswordTextBox = new System.Windows.Forms.TextBox();
            this.usersEmailTextBox = new System.Windows.Forms.TextBox();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.usersSurnameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.usersNameTextBox = new System.Windows.Forms.TextBox();
            this.patronymLabel = new System.Windows.Forms.Label();
            this.usersPatronymTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.usersAgeTextBox = new System.Windows.Forms.TextBox();
            this.sexLabel = new System.Windows.Forms.Label();
            this.usersSexComboBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.mailCheckerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(365, 123);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(65, 21);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Пароль:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(365, 65);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(144, 21);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Електронна пошта:";
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpButton.Location = new System.Drawing.Point(224, 358);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(200, 50);
            this.signUpButton.TabIndex = 9;
            this.signUpButton.Text = "ЗАРЕЄСТРУВАТИСЯ";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // usersPasswordTextBox
            // 
            this.usersPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersPasswordTextBox.Location = new System.Drawing.Point(369, 147);
            this.usersPasswordTextBox.Name = "usersPasswordTextBox";
            this.usersPasswordTextBox.Size = new System.Drawing.Size(234, 22);
            this.usersPasswordTextBox.TabIndex = 8;
            // 
            // usersEmailTextBox
            // 
            this.usersEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersEmailTextBox.Location = new System.Drawing.Point(368, 89);
            this.usersEmailTextBox.Name = "usersEmailTextBox";
            this.usersEmailTextBox.Size = new System.Drawing.Size(234, 22);
            this.usersEmailTextBox.TabIndex = 7;
            this.usersEmailTextBox.TextChanged += new System.EventHandler(this.usersEmailTextBox_TextChanged);
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.BackColor = System.Drawing.Color.Transparent;
            this.signUpLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpLabel.Location = new System.Drawing.Point(20, 20);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(176, 37);
            this.signUpLabel.TabIndex = 6;
            this.signUpLabel.Text = "Реєстрація";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.surnameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.Location = new System.Drawing.Point(23, 65);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(83, 21);
            this.surnameLabel.TabIndex = 13;
            this.surnameLabel.Text = "Прізвище:";
            // 
            // usersSurnameTextBox
            // 
            this.usersSurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersSurnameTextBox.Location = new System.Drawing.Point(26, 89);
            this.usersSurnameTextBox.Name = "usersSurnameTextBox";
            this.usersSurnameTextBox.Size = new System.Drawing.Size(234, 22);
            this.usersSurnameTextBox.TabIndex = 12;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(23, 123);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 21);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Ім\'я:";
            // 
            // usersNameTextBox
            // 
            this.usersNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersNameTextBox.Location = new System.Drawing.Point(26, 147);
            this.usersNameTextBox.Name = "usersNameTextBox";
            this.usersNameTextBox.Size = new System.Drawing.Size(234, 22);
            this.usersNameTextBox.TabIndex = 14;
            // 
            // patronymLabel
            // 
            this.patronymLabel.AutoSize = true;
            this.patronymLabel.BackColor = System.Drawing.Color.Transparent;
            this.patronymLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymLabel.Location = new System.Drawing.Point(23, 178);
            this.patronymLabel.Name = "patronymLabel";
            this.patronymLabel.Size = new System.Drawing.Size(97, 21);
            this.patronymLabel.TabIndex = 17;
            this.patronymLabel.Text = "По батькові:";
            // 
            // usersPatronymTextBox
            // 
            this.usersPatronymTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersPatronymTextBox.Location = new System.Drawing.Point(26, 203);
            this.usersPatronymTextBox.Name = "usersPatronymTextBox";
            this.usersPatronymTextBox.Size = new System.Drawing.Size(234, 22);
            this.usersPatronymTextBox.TabIndex = 16;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.BackColor = System.Drawing.Color.Transparent;
            this.ageLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.Location = new System.Drawing.Point(23, 239);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(36, 21);
            this.ageLabel.TabIndex = 19;
            this.ageLabel.Text = "Вік:";
            // 
            // usersAgeTextBox
            // 
            this.usersAgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersAgeTextBox.Location = new System.Drawing.Point(26, 260);
            this.usersAgeTextBox.Name = "usersAgeTextBox";
            this.usersAgeTextBox.Size = new System.Drawing.Size(234, 22);
            this.usersAgeTextBox.TabIndex = 18;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.BackColor = System.Drawing.Color.Transparent;
            this.sexLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexLabel.Location = new System.Drawing.Point(23, 299);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(52, 21);
            this.sexLabel.TabIndex = 20;
            this.sexLabel.Text = "Стать:";
            // 
            // usersSexComboBox
            // 
            this.usersSexComboBox.FormattingEnabled = true;
            this.usersSexComboBox.Items.AddRange(new object[] {
            "Чоловік",
            "Жінка"});
            this.usersSexComboBox.Location = new System.Drawing.Point(26, 318);
            this.usersSexComboBox.Name = "usersSexComboBox";
            this.usersSexComboBox.Size = new System.Drawing.Size(234, 21);
            this.usersSexComboBox.TabIndex = 21;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(229)))), ((int)(((byte)(163)))));
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(12, 373);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(63, 59);
            this.backButton.TabIndex = 22;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // mailCheckerLabel
            // 
            this.mailCheckerLabel.AutoSize = true;
            this.mailCheckerLabel.BackColor = System.Drawing.Color.Transparent;
            this.mailCheckerLabel.ForeColor = System.Drawing.Color.Red;
            this.mailCheckerLabel.Location = new System.Drawing.Point(366, 112);
            this.mailCheckerLabel.Name = "mailCheckerLabel";
            this.mailCheckerLabel.Size = new System.Drawing.Size(0, 13);
            this.mailCheckerLabel.TabIndex = 23;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 444);
            this.Controls.Add(this.mailCheckerLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.usersSexComboBox);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.usersAgeTextBox);
            this.Controls.Add(this.patronymLabel);
            this.Controls.Add(this.usersPatronymTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.usersNameTextBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.usersSurnameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.usersPasswordTextBox);
            this.Controls.Add(this.usersEmailTextBox);
            this.Controls.Add(this.signUpLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстрація";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.TextBox usersPasswordTextBox;
        private System.Windows.Forms.TextBox usersEmailTextBox;
        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox usersSurnameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox usersNameTextBox;
        private System.Windows.Forms.Label patronymLabel;
        private System.Windows.Forms.TextBox usersPatronymTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox usersAgeTextBox;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.ComboBox usersSexComboBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label mailCheckerLabel;
    }
}