namespace kursova
{
    partial class SignInForm
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
            this.signInLabel = new System.Windows.Forms.Label();
            this.usersEmailTextBox = new System.Windows.Forms.TextBox();
            this.usersPasswordTextBox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.signUpSuggestionLabel = new System.Windows.Forms.Label();
            this.signUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.mailCheckerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signInLabel
            // 
            this.signInLabel.AutoSize = true;
            this.signInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInLabel.Location = new System.Drawing.Point(31, 27);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(99, 31);
            this.signInLabel.TabIndex = 0;
            this.signInLabel.Text = "Увійти";
            // 
            // usersEmailTextBox
            // 
            this.usersEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersEmailTextBox.Location = new System.Drawing.Point(37, 106);
            this.usersEmailTextBox.Name = "usersEmailTextBox";
            this.usersEmailTextBox.Size = new System.Drawing.Size(234, 22);
            this.usersEmailTextBox.TabIndex = 1;
            this.usersEmailTextBox.TextChanged += new System.EventHandler(this.usersEmailTextBox_TextChanged);
            // 
            // usersPasswordTextBox
            // 
            this.usersPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersPasswordTextBox.Location = new System.Drawing.Point(37, 165);
            this.usersPasswordTextBox.Name = "usersPasswordTextBox";
            this.usersPasswordTextBox.PasswordChar = '●';
            this.usersPasswordTextBox.Size = new System.Drawing.Size(234, 22);
            this.usersPasswordTextBox.TabIndex = 2;
            // 
            // signInButton
            // 
            this.signInButton.Enabled = false;
            this.signInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInButton.Location = new System.Drawing.Point(78, 218);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(154, 43);
            this.signInButton.TabIndex = 3;
            this.signInButton.Text = "Увійти";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(34, 90);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(184, 16);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Введіть електронну пошту:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(34, 149);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(110, 16);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Введіть пароль:";
            // 
            // signUpSuggestionLabel
            // 
            this.signUpSuggestionLabel.AutoSize = true;
            this.signUpSuggestionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.signUpSuggestionLabel.Location = new System.Drawing.Point(75, 273);
            this.signUpSuggestionLabel.Name = "signUpSuggestionLabel";
            this.signUpSuggestionLabel.Size = new System.Drawing.Size(157, 13);
            this.signUpSuggestionLabel.TabIndex = 6;
            this.signUpSuggestionLabel.Text = "Не маєте облікового запису?";
            // 
            // signUpLinkLabel
            // 
            this.signUpLinkLabel.AutoSize = true;
            this.signUpLinkLabel.Location = new System.Drawing.Point(105, 296);
            this.signUpLinkLabel.Name = "signUpLinkLabel";
            this.signUpLinkLabel.Size = new System.Drawing.Size(95, 13);
            this.signUpLinkLabel.TabIndex = 7;
            this.signUpLinkLabel.TabStop = true;
            this.signUpLinkLabel.Text = "Зареєструватися";
            this.signUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLinkLabel_LinkClicked);
            // 
            // mailCheckerLabel
            // 
            this.mailCheckerLabel.AutoSize = true;
            this.mailCheckerLabel.ForeColor = System.Drawing.Color.Red;
            this.mailCheckerLabel.Location = new System.Drawing.Point(35, 128);
            this.mailCheckerLabel.Name = "mailCheckerLabel";
            this.mailCheckerLabel.Size = new System.Drawing.Size(0, 13);
            this.mailCheckerLabel.TabIndex = 8;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 350);
            this.Controls.Add(this.mailCheckerLabel);
            this.Controls.Add(this.signUpLinkLabel);
            this.Controls.Add(this.signUpSuggestionLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.usersPasswordTextBox);
            this.Controls.Add(this.usersEmailTextBox);
            this.Controls.Add(this.signInLabel);
            this.MaximumSize = new System.Drawing.Size(326, 389);
            this.MinimumSize = new System.Drawing.Size(326, 389);
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Misto App Sign in";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signInLabel;
        private System.Windows.Forms.TextBox usersEmailTextBox;
        private System.Windows.Forms.TextBox usersPasswordTextBox;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label signUpSuggestionLabel;
        private System.Windows.Forms.LinkLabel signUpLinkLabel;
        private System.Windows.Forms.Label mailCheckerLabel;
    }
}