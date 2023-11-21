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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SafetyForm));
            this.typeLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.levelSafetyLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.postButton = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.eventPanel = new System.Windows.Forms.Panel();
            this.eventTileTemplate = new System.Windows.Forms.Panel();
            this.locationLinkTileTemplate = new System.Windows.Forms.PictureBox();
            this.locationTileTemplate = new System.Windows.Forms.Label();
            this.typeTileTemplate = new System.Windows.Forms.Label();
            this.safetyListLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDanger = new System.Windows.Forms.Panel();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.eventTileTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationLinkTileTemplate)).BeginInit();
            this.panelDanger.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(23, 148);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(127, 24);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Що відбулося:";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(149)))), ((int)(((byte)(164)))));
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(14, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(65, 60);
            this.backButton.TabIndex = 2;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // levelSafetyLabel
            // 
            this.levelSafetyLabel.AutoSize = true;
            this.levelSafetyLabel.BackColor = System.Drawing.Color.Transparent;
            this.levelSafetyLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelSafetyLabel.Location = new System.Drawing.Point(23, 222);
            this.levelSafetyLabel.Name = "levelSafetyLabel";
            this.levelSafetyLabel.Size = new System.Drawing.Size(164, 24);
            this.levelSafetyLabel.TabIndex = 3;
            this.levelSafetyLabel.Text = "Рівень небезпеки:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(23, 256);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(56, 24);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Опис:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.Location = new System.Drawing.Point(189, 255);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(166, 145);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // postButton
            // 
            this.postButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.typeComboBox.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(189, 151);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(166, 29);
            this.typeComboBox.TabIndex = 8;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.BackColor = System.Drawing.Color.Transparent;
            this.locationLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locationLabel.Location = new System.Drawing.Point(23, 185);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(74, 24);
            this.locationLabel.TabIndex = 9;
            this.locationLabel.Text = "Адреса:";
            // 
            // eventPanel
            // 
            this.eventPanel.AutoScroll = true;
            this.eventPanel.BackColor = System.Drawing.Color.Transparent;
            this.eventPanel.Location = new System.Drawing.Point(436, 147);
            this.eventPanel.Name = "eventPanel";
            this.eventPanel.Size = new System.Drawing.Size(338, 358);
            this.eventPanel.TabIndex = 11;
            // 
            // eventTileTemplate
            // 
            this.eventTileTemplate.BackColor = System.Drawing.Color.Transparent;
            this.eventTileTemplate.Controls.Add(this.locationLinkTileTemplate);
            this.eventTileTemplate.Controls.Add(this.locationTileTemplate);
            this.eventTileTemplate.Controls.Add(this.typeTileTemplate);
            this.eventTileTemplate.Location = new System.Drawing.Point(436, 12);
            this.eventTileTemplate.Name = "eventTileTemplate";
            this.eventTileTemplate.Size = new System.Drawing.Size(320, 60);
            this.eventTileTemplate.TabIndex = 12;
            this.eventTileTemplate.Visible = false;
            this.eventTileTemplate.Paint += new System.Windows.Forms.PaintEventHandler(this.EventTile_Paint);
            // 
            // locationLinkTileTemplate
            // 
            this.locationLinkTileTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.locationLinkTileTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationLinkTileTemplate.Image = ((System.Drawing.Image)(resources.GetObject("locationLinkTileTemplate.Image")));
            this.locationLinkTileTemplate.Location = new System.Drawing.Point(260, 5);
            this.locationLinkTileTemplate.Name = "locationLinkTileTemplate";
            this.locationLinkTileTemplate.Size = new System.Drawing.Size(50, 50);
            this.locationLinkTileTemplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.locationLinkTileTemplate.TabIndex = 3;
            this.locationLinkTileTemplate.TabStop = false;
            // 
            // locationTileTemplate
            // 
            this.locationTileTemplate.BackColor = System.Drawing.Color.Transparent;
            this.locationTileTemplate.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locationTileTemplate.Location = new System.Drawing.Point(30, 25);
            this.locationTileTemplate.Name = "locationTileTemplate";
            this.locationTileTemplate.Size = new System.Drawing.Size(215, 35);
            this.locationTileTemplate.TabIndex = 2;
            this.locationTileTemplate.Text = "Космічний житломасив, Запоріжжя, Запорізька область, 69000\r\n";
            // 
            // typeTileTemplate
            // 
            this.typeTileTemplate.BackColor = System.Drawing.Color.Transparent;
            this.typeTileTemplate.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeTileTemplate.Location = new System.Drawing.Point(30, 5);
            this.typeTileTemplate.Name = "typeTileTemplate";
            this.typeTileTemplate.Size = new System.Drawing.Size(215, 21);
            this.typeTileTemplate.TabIndex = 0;
            this.typeTileTemplate.Text = "Суета Alarm";
            // 
            // safetyListLabel
            // 
            this.safetyListLabel.AutoSize = true;
            this.safetyListLabel.BackColor = System.Drawing.Color.Transparent;
            this.safetyListLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.safetyListLabel.Location = new System.Drawing.Point(524, 99);
            this.safetyListLabel.Name = "safetyListLabel";
            this.safetyListLabel.Size = new System.Drawing.Size(157, 30);
            this.safetyListLabel.TabIndex = 13;
            this.safetyListLabel.Text = "Список подій";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Додати подію";
            // 
            // panelDanger
            // 
            this.panelDanger.Controls.Add(this.locationListBox);
            this.panelDanger.Location = new System.Drawing.Point(189, 226);
            this.panelDanger.Name = "panelDanger";
            this.panelDanger.Size = new System.Drawing.Size(166, 20);
            this.panelDanger.TabIndex = 15;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locationTextBox.Location = new System.Drawing.Point(189, 189);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(166, 26);
            this.locationTextBox.TabIndex = 16;
            this.locationTextBox.TextChanged += new System.EventHandler(this.locationTextBox_TextChanged);
            this.locationTextBox.Leave += new System.EventHandler(this.locationTextBox_Leave);
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.Location = new System.Drawing.Point(0, -4);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(166, 30);
            this.locationListBox.TabIndex = 17;
            this.locationListBox.Visible = false;
            this.locationListBox.SelectedIndexChanged += new System.EventHandler(this.locationListBox_SelectedIndexChanged);
            // 
            // SafetyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 537);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.panelDanger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.safetyListLabel);
            this.Controls.Add(this.eventTileTemplate);
            this.Controls.Add(this.eventPanel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.levelSafetyLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.typeLabel);
            this.DoubleBuffered = true;
            this.Name = "SafetyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Safety";
            this.Load += new System.EventHandler(this.SafetyForm_Load);
            this.eventTileTemplate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.locationLinkTileTemplate)).EndInit();
            this.panelDanger.ResumeLayout(false);
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
        private System.Windows.Forms.Panel eventPanel;
        private System.Windows.Forms.Panel eventTileTemplate;
        private System.Windows.Forms.Label typeTileTemplate;
        private System.Windows.Forms.Label locationTileTemplate;
        private System.Windows.Forms.Label safetyListLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDanger;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.PictureBox locationLinkTileTemplate;
    }
}