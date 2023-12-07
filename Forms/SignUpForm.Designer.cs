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
            this.backButton = new System.Windows.Forms.Button();
            this.mailCheckerLabel = new System.Windows.Forms.Label();
            this.sexGroupBox = new System.Windows.Forms.GroupBox();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.sexLabel = new System.Windows.Forms.Label();
            this.passwordCheckerLabel = new System.Windows.Forms.Label();
            this.ageCheckerLabel = new System.Windows.Forms.Label();
            this.sexGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(365, 129);
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
            this.signUpButton.Enabled = false;
            this.signUpButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpButton.Location = new System.Drawing.Point(224, 365);
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
            this.usersPasswordTextBox.Location = new System.Drawing.Point(369, 153);
            this.usersPasswordTextBox.MaxLength = 100;
            this.usersPasswordTextBox.Name = "usersPasswordTextBox";
            this.usersPasswordTextBox.PasswordChar = '●';
            this.usersPasswordTextBox.Size = new System.Drawing.Size(234, 22);
            this.usersPasswordTextBox.TabIndex = 8;
            this.usersPasswordTextBox.TextChanged += new System.EventHandler(this.usersPasswordTextBox_TextChanged);
            this.usersPasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usersPasswordTextBox_KeyPress);
            // 
            // usersEmailTextBox
            // 
            this.usersEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersEmailTextBox.Location = new System.Drawing.Point(368, 89);
            this.usersEmailTextBox.MaxLength = 40;
            this.usersEmailTextBox.Name = "usersEmailTextBox";
            this.usersEmailTextBox.Size = new System.Drawing.Size(234, 22);
            this.usersEmailTextBox.TabIndex = 7;
            this.usersEmailTextBox.TextChanged += new System.EventHandler(this.usersEmailTextBox_TextChanged);
            this.usersEmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usersEmailTextBox_KeyPress);
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
            this.surnameLabel.Location = new System.Drawing.Point(22, 65);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(83, 21);
            this.surnameLabel.TabIndex = 13;
            this.surnameLabel.Text = "Прізвище:";
            // 
            // usersSurnameTextBox
            // 
            this.usersSurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersSurnameTextBox.Location = new System.Drawing.Point(26, 89);
            this.usersSurnameTextBox.MaxLength = 50;
            this.usersSurnameTextBox.Name = "usersSurnameTextBox";
            this.usersSurnameTextBox.Size = new System.Drawing.Size(234, 22);
            this.usersSurnameTextBox.TabIndex = 12;
            this.usersSurnameTextBox.TextChanged += new System.EventHandler(this.usersSurnameTextBox_TextChanged);
            this.usersSurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usersSurnameTextBox_KeyPress);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(22, 123);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 21);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Ім\'я:";
            // 
            // usersNameTextBox
            // 
            this.usersNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersNameTextBox.Location = new System.Drawing.Point(26, 147);
            this.usersNameTextBox.MaxLength = 50;
            this.usersNameTextBox.Name = "usersNameTextBox";
            this.usersNameTextBox.Size = new System.Drawing.Size(234, 22);
            this.usersNameTextBox.TabIndex = 14;
            this.usersNameTextBox.TextChanged += new System.EventHandler(this.usersNameTextBox_TextChanged);
            this.usersNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usersNameTextBox_KeyPress);
            // 
            // patronymLabel
            // 
            this.patronymLabel.AutoSize = true;
            this.patronymLabel.BackColor = System.Drawing.Color.Transparent;
            this.patronymLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymLabel.Location = new System.Drawing.Point(22, 179);
            this.patronymLabel.Name = "patronymLabel";
            this.patronymLabel.Size = new System.Drawing.Size(97, 21);
            this.patronymLabel.TabIndex = 17;
            this.patronymLabel.Text = "По батькові:";
            // 
            // usersPatronymTextBox
            // 
            this.usersPatronymTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersPatronymTextBox.Location = new System.Drawing.Point(26, 203);
            this.usersPatronymTextBox.MaxLength = 50;
            this.usersPatronymTextBox.Name = "usersPatronymTextBox";
            this.usersPatronymTextBox.Size = new System.Drawing.Size(234, 22);
            this.usersPatronymTextBox.TabIndex = 16;
            this.usersPatronymTextBox.TextChanged += new System.EventHandler(this.usersPatronymTextBox_TextChanged);
            this.usersPatronymTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usersPatronymTextBox_KeyPress);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.BackColor = System.Drawing.Color.Transparent;
            this.ageLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.Location = new System.Drawing.Point(22, 236);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(36, 21);
            this.ageLabel.TabIndex = 19;
            this.ageLabel.Text = "Вік:";
            // 
            // usersAgeTextBox
            // 
            this.usersAgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersAgeTextBox.Location = new System.Drawing.Point(26, 260);
            this.usersAgeTextBox.MaxLength = 3;
            this.usersAgeTextBox.Name = "usersAgeTextBox";
            this.usersAgeTextBox.Size = new System.Drawing.Size(234, 22);
            this.usersAgeTextBox.TabIndex = 18;
            this.usersAgeTextBox.TextChanged += new System.EventHandler(this.usersAgeTextBox_TextChanged);
            this.usersAgeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usersAgeTextBox_KeyPress);
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
            this.mailCheckerLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailCheckerLabel.ForeColor = System.Drawing.Color.Green;
            this.mailCheckerLabel.Location = new System.Drawing.Point(366, 112);
            this.mailCheckerLabel.Name = "mailCheckerLabel";
            this.mailCheckerLabel.Size = new System.Drawing.Size(0, 17);
            this.mailCheckerLabel.TabIndex = 23;
            // 
            // sexGroupBox
            // 
            this.sexGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.sexGroupBox.Controls.Add(this.femaleRadioButton);
            this.sexGroupBox.Controls.Add(this.maleRadioButton);
            this.sexGroupBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexGroupBox.Location = new System.Drawing.Point(26, 315);
            this.sexGroupBox.Name = "sexGroupBox";
            this.sexGroupBox.Size = new System.Drawing.Size(234, 44);
            this.sexGroupBox.TabIndex = 24;
            this.sexGroupBox.TabStop = false;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(139, 14);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(71, 25);
            this.femaleRadioButton.TabIndex = 1;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Жінка";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(24, 14);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(82, 25);
            this.maleRadioButton.TabIndex = 0;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Чоловік";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.BackColor = System.Drawing.Color.Transparent;
            this.sexLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexLabel.Location = new System.Drawing.Point(24, 299);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(52, 21);
            this.sexLabel.TabIndex = 25;
            this.sexLabel.Text = "Стать:";
            // 
            // passwordCheckerLabel
            // 
            this.passwordCheckerLabel.AutoSize = true;
            this.passwordCheckerLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordCheckerLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordCheckerLabel.ForeColor = System.Drawing.Color.Green;
            this.passwordCheckerLabel.Location = new System.Drawing.Point(366, 176);
            this.passwordCheckerLabel.Name = "passwordCheckerLabel";
            this.passwordCheckerLabel.Size = new System.Drawing.Size(0, 17);
            this.passwordCheckerLabel.TabIndex = 27;
            // 
            // ageCheckerLabel
            // 
            this.ageCheckerLabel.AutoSize = true;
            this.ageCheckerLabel.BackColor = System.Drawing.Color.Transparent;
            this.ageCheckerLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageCheckerLabel.ForeColor = System.Drawing.Color.Green;
            this.ageCheckerLabel.Location = new System.Drawing.Point(24, 281);
            this.ageCheckerLabel.Name = "ageCheckerLabel";
            this.ageCheckerLabel.Size = new System.Drawing.Size(0, 17);
            this.ageCheckerLabel.TabIndex = 28;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 444);
            this.Controls.Add(this.ageCheckerLabel);
            this.Controls.Add(this.passwordCheckerLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.sexGroupBox);
            this.Controls.Add(this.mailCheckerLabel);
            this.Controls.Add(this.backButton);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpForm_FormClosing);
            this.sexGroupBox.ResumeLayout(false);
            this.sexGroupBox.PerformLayout();
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
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label mailCheckerLabel;
        private System.Windows.Forms.GroupBox sexGroupBox;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label passwordCheckerLabel;
        private System.Windows.Forms.Label ageCheckerLabel;
    }
}