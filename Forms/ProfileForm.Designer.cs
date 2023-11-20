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
            this.usersEmailLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.appointmentsListBox = new System.Windows.Forms.ListBox();
            this.hospitalTitleLabel = new System.Windows.Forms.Label();
            this.doctorTitleLabel = new System.Windows.Forms.Label();
            this.dateTitleLabel = new System.Windows.Forms.Label();
            this.locationLinkPictureBox = new System.Windows.Forms.PictureBox();
            this.hospitalLabel = new System.Windows.Forms.Label();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationLinkPictureBox)).BeginInit();
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
            this.surnameLabel.Location = new System.Drawing.Point(197, 62);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(81, 16);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Прізвище:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(197, 92);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(37, 16);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Ім\'я:";
            // 
            // patronymLabel
            // 
            this.patronymLabel.AutoSize = true;
            this.patronymLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymLabel.Location = new System.Drawing.Point(197, 125);
            this.patronymLabel.Name = "patronymLabel";
            this.patronymLabel.Size = new System.Drawing.Size(99, 16);
            this.patronymLabel.TabIndex = 3;
            this.patronymLabel.Text = "По батькові:";
            // 
            // usersSurnameLabel
            // 
            this.usersSurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersSurnameLabel.Location = new System.Drawing.Point(312, 62);
            this.usersSurnameLabel.Name = "usersSurnameLabel";
            this.usersSurnameLabel.Size = new System.Drawing.Size(223, 16);
            this.usersSurnameLabel.TabIndex = 4;
            this.usersSurnameLabel.Text = "label4";
            // 
            // usersNameLabel
            // 
            this.usersNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersNameLabel.Location = new System.Drawing.Point(312, 92);
            this.usersNameLabel.Name = "usersNameLabel";
            this.usersNameLabel.Size = new System.Drawing.Size(223, 16);
            this.usersNameLabel.TabIndex = 5;
            this.usersNameLabel.Text = "label5";
            // 
            // usersPatronymLabel
            // 
            this.usersPatronymLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersPatronymLabel.Location = new System.Drawing.Point(312, 125);
            this.usersPatronymLabel.Name = "usersPatronymLabel";
            this.usersPatronymLabel.Size = new System.Drawing.Size(223, 16);
            this.usersPatronymLabel.TabIndex = 6;
            this.usersPatronymLabel.Text = "label6";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexLabel.Location = new System.Drawing.Point(197, 157);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(54, 16);
            this.sexLabel.TabIndex = 7;
            this.sexLabel.Text = "Стать:";
            // 
            // usersSexLabel
            // 
            this.usersSexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersSexLabel.Location = new System.Drawing.Point(312, 157);
            this.usersSexLabel.Name = "usersSexLabel";
            this.usersSexLabel.Size = new System.Drawing.Size(223, 16);
            this.usersSexLabel.TabIndex = 8;
            this.usersSexLabel.Text = "label8";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.Location = new System.Drawing.Point(197, 190);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(33, 16);
            this.ageLabel.TabIndex = 9;
            this.ageLabel.Text = "Вік:";
            // 
            // usersAgeLabel
            // 
            this.usersAgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersAgeLabel.Location = new System.Drawing.Point(312, 190);
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
            this.usersDoctorsAppointmentLabel.Location = new System.Drawing.Point(142, 277);
            this.usersDoctorsAppointmentLabel.Name = "usersDoctorsAppointmentLabel";
            this.usersDoctorsAppointmentLabel.Size = new System.Drawing.Size(268, 16);
            this.usersDoctorsAppointmentLabel.TabIndex = 14;
            this.usersDoctorsAppointmentLabel.Text = "Актуальні записи на прийоми до лікарів";
            // 
            // usersEmailLabel
            // 
            this.usersEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersEmailLabel.Location = new System.Drawing.Point(172, 238);
            this.usersEmailLabel.Name = "usersEmailLabel";
            this.usersEmailLabel.Size = new System.Drawing.Size(334, 16);
            this.usersEmailLabel.TabIndex = 17;
            this.usersEmailLabel.Text = "label12";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(15, 238);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(151, 16);
            this.emailLabel.TabIndex = 16;
            this.emailLabel.Text = "Електронна пошта:";
            // 
            // appointmentsListBox
            // 
            this.appointmentsListBox.FormattingEnabled = true;
            this.appointmentsListBox.Location = new System.Drawing.Point(12, 300);
            this.appointmentsListBox.Name = "appointmentsListBox";
            this.appointmentsListBox.Size = new System.Drawing.Size(239, 95);
            this.appointmentsListBox.TabIndex = 18;
            this.appointmentsListBox.SelectedIndexChanged += new System.EventHandler(this.appointmentsListBox_SelectedIndexChanged);
            // 
            // hospitalTitleLabel
            // 
            this.hospitalTitleLabel.AutoSize = true;
            this.hospitalTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hospitalTitleLabel.Location = new System.Drawing.Point(261, 300);
            this.hospitalTitleLabel.Name = "hospitalTitleLabel";
            this.hospitalTitleLabel.Size = new System.Drawing.Size(60, 16);
            this.hospitalTitleLabel.TabIndex = 19;
            this.hospitalTitleLabel.Text = "Лікарня:";
            // 
            // doctorTitleLabel
            // 
            this.doctorTitleLabel.AutoSize = true;
            this.doctorTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorTitleLabel.Location = new System.Drawing.Point(261, 325);
            this.doctorTitleLabel.Name = "doctorTitleLabel";
            this.doctorTitleLabel.Size = new System.Drawing.Size(45, 16);
            this.doctorTitleLabel.TabIndex = 20;
            this.doctorTitleLabel.Text = "Лікар:";
            // 
            // dateTitleLabel
            // 
            this.dateTitleLabel.AutoSize = true;
            this.dateTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTitleLabel.Location = new System.Drawing.Point(261, 351);
            this.dateTitleLabel.Name = "dateTitleLabel";
            this.dateTitleLabel.Size = new System.Drawing.Size(42, 16);
            this.dateTitleLabel.TabIndex = 21;
            this.dateTitleLabel.Text = "Дата:";
            // 
            // locationLinkPictureBox
            // 
            this.locationLinkPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationLinkPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("locationLinkPictureBox.Image")));
            this.locationLinkPictureBox.Location = new System.Drawing.Point(501, 355);
            this.locationLinkPictureBox.Name = "locationLinkPictureBox";
            this.locationLinkPictureBox.Size = new System.Drawing.Size(40, 40);
            this.locationLinkPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.locationLinkPictureBox.TabIndex = 22;
            this.locationLinkPictureBox.TabStop = false;
            this.locationLinkPictureBox.Click += new System.EventHandler(this.locationLinkPictureBox_Click);
            // 
            // hospitalLabel
            // 
            this.hospitalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hospitalLabel.Location = new System.Drawing.Point(327, 300);
            this.hospitalLabel.Name = "hospitalLabel";
            this.hospitalLabel.Size = new System.Drawing.Size(214, 16);
            this.hospitalLabel.TabIndex = 23;
            this.hospitalLabel.Text = "label11";
            // 
            // doctorLabel
            // 
            this.doctorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorLabel.Location = new System.Drawing.Point(327, 325);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(214, 16);
            this.doctorLabel.TabIndex = 24;
            this.doctorLabel.Text = "label12";
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(327, 351);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(168, 16);
            this.dateLabel.TabIndex = 25;
            this.dateLabel.Text = "label13";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 407);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.doctorLabel);
            this.Controls.Add(this.hospitalLabel);
            this.Controls.Add(this.locationLinkPictureBox);
            this.Controls.Add(this.dateTitleLabel);
            this.Controls.Add(this.doctorTitleLabel);
            this.Controls.Add(this.hospitalTitleLabel);
            this.Controls.Add(this.appointmentsListBox);
            this.Controls.Add(this.usersEmailLabel);
            this.Controls.Add(this.emailLabel);
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
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationLinkPictureBox)).EndInit();
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
        private System.Windows.Forms.Label usersEmailLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.ListBox appointmentsListBox;
        private System.Windows.Forms.Label hospitalTitleLabel;
        private System.Windows.Forms.Label doctorTitleLabel;
        private System.Windows.Forms.Label dateTitleLabel;
        private System.Windows.Forms.PictureBox locationLinkPictureBox;
        private System.Windows.Forms.Label hospitalLabel;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}