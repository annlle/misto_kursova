namespace kursova
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.patronymLabel = new System.Windows.Forms.Label();
            this.usersSurnameLabel = new System.Windows.Forms.Label();
            this.usersNameLabel = new System.Windows.Forms.Label();
            this.usersPatronymLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.usersSexLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.usersAgeLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.usersDoctorsAppointmentLabel = new System.Windows.Forms.Label();
            this.listOfAppointmentsComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePicture
            // 
            this.profilePicture.Image = ((System.Drawing.Image)(resources.GetObject("profilePicture.Image")));
            this.profilePicture.Location = new System.Drawing.Point(12, 62);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(158, 162);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.Location = new System.Drawing.Point(197, 74);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(67, 16);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Фамілія:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(197, 104);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(37, 16);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Ім\'я:";
            // 
            // patronymLabel
            // 
            this.patronymLabel.AutoSize = true;
            this.patronymLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymLabel.Location = new System.Drawing.Point(197, 137);
            this.patronymLabel.Name = "patronymLabel";
            this.patronymLabel.Size = new System.Drawing.Size(99, 16);
            this.patronymLabel.TabIndex = 3;
            this.patronymLabel.Text = "По батькові:";
            // 
            // usersSurnameLabel
            // 
            this.usersSurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersSurnameLabel.Location = new System.Drawing.Point(312, 74);
            this.usersSurnameLabel.Name = "usersSurnameLabel";
            this.usersSurnameLabel.Size = new System.Drawing.Size(223, 16);
            this.usersSurnameLabel.TabIndex = 4;
            this.usersSurnameLabel.Text = "label4";
            // 
            // usersNameLabel
            // 
            this.usersNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersNameLabel.Location = new System.Drawing.Point(312, 104);
            this.usersNameLabel.Name = "usersNameLabel";
            this.usersNameLabel.Size = new System.Drawing.Size(223, 16);
            this.usersNameLabel.TabIndex = 5;
            this.usersNameLabel.Text = "label5";
            // 
            // usersPatronymLabel
            // 
            this.usersPatronymLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersPatronymLabel.Location = new System.Drawing.Point(312, 137);
            this.usersPatronymLabel.Name = "usersPatronymLabel";
            this.usersPatronymLabel.Size = new System.Drawing.Size(223, 16);
            this.usersPatronymLabel.TabIndex = 6;
            this.usersPatronymLabel.Text = "label6";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexLabel.Location = new System.Drawing.Point(197, 169);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(54, 16);
            this.sexLabel.TabIndex = 7;
            this.sexLabel.Text = "Стать:";
            // 
            // usersSexLabel
            // 
            this.usersSexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersSexLabel.Location = new System.Drawing.Point(312, 169);
            this.usersSexLabel.Name = "usersSexLabel";
            this.usersSexLabel.Size = new System.Drawing.Size(223, 16);
            this.usersSexLabel.TabIndex = 8;
            this.usersSexLabel.Text = "label8";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.Location = new System.Drawing.Point(197, 202);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(33, 16);
            this.ageLabel.TabIndex = 9;
            this.ageLabel.Text = "ВІк:";
            // 
            // usersAgeLabel
            // 
            this.usersAgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersAgeLabel.Location = new System.Drawing.Point(312, 202);
            this.usersAgeLabel.Name = "usersAgeLabel";
            this.usersAgeLabel.Size = new System.Drawing.Size(223, 16);
            this.usersAgeLabel.TabIndex = 10;
            this.usersAgeLabel.Text = "label10";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(68, 25);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "НАЗАД";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // usersDoctorsAppointmentLabel
            // 
            this.usersDoctorsAppointmentLabel.AutoSize = true;
            this.usersDoctorsAppointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersDoctorsAppointmentLabel.Location = new System.Drawing.Point(15, 267);
            this.usersDoctorsAppointmentLabel.Name = "usersDoctorsAppointmentLabel";
            this.usersDoctorsAppointmentLabel.Size = new System.Drawing.Size(271, 16);
            this.usersDoctorsAppointmentLabel.TabIndex = 14;
            this.usersDoctorsAppointmentLabel.Text = "Актуальні записи на прийоми до лікарів:\r\n";
            // 
            // listOfAppointmentsComboBox
            // 
            this.listOfAppointmentsComboBox.FormattingEnabled = true;
            this.listOfAppointmentsComboBox.Location = new System.Drawing.Point(292, 262);
            this.listOfAppointmentsComboBox.Name = "listOfAppointmentsComboBox";
            this.listOfAppointmentsComboBox.Size = new System.Drawing.Size(249, 21);
            this.listOfAppointmentsComboBox.TabIndex = 15;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 337);
            this.Controls.Add(this.listOfAppointmentsComboBox);
            this.Controls.Add(this.usersDoctorsAppointmentLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.usersAgeLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.usersSexLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.usersPatronymLabel);
            this.Controls.Add(this.usersNameLabel);
            this.Controls.Add(this.usersSurnameLabel);
            this.Controls.Add(this.patronymLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.profilePicture);
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProfileForm";
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label patronymLabel;
        private System.Windows.Forms.Label usersSurnameLabel;
        private System.Windows.Forms.Label usersNameLabel;
        private System.Windows.Forms.Label usersPatronymLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label usersSexLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label usersAgeLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label usersDoctorsAppointmentLabel;
        private System.Windows.Forms.ComboBox listOfAppointmentsComboBox;
    }
}