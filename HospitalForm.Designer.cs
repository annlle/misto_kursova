namespace kursova
{
    partial class HospitalForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.districtLabel = new System.Windows.Forms.Label();
            this.hospitalLabel = new System.Windows.Forms.Label();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.districtComboBox = new System.Windows.Forms.ComboBox();
            this.hospitalComboBox = new System.Windows.Forms.ComboBox();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.doctorPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.doctorInfoLabel = new System.Windows.Forms.Label();
            this.signButton = new System.Windows.Forms.Button();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(104, 46);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "НАЗАД";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // districtLabel
            // 
            this.districtLabel.AutoSize = true;
            this.districtLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.districtLabel.Location = new System.Drawing.Point(18, 109);
            this.districtLabel.Name = "districtLabel";
            this.districtLabel.Size = new System.Drawing.Size(68, 22);
            this.districtLabel.TabIndex = 1;
            this.districtLabel.Text = "Район:";
            // 
            // hospitalLabel
            // 
            this.hospitalLabel.AutoSize = true;
            this.hospitalLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hospitalLabel.Location = new System.Drawing.Point(18, 147);
            this.hospitalLabel.Name = "hospitalLabel";
            this.hospitalLabel.Size = new System.Drawing.Size(84, 22);
            this.hospitalLabel.TabIndex = 2;
            this.hospitalLabel.Text = "Лікарня:";
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorLabel.Location = new System.Drawing.Point(18, 186);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(63, 22);
            this.doctorLabel.TabIndex = 3;
            this.doctorLabel.Text = "Лікар:";
            // 
            // districtComboBox
            // 
            this.districtComboBox.FormattingEnabled = true;
            this.districtComboBox.Items.AddRange(new object[] {
            "Вознесенівський",
            "Дніпровський",
            "Заводський",
            "Комунарський",
            "Олександрівський",
            "Хортицький",
            "Шевченківський"});
            this.districtComboBox.Location = new System.Drawing.Point(141, 112);
            this.districtComboBox.Name = "districtComboBox";
            this.districtComboBox.Size = new System.Drawing.Size(230, 21);
            this.districtComboBox.TabIndex = 4;
            this.districtComboBox.SelectedIndexChanged += new System.EventHandler(this.districtComboBox_SelectedIndexChanged);
            // 
            // hospitalComboBox
            // 
            this.hospitalComboBox.FormattingEnabled = true;
            this.hospitalComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.hospitalComboBox.Location = new System.Drawing.Point(141, 150);
            this.hospitalComboBox.Name = "hospitalComboBox";
            this.hospitalComboBox.Size = new System.Drawing.Size(230, 21);
            this.hospitalComboBox.TabIndex = 5;
            this.hospitalComboBox.SelectedIndexChanged += new System.EventHandler(this.hospitalComboBox_SelectedIndexChanged);
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Items.AddRange(new object[] {
            "Гастроентеролог",
            "Дерматолог",
            "Ендокринолог",
            "Кардіолог",
            "Косметолог",
            "Логопед",
            "Масажист",
            "Невролог",
            "Онколог",
            "Офтальмолог",
            "Педіатр",
            "Психотерапевт",
            "Стоматолог",
            "Терапевт",
            ""});
            this.doctorComboBox.Location = new System.Drawing.Point(141, 189);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(230, 21);
            this.doctorComboBox.TabIndex = 6;
            this.doctorComboBox.SelectedIndexChanged += new System.EventHandler(this.doctorComboBox_SelectedIndexChanged);
            // 
            // doctorPhotoPictureBox
            // 
            this.doctorPhotoPictureBox.Location = new System.Drawing.Point(12, 243);
            this.doctorPhotoPictureBox.Name = "doctorPhotoPictureBox";
            this.doctorPhotoPictureBox.Size = new System.Drawing.Size(105, 121);
            this.doctorPhotoPictureBox.TabIndex = 7;
            this.doctorPhotoPictureBox.TabStop = false;
            // 
            // doctorNameLabel
            // 
            this.doctorNameLabel.AutoSize = true;
            this.doctorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorNameLabel.Location = new System.Drawing.Point(142, 253);
            this.doctorNameLabel.Name = "doctorNameLabel";
            this.doctorNameLabel.Size = new System.Drawing.Size(83, 16);
            this.doctorNameLabel.TabIndex = 8;
            this.doctorNameLabel.Text = "ПІБ лікаря";
            // 
            // doctorInfoLabel
            // 
            this.doctorInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorInfoLabel.Location = new System.Drawing.Point(142, 288);
            this.doctorInfoLabel.Name = "doctorInfoLabel";
            this.doctorInfoLabel.Size = new System.Drawing.Size(229, 52);
            this.doctorInfoLabel.TabIndex = 9;
            this.doctorInfoLabel.Text = "Інфо про лікаря";
            // 
            // signButton
            // 
            this.signButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signButton.Location = new System.Drawing.Point(141, 403);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(122, 37);
            this.signButton.TabIndex = 10;
            this.signButton.Text = "Записатися";
            this.signButton.UseVisualStyleBackColor = true;
            // 
            // timeComboBox
            // 
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Location = new System.Drawing.Point(141, 343);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(106, 21);
            this.timeComboBox.TabIndex = 11;
            this.timeComboBox.SelectedIndexChanged += new System.EventHandler(this.timeComboBox_SelectedIndexChanged);
            // 
            // HospitalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 467);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.signButton);
            this.Controls.Add(this.doctorInfoLabel);
            this.Controls.Add(this.doctorNameLabel);
            this.Controls.Add(this.doctorPhotoPictureBox);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.hospitalComboBox);
            this.Controls.Add(this.districtComboBox);
            this.Controls.Add(this.doctorLabel);
            this.Controls.Add(this.hospitalLabel);
            this.Controls.Add(this.districtLabel);
            this.Controls.Add(this.backButton);
            this.Name = "HospitalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hospital";
            this.Load += new System.EventHandler(this.HospitalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label districtLabel;
        private System.Windows.Forms.Label hospitalLabel;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.ComboBox districtComboBox;
        private System.Windows.Forms.ComboBox hospitalComboBox;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.PictureBox doctorPhotoPictureBox;
        private System.Windows.Forms.Label doctorNameLabel;
        private System.Windows.Forms.Label doctorInfoLabel;
        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.ComboBox timeComboBox;
    }
}