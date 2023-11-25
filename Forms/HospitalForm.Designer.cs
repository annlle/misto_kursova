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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalForm));
            System.Windows.Forms.ListViewGroup listViewGroup29 = new System.Windows.Forms.ListViewGroup("Вознесенівський", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup30 = new System.Windows.Forms.ListViewGroup("Дніпровський", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup31 = new System.Windows.Forms.ListViewGroup("Заводський", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup32 = new System.Windows.Forms.ListViewGroup("Комунарський", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup33 = new System.Windows.Forms.ListViewGroup("Олександрівський", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup34 = new System.Windows.Forms.ListViewGroup("Хортицький", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup35 = new System.Windows.Forms.ListViewGroup("Шевченківський", System.Windows.Forms.HorizontalAlignment.Left);
            this.backButton = new System.Windows.Forms.Button();
            this.doctorPictureBox = new System.Windows.Forms.PictureBox();
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.signButton = new System.Windows.Forms.Button();
            this.hospitalsListView = new System.Windows.Forms.ListView();
            this.hospitalHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.specializationLabel = new System.Windows.Forms.Label();
            this.appointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.sortLabel = new System.Windows.Forms.Label();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.doctorsListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(67, 62);
            this.backButton.TabIndex = 0;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // doctorPictureBox
            // 
            this.doctorPictureBox.BackColor = System.Drawing.Color.White;
            this.doctorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doctorPictureBox.Location = new System.Drawing.Point(369, 362);
            this.doctorPictureBox.Name = "doctorPictureBox";
            this.doctorPictureBox.Size = new System.Drawing.Size(97, 97);
            this.doctorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doctorPictureBox.TabIndex = 7;
            this.doctorPictureBox.TabStop = false;
            // 
            // doctorNameLabel
            // 
            this.doctorNameLabel.AutoSize = true;
            this.doctorNameLabel.BackColor = System.Drawing.Color.White;
            this.doctorNameLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorNameLabel.Location = new System.Drawing.Point(489, 362);
            this.doctorNameLabel.Name = "doctorNameLabel";
            this.doctorNameLabel.Size = new System.Drawing.Size(85, 21);
            this.doctorNameLabel.TabIndex = 8;
            this.doctorNameLabel.Text = "ПІБ лікаря";
            // 
            // signButton
            // 
            this.signButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signButton.Location = new System.Drawing.Point(492, 557);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(122, 37);
            this.signButton.TabIndex = 10;
            this.signButton.Text = "Записатися";
            this.signButton.UseVisualStyleBackColor = true;
            this.signButton.Click += new System.EventHandler(this.signButton_Click);
            // 
            // hospitalsListView
            // 
            this.hospitalsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hospitalHeader,
            this.adressHeader});
            this.hospitalsListView.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            listViewGroup29.Header = "Вознесенівський";
            listViewGroup29.Name = "listViewGroup1";
            listViewGroup30.Header = "Дніпровський";
            listViewGroup30.Name = "listViewGroup2";
            listViewGroup31.Header = "Заводський";
            listViewGroup31.Name = "listViewGroup3";
            listViewGroup32.Header = "Комунарський";
            listViewGroup32.Name = "listViewGroup4";
            listViewGroup33.Header = "Олександрівський";
            listViewGroup33.Name = "listViewGroup5";
            listViewGroup34.Header = "Хортицький";
            listViewGroup34.Name = "listViewGroup6";
            listViewGroup35.Header = "Шевченківський";
            listViewGroup35.Name = "listViewGroup7";
            this.hospitalsListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup29,
            listViewGroup30,
            listViewGroup31,
            listViewGroup32,
            listViewGroup33,
            listViewGroup34,
            listViewGroup35});
            this.hospitalsListView.HideSelection = false;
            this.hospitalsListView.Location = new System.Drawing.Point(12, 80);
            this.hospitalsListView.MultiSelect = false;
            this.hospitalsListView.Name = "hospitalsListView";
            this.hospitalsListView.Size = new System.Drawing.Size(739, 250);
            this.hospitalsListView.TabIndex = 12;
            this.hospitalsListView.UseCompatibleStateImageBehavior = false;
            this.hospitalsListView.View = System.Windows.Forms.View.Details;
            this.hospitalsListView.SelectedIndexChanged += new System.EventHandler(this.hospitalsListView_SelectedIndexChanged);
            // 
            // hospitalHeader
            // 
            this.hospitalHeader.Text = "Лікарня";
            this.hospitalHeader.Width = 287;
            // 
            // adressHeader
            // 
            this.adressHeader.Text = "Адреса";
            this.adressHeader.Width = 428;
            // 
            // specializationLabel
            // 
            this.specializationLabel.AutoSize = true;
            this.specializationLabel.BackColor = System.Drawing.Color.White;
            this.specializationLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specializationLabel.Location = new System.Drawing.Point(489, 389);
            this.specializationLabel.Name = "specializationLabel";
            this.specializationLabel.Size = new System.Drawing.Size(99, 20);
            this.specializationLabel.TabIndex = 14;
            this.specializationLabel.Text = "Спеціалізація";
            // 
            // appointmentDatePicker
            // 
            this.appointmentDatePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.appointmentDatePicker.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appointmentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentDatePicker.Location = new System.Drawing.Point(465, 526);
            this.appointmentDatePicker.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.appointmentDatePicker.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.appointmentDatePicker.Name = "appointmentDatePicker";
            this.appointmentDatePicker.Size = new System.Drawing.Size(173, 25);
            this.appointmentDatePicker.TabIndex = 15;
            this.appointmentDatePicker.Value = new System.DateTime(2023, 1, 1, 12, 0, 0, 0);
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.BackColor = System.Drawing.Color.Transparent;
            this.sortLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortLabel.Location = new System.Drawing.Point(401, 52);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(102, 21);
            this.sortLabel.TabIndex = 16;
            this.sortLabel.Text = "Сортувати за";
            // 
            // sortComboBox
            // 
            this.sortComboBox.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "А-Я",
            "Я-А"});
            this.sortComboBox.Location = new System.Drawing.Point(509, 50);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(242, 28);
            this.sortComboBox.TabIndex = 17;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // doctorsListBox
            // 
            this.doctorsListBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.doctorsListBox.FormattingEnabled = true;
            this.doctorsListBox.ItemHeight = 20;
            this.doctorsListBox.Location = new System.Drawing.Point(12, 336);
            this.doctorsListBox.Name = "doctorsListBox";
            this.doctorsListBox.Size = new System.Drawing.Size(249, 264);
            this.doctorsListBox.TabIndex = 18;
            this.doctorsListBox.SelectedIndexChanged += new System.EventHandler(this.doctorsListBox_SelectedIndexChanged);
            // 
            // HospitalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 611);
            this.Controls.Add(this.doctorsListBox);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.sortLabel);
            this.Controls.Add(this.appointmentDatePicker);
            this.Controls.Add(this.specializationLabel);
            this.Controls.Add(this.hospitalsListView);
            this.Controls.Add(this.signButton);
            this.Controls.Add(this.doctorNameLabel);
            this.Controls.Add(this.doctorPictureBox);
            this.Controls.Add(this.backButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HospitalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Лікарня";
            this.Load += new System.EventHandler(this.HospitalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox doctorPictureBox;
        private System.Windows.Forms.Label doctorNameLabel;
        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.ListView hospitalsListView;
        private System.Windows.Forms.ColumnHeader hospitalHeader;
        private System.Windows.Forms.ColumnHeader adressHeader;
        private System.Windows.Forms.Label specializationLabel;
        private System.Windows.Forms.DateTimePicker appointmentDatePicker;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.ListBox doctorsListBox;
    }
}