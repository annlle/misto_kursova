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
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Вознесенівський", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Дніпровський", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("Заводський", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("Комунарський", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("Олександрівський", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("Хортицький", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("Шевченківський", System.Windows.Forms.HorizontalAlignment.Left);
            this.backButton = new System.Windows.Forms.Button();
            this.doctorPictureBox = new System.Windows.Forms.PictureBox();
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.signButton = new System.Windows.Forms.Button();
            this.hospitalsListView = new System.Windows.Forms.ListView();
            this.hospitalHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doctorsListView = new System.Windows.Forms.ListView();
            this.specializationLabel = new System.Windows.Forms.Label();
            this.appointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPictureBox)).BeginInit();
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
            // doctorPictureBox
            // 
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
            this.doctorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorNameLabel.Location = new System.Drawing.Point(489, 362);
            this.doctorNameLabel.Name = "doctorNameLabel";
            this.doctorNameLabel.Size = new System.Drawing.Size(83, 16);
            this.doctorNameLabel.TabIndex = 8;
            this.doctorNameLabel.Text = "ПІБ лікаря";
            // 
            // signButton
            // 
            this.signButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.hospitalsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            listViewGroup8.Header = "Вознесенівський";
            listViewGroup8.Name = "listViewGroup1";
            listViewGroup9.Header = "Дніпровський";
            listViewGroup9.Name = "listViewGroup2";
            listViewGroup10.Header = "Заводський";
            listViewGroup10.Name = "listViewGroup3";
            listViewGroup11.Header = "Комунарський";
            listViewGroup11.Name = "listViewGroup4";
            listViewGroup12.Header = "Олександрівський";
            listViewGroup12.Name = "listViewGroup5";
            listViewGroup13.Header = "Хортицький";
            listViewGroup13.Name = "listViewGroup6";
            listViewGroup14.Header = "Шевченківський";
            listViewGroup14.Name = "listViewGroup7";
            this.hospitalsListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup8,
            listViewGroup9,
            listViewGroup10,
            listViewGroup11,
            listViewGroup12,
            listViewGroup13,
            listViewGroup14});
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
            // doctorsListView
            // 
            this.doctorsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorsListView.HideSelection = false;
            this.doctorsListView.Location = new System.Drawing.Point(12, 337);
            this.doctorsListView.Name = "doctorsListView";
            this.doctorsListView.Size = new System.Drawing.Size(249, 257);
            this.doctorsListView.TabIndex = 13;
            this.doctorsListView.UseCompatibleStateImageBehavior = false;
            this.doctorsListView.View = System.Windows.Forms.View.List;
            this.doctorsListView.SelectedIndexChanged += new System.EventHandler(this.doctorsListView_SelectedIndexChanged);
            // 
            // specializationLabel
            // 
            this.specializationLabel.AutoSize = true;
            this.specializationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specializationLabel.Location = new System.Drawing.Point(489, 389);
            this.specializationLabel.Name = "specializationLabel";
            this.specializationLabel.Size = new System.Drawing.Size(86, 15);
            this.specializationLabel.TabIndex = 14;
            this.specializationLabel.Text = "Спеціалізація";
            // 
            // appointmentDatePicker
            // 
            this.appointmentDatePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.appointmentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentDatePicker.Location = new System.Drawing.Point(492, 522);
            this.appointmentDatePicker.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.appointmentDatePicker.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.appointmentDatePicker.Name = "appointmentDatePicker";
            this.appointmentDatePicker.Size = new System.Drawing.Size(122, 20);
            this.appointmentDatePicker.TabIndex = 15;
            this.appointmentDatePicker.Value = new System.DateTime(2023, 1, 1, 12, 0, 0, 0);
            // 
            // HospitalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 606);
            this.Controls.Add(this.appointmentDatePicker);
            this.Controls.Add(this.specializationLabel);
            this.Controls.Add(this.doctorsListView);
            this.Controls.Add(this.hospitalsListView);
            this.Controls.Add(this.signButton);
            this.Controls.Add(this.doctorNameLabel);
            this.Controls.Add(this.doctorPictureBox);
            this.Controls.Add(this.backButton);
            this.Name = "HospitalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hospital";
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
        private System.Windows.Forms.ListView doctorsListView;
        private System.Windows.Forms.Label specializationLabel;
        private System.Windows.Forms.DateTimePicker appointmentDatePicker;
    }
}