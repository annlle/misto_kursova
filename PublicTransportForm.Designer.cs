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
            this.panel1 = new System.Windows.Forms.Panel();
            this.transportInfoPanel = new System.Windows.Forms.Panel();
            this.timePanelLabel = new System.Windows.Forms.Label();
            this.frequencyPanelLabel = new System.Windows.Forms.Label();
            this.directionPanelLabel = new System.Windows.Forms.Label();
            this.numberPanelLabel = new System.Windows.Forms.Label();
            this.transportPanelPicture = new System.Windows.Forms.PictureBox();
            this.listOfStationsLabel = new System.Windows.Forms.Label();
            this.stationLabel = new System.Windows.Forms.Label();
            this.transportInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportPanelPicture)).BeginInit();
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(29, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 278);
            this.panel1.TabIndex = 10;
            // 
            // transportInfoPanel
            // 
            this.transportInfoPanel.Controls.Add(this.timePanelLabel);
            this.transportInfoPanel.Controls.Add(this.frequencyPanelLabel);
            this.transportInfoPanel.Controls.Add(this.directionPanelLabel);
            this.transportInfoPanel.Controls.Add(this.numberPanelLabel);
            this.transportInfoPanel.Controls.Add(this.transportPanelPicture);
            this.transportInfoPanel.Location = new System.Drawing.Point(148, 12);
            this.transportInfoPanel.Name = "transportInfoPanel";
            this.transportInfoPanel.Size = new System.Drawing.Size(360, 59);
            this.transportInfoPanel.TabIndex = 11;
            this.transportInfoPanel.Visible = false;
            // 
            // timePanelLabel
            // 
            this.timePanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timePanelLabel.Location = new System.Drawing.Point(236, 1);
            this.timePanelLabel.Name = "timePanelLabel";
            this.timePanelLabel.Size = new System.Drawing.Size(121, 55);
            this.timePanelLabel.TabIndex = 4;
            this.timePanelLabel.Text = "10:00 - 20:00";
            this.timePanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frequencyPanelLabel
            // 
            this.frequencyPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frequencyPanelLabel.Location = new System.Drawing.Point(133, 29);
            this.frequencyPanelLabel.Name = "frequencyPanelLabel";
            this.frequencyPanelLabel.Size = new System.Drawing.Size(90, 22);
            this.frequencyPanelLabel.TabIndex = 3;
            this.frequencyPanelLabel.Text = "Кожні 30 хв.";
            this.frequencyPanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // directionPanelLabel
            // 
            this.directionPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directionPanelLabel.Location = new System.Drawing.Point(133, 3);
            this.directionPanelLabel.Name = "directionPanelLabel";
            this.directionPanelLabel.Size = new System.Drawing.Size(90, 22);
            this.directionPanelLabel.TabIndex = 2;
            this.directionPanelLabel.Text = "Прямий";
            this.directionPanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberPanelLabel
            // 
            this.numberPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberPanelLabel.Location = new System.Drawing.Point(68, 3);
            this.numberPanelLabel.Name = "numberPanelLabel";
            this.numberPanelLabel.Size = new System.Drawing.Size(59, 53);
            this.numberPanelLabel.TabIndex = 1;
            this.numberPanelLabel.Text = "39";
            this.numberPanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transportPanelPicture
            // 
            this.transportPanelPicture.Location = new System.Drawing.Point(3, 3);
            this.transportPanelPicture.Name = "transportPanelPicture";
            this.transportPanelPicture.Size = new System.Drawing.Size(59, 53);
            this.transportPanelPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.transportPanelPicture.TabIndex = 0;
            this.transportPanelPicture.TabStop = false;
            // 
            // listOfStationsLabel
            // 
            this.listOfStationsLabel.Location = new System.Drawing.Point(388, 209);
            this.listOfStationsLabel.Name = "listOfStationsLabel";
            this.listOfStationsLabel.Size = new System.Drawing.Size(225, 253);
            this.listOfStationsLabel.TabIndex = 12;
            this.listOfStationsLabel.Text = "label7";
            this.listOfStationsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.Controls.Add(this.transportInfoPanel);
            this.Controls.Add(this.panel1);
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
            this.transportInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transportPanelPicture)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel transportInfoPanel;
        private System.Windows.Forms.Label numberPanelLabel;
        private System.Windows.Forms.PictureBox transportPanelPicture;
        private System.Windows.Forms.Label directionPanelLabel;
        private System.Windows.Forms.Label timePanelLabel;
        private System.Windows.Forms.Label frequencyPanelLabel;
        private System.Windows.Forms.Label listOfStationsLabel;
        private System.Windows.Forms.Label stationLabel;
    }
}