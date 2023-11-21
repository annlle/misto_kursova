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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublicTransportForm));
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
            this.dirNotStraightRadioButton = new System.Windows.Forms.RadioButton();
            this.dirStraightRadioButton = new System.Windows.Forms.RadioButton();
            this.dirDsntMatterRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numberSearchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tramRadioButton = new System.Windows.Forms.RadioButton();
            this.trolleybusRadioButton = new System.Windows.Forms.RadioButton();
            this.busRadioButton = new System.Windows.Forms.RadioButton();
            this.minibusRadioButton = new System.Windows.Forms.RadioButton();
            this.anyTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.sortLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.routeTileTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureTileTemplate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(174)))), ((int)(((byte)(81)))));
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(62, 61);
            this.backButton.TabIndex = 5;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // routePanel
            // 
            this.routePanel.AutoScroll = true;
            this.routePanel.BackColor = System.Drawing.Color.Transparent;
            this.routePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.routePanel.Location = new System.Drawing.Point(34, 229);
            this.routePanel.Name = "routePanel";
            this.routePanel.Size = new System.Drawing.Size(332, 295);
            this.routePanel.TabIndex = 10;
            // 
            // routeTileTemplate
            // 
            this.routeTileTemplate.BackColor = System.Drawing.Color.Transparent;
            this.routeTileTemplate.Controls.Add(this.timeTileTemplate);
            this.routeTileTemplate.Controls.Add(this.frequencyTileTemplate);
            this.routeTileTemplate.Controls.Add(this.directionTileTemplate);
            this.routeTileTemplate.Controls.Add(this.numberTileTemplate);
            this.routeTileTemplate.Controls.Add(this.PictureTileTemplate);
            this.routeTileTemplate.Location = new System.Drawing.Point(127, 13);
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
            this.frequencyTileTemplate.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.directionTileTemplate.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.listOfStationsLabel.BackColor = System.Drawing.Color.White;
            this.listOfStationsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listOfStationsLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfStationsLabel.Location = new System.Drawing.Point(389, 229);
            this.listOfStationsLabel.Name = "listOfStationsLabel";
            this.listOfStationsLabel.Size = new System.Drawing.Size(225, 295);
            this.listOfStationsLabel.TabIndex = 12;
            this.listOfStationsLabel.Text = "Оберіть маршрут";
            // 
            // stationLabel
            // 
            this.stationLabel.BackColor = System.Drawing.Color.Transparent;
            this.stationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stationLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stationLabel.Location = new System.Drawing.Point(456, 194);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(93, 22);
            this.stationLabel.TabIndex = 13;
            this.stationLabel.Text = "Зупинки";
            this.stationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dirNotStraightRadioButton);
            this.groupBox1.Controls.Add(this.dirStraightRadioButton);
            this.groupBox1.Controls.Add(this.dirDsntMatterRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(29, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Напрямок";
            // 
            // dirNotStraightRadioButton
            // 
            this.dirNotStraightRadioButton.AutoSize = true;
            this.dirNotStraightRadioButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dirNotStraightRadioButton.Location = new System.Drawing.Point(5, 64);
            this.dirNotStraightRadioButton.Name = "dirNotStraightRadioButton";
            this.dirNotStraightRadioButton.Size = new System.Drawing.Size(99, 25);
            this.dirNotStraightRadioButton.TabIndex = 18;
            this.dirNotStraightRadioButton.Text = "Зворотній";
            this.dirNotStraightRadioButton.UseVisualStyleBackColor = true;
            this.dirNotStraightRadioButton.Click += new System.EventHandler(this.FilterChanged);
            // 
            // dirStraightRadioButton
            // 
            this.dirStraightRadioButton.AutoSize = true;
            this.dirStraightRadioButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dirStraightRadioButton.Location = new System.Drawing.Point(5, 42);
            this.dirStraightRadioButton.Name = "dirStraightRadioButton";
            this.dirStraightRadioButton.Size = new System.Drawing.Size(85, 25);
            this.dirStraightRadioButton.TabIndex = 17;
            this.dirStraightRadioButton.Text = "Прямий";
            this.dirStraightRadioButton.UseVisualStyleBackColor = true;
            this.dirStraightRadioButton.Click += new System.EventHandler(this.FilterChanged);
            // 
            // dirDsntMatterRadioButton
            // 
            this.dirDsntMatterRadioButton.AutoSize = true;
            this.dirDsntMatterRadioButton.Checked = true;
            this.dirDsntMatterRadioButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dirDsntMatterRadioButton.Location = new System.Drawing.Point(5, 20);
            this.dirDsntMatterRadioButton.Name = "dirDsntMatterRadioButton";
            this.dirDsntMatterRadioButton.Size = new System.Drawing.Size(111, 25);
            this.dirDsntMatterRadioButton.TabIndex = 16;
            this.dirDsntMatterRadioButton.TabStop = true;
            this.dirDsntMatterRadioButton.Text = "Не важливо";
            this.dirDsntMatterRadioButton.UseVisualStyleBackColor = true;
            this.dirDsntMatterRadioButton.Click += new System.EventHandler(this.FilterChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.numberSearchTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(164, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 45);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пошук";
            // 
            // numberSearchTextBox
            // 
            this.numberSearchTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberSearchTextBox.Location = new System.Drawing.Point(5, 20);
            this.numberSearchTextBox.Name = "numberSearchTextBox";
            this.numberSearchTextBox.Size = new System.Drawing.Size(165, 26);
            this.numberSearchTextBox.TabIndex = 0;
            this.numberSearchTextBox.TextChanged += new System.EventHandler(this.FilterChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.tramRadioButton);
            this.groupBox3.Controls.Add(this.trolleybusRadioButton);
            this.groupBox3.Controls.Add(this.busRadioButton);
            this.groupBox3.Controls.Add(this.minibusRadioButton);
            this.groupBox3.Controls.Add(this.anyTypeRadioButton);
            this.groupBox3.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(165, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 45);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вид транспорту";
            // 
            // tramRadioButton
            // 
            this.tramRadioButton.AutoSize = true;
            this.tramRadioButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tramRadioButton.Location = new System.Drawing.Point(392, 19);
            this.tramRadioButton.Name = "tramRadioButton";
            this.tramRadioButton.Size = new System.Drawing.Size(93, 25);
            this.tramRadioButton.TabIndex = 4;
            this.tramRadioButton.Text = "Трамвай";
            this.tramRadioButton.UseVisualStyleBackColor = true;
            this.tramRadioButton.Click += new System.EventHandler(this.FilterChanged);
            // 
            // trolleybusRadioButton
            // 
            this.trolleybusRadioButton.AutoSize = true;
            this.trolleybusRadioButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trolleybusRadioButton.Location = new System.Drawing.Point(291, 19);
            this.trolleybusRadioButton.Name = "trolleybusRadioButton";
            this.trolleybusRadioButton.Size = new System.Drawing.Size(100, 25);
            this.trolleybusRadioButton.TabIndex = 3;
            this.trolleybusRadioButton.Text = "Тролейбус";
            this.trolleybusRadioButton.UseVisualStyleBackColor = true;
            this.trolleybusRadioButton.Click += new System.EventHandler(this.FilterChanged);
            // 
            // busRadioButton
            // 
            this.busRadioButton.AutoSize = true;
            this.busRadioButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.busRadioButton.Location = new System.Drawing.Point(211, 19);
            this.busRadioButton.Name = "busRadioButton";
            this.busRadioButton.Size = new System.Drawing.Size(84, 25);
            this.busRadioButton.TabIndex = 2;
            this.busRadioButton.Text = "Автобус";
            this.busRadioButton.UseVisualStyleBackColor = true;
            this.busRadioButton.Click += new System.EventHandler(this.FilterChanged);
            // 
            // minibusRadioButton
            // 
            this.minibusRadioButton.AutoSize = true;
            this.minibusRadioButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minibusRadioButton.Location = new System.Drawing.Point(103, 19);
            this.minibusRadioButton.Name = "minibusRadioButton";
            this.minibusRadioButton.Size = new System.Drawing.Size(111, 25);
            this.minibusRadioButton.TabIndex = 1;
            this.minibusRadioButton.Text = "Маршрутка";
            this.minibusRadioButton.UseVisualStyleBackColor = true;
            this.minibusRadioButton.Click += new System.EventHandler(this.FilterChanged);
            // 
            // anyTypeRadioButton
            // 
            this.anyTypeRadioButton.AutoSize = true;
            this.anyTypeRadioButton.Checked = true;
            this.anyTypeRadioButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.anyTypeRadioButton.Location = new System.Drawing.Point(7, 19);
            this.anyTypeRadioButton.Name = "anyTypeRadioButton";
            this.anyTypeRadioButton.Size = new System.Drawing.Size(99, 25);
            this.anyTypeRadioButton.TabIndex = 0;
            this.anyTypeRadioButton.TabStop = true;
            this.anyTypeRadioButton.Text = "Будь-який";
            this.anyTypeRadioButton.UseVisualStyleBackColor = true;
            this.anyTypeRadioButton.Click += new System.EventHandler(this.FilterChanged);
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.BackColor = System.Drawing.Color.Transparent;
            this.sortLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortLabel.ForeColor = System.Drawing.Color.Black;
            this.sortLabel.Location = new System.Drawing.Point(30, 205);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(105, 21);
            this.sortLabel.TabIndex = 17;
            this.sortLabel.Text = "Сортувати за";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 28);
            this.comboBox1.TabIndex = 18;
            // 
            // PublicTransportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 561);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sortLabel);
            this.Controls.Add(this.stationLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listOfStationsLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.routeTileTemplate);
            this.Controls.Add(this.routePanel);
            this.Controls.Add(this.backButton);
            this.DoubleBuffered = true;
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
            this.PerformLayout();

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
        private System.Windows.Forms.RadioButton dirNotStraightRadioButton;
        private System.Windows.Forms.RadioButton dirStraightRadioButton;
        private System.Windows.Forms.RadioButton dirDsntMatterRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox numberSearchTextBox;
        private System.Windows.Forms.RadioButton minibusRadioButton;
        private System.Windows.Forms.RadioButton anyTypeRadioButton;
        private System.Windows.Forms.RadioButton tramRadioButton;
        private System.Windows.Forms.RadioButton trolleybusRadioButton;
        private System.Windows.Forms.RadioButton busRadioButton;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}