namespace kursova
{
    partial class TravelInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelInfoForm));
            this.attractionPictureBox = new System.Windows.Forms.PictureBox();
            this.attractionTextLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sightLabel = new System.Windows.Forms.Label();
            this.attractionsComboBox = new System.Windows.Forms.ComboBox();
            this.locationLinkPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.attractionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationLinkPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // attractionPictureBox
            // 
            this.attractionPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attractionPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("attractionPictureBox.Image")));
            this.attractionPictureBox.Location = new System.Drawing.Point(383, 103);
            this.attractionPictureBox.Name = "attractionPictureBox";
            this.attractionPictureBox.Size = new System.Drawing.Size(394, 302);
            this.attractionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.attractionPictureBox.TabIndex = 0;
            this.attractionPictureBox.TabStop = false;
            // 
            // attractionTextLabel
            // 
            this.attractionTextLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attractionTextLabel.Location = new System.Drawing.Point(22, 112);
            this.attractionTextLabel.Name = "attractionTextLabel";
            this.attractionTextLabel.Size = new System.Drawing.Size(355, 302);
            this.attractionTextLabel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "НАЗАД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.backButton_Click);
            // 
            // sightLabel
            // 
            this.sightLabel.AutoSize = true;
            this.sightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sightLabel.Location = new System.Drawing.Point(161, 51);
            this.sightLabel.Name = "sightLabel";
            this.sightLabel.Size = new System.Drawing.Size(159, 20);
            this.sightLabel.TabIndex = 3;
            this.sightLabel.Text = "Оберіть пам\'ятку:";
            // 
            // attractionsComboBox
            // 
            this.attractionsComboBox.FormattingEnabled = true;
            this.attractionsComboBox.Location = new System.Drawing.Point(326, 51);
            this.attractionsComboBox.Name = "attractionsComboBox";
            this.attractionsComboBox.Size = new System.Drawing.Size(287, 21);
            this.attractionsComboBox.TabIndex = 4;
            this.attractionsComboBox.SelectedIndexChanged += new System.EventHandler(this.attractionsComboBox_SelectedIndexChanged);
            // 
            // locationLinkPictureBox
            // 
            this.locationLinkPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationLinkPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("locationLinkPictureBox.Image")));
            this.locationLinkPictureBox.Location = new System.Drawing.Point(728, 12);
            this.locationLinkPictureBox.Name = "locationLinkPictureBox";
            this.locationLinkPictureBox.Size = new System.Drawing.Size(60, 60);
            this.locationLinkPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.locationLinkPictureBox.TabIndex = 23;
            this.locationLinkPictureBox.TabStop = false;
            this.locationLinkPictureBox.Click += new System.EventHandler(this.locationLinkPictureBox_Click);
            // 
            // TravelInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.locationLinkPictureBox);
            this.Controls.Add(this.attractionsComboBox);
            this.Controls.Add(this.sightLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.attractionTextLabel);
            this.Controls.Add(this.attractionPictureBox);
            this.Name = "TravelInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Travel Info";
            this.Load += new System.EventHandler(this.TravelInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attractionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationLinkPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox attractionPictureBox;
        private System.Windows.Forms.Label attractionTextLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sightLabel;
        private System.Windows.Forms.ComboBox attractionsComboBox;
        private System.Windows.Forms.PictureBox locationLinkPictureBox;
    }
}