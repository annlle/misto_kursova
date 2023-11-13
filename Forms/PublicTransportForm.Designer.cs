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
            this.typeOfTransportLabel = new System.Windows.Forms.Label();
            this.directionLabel = new System.Windows.Forms.Label();
            this.directionButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.marshrutkaButton = new System.Windows.Forms.Button();
            this.trolleybusButton = new System.Windows.Forms.Button();
            this.tramvaiButton = new System.Windows.Forms.Button();
            this.busButton = new System.Windows.Forms.Button();
            this.routePanel = new System.Windows.Forms.Panel();
            this.routeTileTemplate = new System.Windows.Forms.Panel();
            this.timeTileTemplate = new System.Windows.Forms.Label();
            this.frequencyTileTemplate = new System.Windows.Forms.Label();
            this.directionTileTemplate = new System.Windows.Forms.Label();
            this.numberTileTemplate = new System.Windows.Forms.Label();
            this.PictureTileTemplate = new System.Windows.Forms.PictureBox();
            this.listOfStationsLabel = new System.Windows.Forms.Label();
            this.stationLabel = new System.Windows.Forms.Label();
            this.routeTileTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureTileTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // typeOfTransportLabel
            // 
            this.typeOfTransportLabel.AutoSize = true;
            this.typeOfTransportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeOfTransportLabel.Location = new System.Drawing.Point(330, 74);
            this.typeOfTransportLabel.Name = "typeOfTransportLabel";
            this.typeOfTransportLabel.Size = new System.Drawing.Size(112, 16);
            this.typeOfTransportLabel.TabIndex = 1;
            this.typeOfTransportLabel.Text = "Вид транспорту";
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directionLabel.Location = new System.Drawing.Point(44, 74);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(72, 16);
            this.directionLabel.TabIndex = 3;
            this.directionLabel.Text = "Напрямок";
            // 
            // directionButton
            // 
            this.directionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directionButton.Location = new System.Drawing.Point(29, 103);
            this.directionButton.Name = "directionButton";
            this.directionButton.Size = new System.Drawing.Size(104, 39);
            this.directionButton.TabIndex = 4;
            this.directionButton.Text = "Прямий";
            this.directionButton.UseVisualStyleBackColor = true;
            this.directionButton.Click += new System.EventHandler(this.directionButtonClick);
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
            // marshrutkaButton
            // 
            this.marshrutkaButton.Location = new System.Drawing.Point(216, 103);
            this.marshrutkaButton.Name = "marshrutkaButton";
            this.marshrutkaButton.Size = new System.Drawing.Size(86, 41);
            this.marshrutkaButton.TabIndex = 6;
            this.marshrutkaButton.Text = "Маршрутне таксі";
            this.marshrutkaButton.UseVisualStyleBackColor = true;
            // 
            // trolleybusButton
            // 
            this.trolleybusButton.Location = new System.Drawing.Point(308, 103);
            this.trolleybusButton.Name = "trolleybusButton";
            this.trolleybusButton.Size = new System.Drawing.Size(86, 41);
            this.trolleybusButton.TabIndex = 7;
            this.trolleybusButton.Text = "Троллейбус";
            this.trolleybusButton.UseVisualStyleBackColor = true;
            // 
            // tramvaiButton
            // 
            this.tramvaiButton.Location = new System.Drawing.Point(400, 103);
            this.tramvaiButton.Name = "tramvaiButton";
            this.tramvaiButton.Size = new System.Drawing.Size(86, 39);
            this.tramvaiButton.TabIndex = 8;
            this.tramvaiButton.Text = "Трамвай";
            this.tramvaiButton.UseVisualStyleBackColor = true;
            // 
            // busButton
            // 
            this.busButton.Location = new System.Drawing.Point(492, 103);
            this.busButton.Name = "busButton";
            this.busButton.Size = new System.Drawing.Size(86, 39);
            this.busButton.TabIndex = 9;
            this.busButton.Text = "Автобус";
            this.busButton.UseVisualStyleBackColor = true;
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
            // PublicTransportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 512);
            this.Controls.Add(this.stationLabel);
            this.Controls.Add(this.listOfStationsLabel);
            this.Controls.Add(this.routeTileTemplate);
            this.Controls.Add(this.routePanel);
            this.Controls.Add(this.busButton);
            this.Controls.Add(this.tramvaiButton);
            this.Controls.Add(this.trolleybusButton);
            this.Controls.Add(this.marshrutkaButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.directionButton);
            this.Controls.Add(this.directionLabel);
            this.Controls.Add(this.typeOfTransportLabel);
            this.Name = "PublicTransportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Public Transport";
            this.Load += new System.EventHandler(this.PublicTransportForm_Load);
            this.routeTileTemplate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureTileTemplate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label typeOfTransportLabel;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.Button directionButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button marshrutkaButton;
        private System.Windows.Forms.Button trolleybusButton;
        private System.Windows.Forms.Button tramvaiButton;
        private System.Windows.Forms.Button busButton;
        private System.Windows.Forms.Panel routePanel;
        private System.Windows.Forms.Panel routeTileTemplate;
        private System.Windows.Forms.Label numberTileTemplate;
        private System.Windows.Forms.PictureBox PictureTileTemplate;
        private System.Windows.Forms.Label directionTileTemplate;
        private System.Windows.Forms.Label timeTileTemplate;
        private System.Windows.Forms.Label frequencyTileTemplate;
        private System.Windows.Forms.Label listOfStationsLabel;
        private System.Windows.Forms.Label stationLabel;
    }
}