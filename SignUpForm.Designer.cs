namespace kursova
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
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(365, 132);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 16);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Пароль:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(365, 73);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(134, 16);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Електронна пошта:";
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.usersPasswordTextBox.Location = new System.Drawing.Point(368, 148);
            this.usersPasswordTextBox.Name = "usersPasswordTextBox";
            this.usersPasswordTextBox.PasswordChar = '●';
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
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpLabel.Location = new System.Drawing.Point(20, 20);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(245, 31);
            this.signUpLabel.TabIndex = 6;
            this.signUpLabel.Text = "Зареєструватися";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.Location = new System.Drawing.Point(23, 73);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(72, 16);
            this.surnameLabel.TabIndex = 13;
            this.surnameLabel.Text = "Прізвище:";
            // 
            // usersSurnameTextBox
            // 
            this.usersSurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersSurnameTextBox.Location = new System.Drawing.Point(26, 89);
            this.usersSurnameTextBox.Name = "usersSurnameTextBox";
            this.usersSurnameTextBox.PasswordChar = '●';
            this.usersSurnameTextBox.Size = new System.Drawing.Size(234, 22);
            this.usersSurnameTextBox.TabIndex = 12;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(23, 123);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(32, 16);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Ім\'я:";
            // 
            // usersNameTextBox
            // 
            this.usersNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersNameTextBox.Location = new System.Drawing.Point(26, 139);
            this.usersNameTextBox.Name = "usersNameTextBox";
            this.usersNameTextBox.PasswordChar = '●';
            this.usersNameTextBox.Size = new System.Drawing.Size(234, 22);
            this.usersNameTextBox.TabIndex = 14;
            // 
            // patronymLabel
            // 
            this.patronymLabel.AutoSize = true;
            this.patronymLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymLabel.Location = new System.Drawing.Point(23, 170);
            this.patronymLabel.Name = "patronymLabel";
            this.patronymLabel.Size = new System.Drawing.Size(87, 16);
            this.patronymLabel.TabIndex = 17;
            this.patronymLabel.Text = "По батькові:";
            // 
            // usersPatronymTextBox
            // 
            this.usersPatronymTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersPatronymTextBox.Location = new System.Drawing.Point(26, 186);
            this.usersPatronymTextBox.Name = "usersPatronymTextBox";
            this.usersPatronymTextBox.PasswordChar = '●';
            this.usersPatronymTextBox.Size = new System.Drawing.Size(234, 22);
            this.usersPatronymTextBox.TabIndex = 16;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.Location = new System.Drawing.Point(23, 220);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(29, 16);
            this.ageLabel.TabIndex = 19;
            this.ageLabel.Text = "Вік:";
            // 
            // usersAgeTextBox
            // 
            this.usersAgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersAgeTextBox.Location = new System.Drawing.Point(26, 236);
            this.usersAgeTextBox.Name = "usersAgeTextBox";
            this.usersAgeTextBox.PasswordChar = '●';
            this.usersAgeTextBox.Size = new System.Drawing.Size(234, 22);
            this.usersAgeTextBox.TabIndex = 18;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexLabel.Location = new System.Drawing.Point(23, 273);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(48, 16);
            this.sexLabel.TabIndex = 20;
            this.sexLabel.Text = "Стать:";
            // 
            // usersSexComboBox
            // 
            this.usersSexComboBox.FormattingEnabled = true;
            this.usersSexComboBox.Items.AddRange(new object[] {
            "Чоловік",
            "Жінка"});
            this.usersSexComboBox.Location = new System.Drawing.Point(26, 292);
            this.usersSexComboBox.Name = "usersSexComboBox";
            this.usersSexComboBox.Size = new System.Drawing.Size(234, 21);
            this.usersSexComboBox.TabIndex = 21;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(12, 397);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(107, 35);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "НАЗАД";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 444);
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
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Misto App Sign Up";
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
    }
}