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
            this.sightPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.sightTextLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sightLabel = new System.Windows.Forms.Label();
            this.sightListComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sightPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sightPhotoPictureBox
            // 
            this.sightPhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sightPhotoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("sightPhotoPictureBox.Image")));
            this.sightPhotoPictureBox.Location = new System.Drawing.Point(383, 103);
            this.sightPhotoPictureBox.Name = "sightPhotoPictureBox";
            this.sightPhotoPictureBox.Size = new System.Drawing.Size(394, 302);
            this.sightPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sightPhotoPictureBox.TabIndex = 0;
            this.sightPhotoPictureBox.TabStop = false;
            // 
            // sightTextLabel
            // 
            this.sightTextLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sightTextLabel.Location = new System.Drawing.Point(22, 112);
            this.sightTextLabel.Name = "sightTextLabel";
            this.sightTextLabel.Size = new System.Drawing.Size(355, 302);
            this.sightTextLabel.TabIndex = 1;
            this.sightTextLabel.Text = resources.GetString("sightTextLabel.Text");
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
            // sightListComboBox
            // 
            this.sightListComboBox.FormattingEnabled = true;
            this.sightListComboBox.Location = new System.Drawing.Point(326, 51);
            this.sightListComboBox.Name = "sightListComboBox";
            this.sightListComboBox.Size = new System.Drawing.Size(287, 21);
            this.sightListComboBox.TabIndex = 4;
            // 
            // TravelInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sightListComboBox);
            this.Controls.Add(this.sightLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sightTextLabel);
            this.Controls.Add(this.sightPhotoPictureBox);
            this.Name = "TravelInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Travel Info";
            ((System.ComponentModel.ISupportInitialize)(this.sightPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sightPhotoPictureBox;
        private System.Windows.Forms.Label sightTextLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sightLabel;
        private System.Windows.Forms.ComboBox sightListComboBox;
    }
}