namespace kursova
{
    partial class SafetyForm
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
            this.typeLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.levelSafetyLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.postButton = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.safetyListPanel = new System.Windows.Forms.Panel();
            this.safetyPanel = new System.Windows.Forms.Panel();
            this.locationPanelLabel = new System.Windows.Forms.Label();
            this.levelSafetyPanelLabel = new System.Windows.Forms.Label();
            this.typePanelLabel = new System.Windows.Forms.Label();
            this.safetyListLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDanger = new System.Windows.Forms.Panel();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.safetyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(23, 148);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(127, 20);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Що відбулося:";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(14, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 29);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "НАЗАД";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // levelSafetyLabel
            // 
            this.levelSafetyLabel.AutoSize = true;
            this.levelSafetyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelSafetyLabel.Location = new System.Drawing.Point(23, 222);
            this.levelSafetyLabel.Name = "levelSafetyLabel";
            this.levelSafetyLabel.Size = new System.Drawing.Size(162, 20);
            this.levelSafetyLabel.TabIndex = 3;
            this.levelSafetyLabel.Text = "Рівень небезпеки:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(23, 256);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(56, 20);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Опис:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(189, 256);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(166, 145);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // postButton
            // 
            this.postButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postButton.Location = new System.Drawing.Point(121, 439);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(130, 42);
            this.postButton.TabIndex = 7;
            this.postButton.Text = "Опублікувати";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Пограбування",
            "Пожежа"});
            this.typeComboBox.Location = new System.Drawing.Point(189, 147);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(166, 21);
            this.typeComboBox.TabIndex = 8;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locationLabel.Location = new System.Drawing.Point(23, 185);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(77, 20);
            this.locationLabel.TabIndex = 9;
            this.locationLabel.Text = "Адреса:";
            // 
            // safetyListPanel
            // 
            this.safetyListPanel.Location = new System.Drawing.Point(436, 147);
            this.safetyListPanel.Name = "safetyListPanel";
            this.safetyListPanel.Size = new System.Drawing.Size(319, 254);
            this.safetyListPanel.TabIndex = 11;
            // 
            // safetyPanel
            // 
            this.safetyPanel.Controls.Add(this.locationPanelLabel);
            this.safetyPanel.Controls.Add(this.levelSafetyPanelLabel);
            this.safetyPanel.Controls.Add(this.typePanelLabel);
            this.safetyPanel.Location = new System.Drawing.Point(436, 439);
            this.safetyPanel.Name = "safetyPanel";
            this.safetyPanel.Size = new System.Drawing.Size(319, 60);
            this.safetyPanel.TabIndex = 12;
            this.safetyPanel.Visible = false;
            // 
            // locationPanelLabel
            // 
            this.locationPanelLabel.AutoSize = true;
            this.locationPanelLabel.Location = new System.Drawing.Point(21, 36);
            this.locationPanelLabel.Name = "locationPanelLabel";
            this.locationPanelLabel.Size = new System.Drawing.Size(44, 13);
            this.locationPanelLabel.TabIndex = 2;
            this.locationPanelLabel.Text = "Адреса";
            // 
            // levelSafetyPanelLabel
            // 
            this.levelSafetyPanelLabel.AutoSize = true;
            this.levelSafetyPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelSafetyPanelLabel.Location = new System.Drawing.Point(196, 20);
            this.levelSafetyPanelLabel.Name = "levelSafetyPanelLabel";
            this.levelSafetyPanelLabel.Size = new System.Drawing.Size(56, 16);
            this.levelSafetyPanelLabel.TabIndex = 1;
            this.levelSafetyPanelLabel.Text = "Рівень";
            // 
            // typePanelLabel
            // 
            this.typePanelLabel.AutoSize = true;
            this.typePanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typePanelLabel.Location = new System.Drawing.Point(20, 5);
            this.typePanelLabel.Name = "typePanelLabel";
            this.typePanelLabel.Size = new System.Drawing.Size(122, 20);
            this.typePanelLabel.TabIndex = 0;
            this.typePanelLabel.Text = "Що відбулося";
            // 
            // safetyListLabel
            // 
            this.safetyListLabel.AutoSize = true;
            this.safetyListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.safetyListLabel.Location = new System.Drawing.Point(523, 83);
            this.safetyListLabel.Name = "safetyListLabel";
            this.safetyListLabel.Size = new System.Drawing.Size(141, 24);
            this.safetyListLabel.TabIndex = 13;
            this.safetyListLabel.Text = "Список подій";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(104, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Додати подію";
            // 
            // panelDanger
            // 
            this.panelDanger.Location = new System.Drawing.Point(189, 222);
            this.panelDanger.Name = "panelDanger";
            this.panelDanger.Size = new System.Drawing.Size(166, 20);
            this.panelDanger.TabIndex = 15;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(189, 185);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(166, 20);
            this.locationTextBox.TabIndex = 16;
            this.locationTextBox.TextChanged += new System.EventHandler(this.locationTextBox_TextChanged);
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.Location = new System.Drawing.Point(189, 207);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(166, 43);
            this.locationListBox.TabIndex = 17;
            this.locationListBox.Visible = false;
            this.locationListBox.SelectedIndexChanged += new System.EventHandler(this.locationListBox_SelectedIndexChanged);
            // 
            // SafetyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 537);
            this.Controls.Add(this.locationListBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.panelDanger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.safetyListLabel);
            this.Controls.Add(this.safetyPanel);
            this.Controls.Add(this.safetyListPanel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.levelSafetyLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.typeLabel);
            this.Name = "SafetyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Safety";
            this.Load += new System.EventHandler(this.SafetyForm_Load);
            this.safetyPanel.ResumeLayout(false);
            this.safetyPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label levelSafetyLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Panel safetyListPanel;
        private System.Windows.Forms.Panel safetyPanel;
        private System.Windows.Forms.Label typePanelLabel;
        private System.Windows.Forms.Label levelSafetyPanelLabel;
        private System.Windows.Forms.Label locationPanelLabel;
        private System.Windows.Forms.Label safetyListLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDanger;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.ListBox locationListBox;
    }
}