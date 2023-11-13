namespace kursova
{
    partial class PublicTransportForm
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
            this.routePanel = new System.Windows.Forms.Panel();
            this.routeTileTemplate = new System.Windows.Forms.Panel();
            this.timeTileTemplate = new System.Windows.Forms.Label();
            this.frequencyTileTemplate = new System.Windows.Forms.Label();
            this.directionTileTemplate = new System.Windows.Forms.Label();
            this.numberTileTemplate = new System.Windows.Forms.Label();
            this.PictureTileTemplate = new System.Windows.Forms.PictureBox();
            this.listOfStationsLabel = new System.Windows.Forms.Label();
            this.stationLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.routeTileTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureTileTemplate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 25);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "НАЗАД";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // routePanel
            // 
            this.routePanel.AutoScroll = true;
            this.routePanel.Location = new System.Drawing.Point(29, 185);
            this.routePanel.Name = "routePanel";
            this.routePanel.Size = new System.Drawing.Size(323, 297);
            this.routePanel.TabIndex = 10;
            // 
            // routeTileTemplate
            // 
            this.routeTileTemplate.Controls.Add(this.timeTileTemplate);
            this.routeTileTemplate.Controls.Add(this.frequencyTileTemplate);
            this.routeTileTemplate.Controls.Add(this.directionTileTemplate);
            this.routeTileTemplate.Controls.Add(this.numberTileTemplate);
            this.routeTileTemplate.Controls.Add(this.PictureTileTemplate);
            this.routeTileTemplate.Location = new System.Drawing.Point(148, 12);
            this.routeTileTemplate.Name = "routeTileTemplate";
            this.routeTileTemplate.Size = new System.Drawing.Size(305, 60);
            this.routeTileTemplate.TabIndex = 11;
            this.routeTileTemplate.Visible = false;
            this.routeTileTemplate.Paint += new System.Windows.Forms.PaintEventHandler(this.RouteTile_Paint);
            // 
            // timeTileTemplate
            // 
            this.timeTileTemplate.BackColor = System.Drawing.Color.Transparent;
            this.timeTileTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTileTemplate.Location = new System.Drawing.Point(230, 5);
            this.timeTileTemplate.Name = "timeTileTemplate";
            this.timeTileTemplate.Size = new System.Drawing.Size(70, 50);
            this.timeTileTemplate.TabIndex = 4;
            this.timeTileTemplate.Text = "10:00\r\n20:00";
            this.timeTileTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frequencyTileTemplate
            // 
            this.frequencyTileTemplate.BackColor = System.Drawing.Color.Transparent;
            this.frequencyTileTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frequencyTileTemplate.Location = new System.Drawing.Point(125, 33);
            this.frequencyTileTemplate.Name = "frequencyTileTemplate";
            this.frequencyTileTemplate.Size = new System.Drawing.Size(100, 22);
            this.frequencyTileTemplate.TabIndex = 3;
            this.frequencyTileTemplate.Text = "Кожні 20-30 хв.";
            this.frequencyTileTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // directionTileTemplate
            // 
            this.directionTileTemplate.BackColor = System.Drawing.Color.Transparent;
            this.directionTileTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directionTileTemplate.Location = new System.Drawing.Point(125, 5);
            this.directionTileTemplate.Name = "directionTileTemplate";
            this.directionTileTemplate.Size = new System.Drawing.Size(100, 22);
            this.directionTileTemplate.TabIndex = 2;
            this.directionTileTemplate.Text = "Зворотній";
            this.directionTileTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numberTileTemplate
            // 
            this.numberTileTemplate.BackColor = System.Drawing.Color.Transparent;
            this.numberTileTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberTileTemplate.Location = new System.Drawing.Point(60, 5);
            this.numberTileTemplate.Name = "numberTileTemplate";
            this.numberTileTemplate.Size = new System.Drawing.Size(60, 50);
            this.numberTileTemplate.TabIndex = 1;
            this.numberTileTemplate.Text = "39";
            this.numberTileTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureTileTemplate
            // 
            this.PictureTileTemplate.BackColor = System.Drawing.Color.Transparent;
            this.PictureTileTemplate.Location = new System.Drawing.Point(5, 5);
            this.PictureTileTemplate.Name = "PictureTileTemplate";
            this.PictureTileTemplate.Size = new System.Drawing.Size(50, 50);
            this.PictureTileTemplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureTileTemplate.TabIndex = 0;
            this.PictureTileTemplate.TabStop = false;
            // 
            // listOfStationsLabel
            // 
            this.listOfStationsLabel.Location = new System.Drawing.Point(388, 209);
            this.listOfStationsLabel.Name = "listOfStationsLabel";
            this.listOfStationsLabel.Size = new System.Drawing.Size(225, 273);
            this.listOfStationsLabel.TabIndex = 12;
            this.listOfStationsLabel.Text = "Оберіть маршрут";
            // 
            // stationLabel
            // 
            this.stationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stationLabel.Location = new System.Drawing.Point(448, 176);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(93, 22);
            this.stationLabel.TabIndex = 13;
            this.stationLabel.Text = "Зупинки";
            this.stationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(29, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 86);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Напрямок";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(127, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(80, 45);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пошук";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton8);
            this.groupBox3.Controls.Add(this.radioButton7);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Location = new System.Drawing.Point(213, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 45);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вид транспорту";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 17);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Не важливо";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(5, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Прямий";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(5, 64);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(75, 17);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Зворотній";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 0;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(76, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Будь-який";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(84, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(82, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Маршрутка";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(169, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(66, 17);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Автобус";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(239, 19);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(79, 17);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Тролейбус";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(321, 19);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(70, 17);
            this.radioButton8.TabIndex = 4;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Трамвай";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // PublicTransportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 512);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stationLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listOfStationsLabel);
            this.Controls.Add(this.routeTileTemplate);
            this.Controls.Add(this.routePanel);
            this.Controls.Add(this.backButton);
            this.Name = "PublicTransportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Public Transport";
            this.Load += new System.EventHandler(this.PublicTransportForm_Load);
            this.routeTileTemplate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureTileTemplate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel routePanel;
        private System.Windows.Forms.Panel routeTileTemplate;
        private System.Windows.Forms.Label numberTileTemplate;
        private System.Windows.Forms.PictureBox PictureTileTemplate;
        private System.Windows.Forms.Label directionTileTemplate;
        private System.Windows.Forms.Label timeTileTemplate;
        private System.Windows.Forms.Label frequencyTileTemplate;
        private System.Windows.Forms.Label listOfStationsLabel;
        private System.Windows.Forms.Label stationLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
    }
}