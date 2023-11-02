namespace kursova
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.fileMenuItem = new System.Windows.Forms.MenuItem();
            this.exitMenuItem = new System.Windows.Forms.MenuItem();
            this.helpMenuItem = new System.Windows.Forms.MenuItem();
            this.faqMenuItem = new System.Windows.Forms.MenuItem();
            this.aboutDevelopersMenuItem = new System.Windows.Forms.MenuItem();
            this.safetyButton = new System.Windows.Forms.Button();
            this.travelInfoButton = new System.Windows.Forms.Button();
            this.hospitalButton = new System.Windows.Forms.Button();
            this.publicTransportLabel = new System.Windows.Forms.Label();
            this.safetyLabel = new System.Windows.Forms.Label();
            this.travelInfoLabel = new System.Windows.Forms.Label();
            this.hospitalLabel = new System.Windows.Forms.Label();
            this.publicTransportButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.profileLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenuItem,
            this.helpMenuItem});
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Index = 0;
            this.fileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.exitMenuItem});
            this.fileMenuItem.Text = "File";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Index = 0;
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItemClick);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Index = 1;
            this.helpMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.faqMenuItem,
            this.aboutDevelopersMenuItem});
            this.helpMenuItem.Text = "Help";
            // 
            // faqMenuItem
            // 
            this.faqMenuItem.Index = 0;
            this.faqMenuItem.Text = "FAQ";
            this.faqMenuItem.Click += new System.EventHandler(this.faqMenuItemClick);
            // 
            // aboutDevelopersMenuItem
            // 
            this.aboutDevelopersMenuItem.Index = 1;
            this.aboutDevelopersMenuItem.Text = "About developers";
            this.aboutDevelopersMenuItem.Click += new System.EventHandler(this.aboutDevelopersMenuItemClick);
            // 
            // safetyButton
            // 
            this.safetyButton.Location = new System.Drawing.Point(505, 69);
            this.safetyButton.Name = "safetyButton";
            this.safetyButton.Size = new System.Drawing.Size(110, 60);
            this.safetyButton.TabIndex = 1;
            this.safetyButton.Text = "button2";
            this.safetyButton.UseVisualStyleBackColor = true;
            this.safetyButton.Click += new System.EventHandler(this.safetyButtonClick);
            // 
            // travelInfoButton
            // 
            this.travelInfoButton.Location = new System.Drawing.Point(255, 237);
            this.travelInfoButton.Name = "travelInfoButton";
            this.travelInfoButton.Size = new System.Drawing.Size(110, 60);
            this.travelInfoButton.TabIndex = 2;
            this.travelInfoButton.Text = "button3";
            this.travelInfoButton.UseVisualStyleBackColor = true;
            this.travelInfoButton.Click += new System.EventHandler(this.travelInfoButtonClick);
            // 
            // hospitalButton
            // 
            this.hospitalButton.Location = new System.Drawing.Point(505, 237);
            this.hospitalButton.Name = "hospitalButton";
            this.hospitalButton.Size = new System.Drawing.Size(110, 60);
            this.hospitalButton.TabIndex = 3;
            this.hospitalButton.Text = "button4";
            this.hospitalButton.UseVisualStyleBackColor = true;
            this.hospitalButton.Click += new System.EventHandler(this.hospitalButtonClick);
            // 
            // publicTransportLabel
            // 
            this.publicTransportLabel.AutoSize = true;
            this.publicTransportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publicTransportLabel.Location = new System.Drawing.Point(222, 142);
            this.publicTransportLabel.Name = "publicTransportLabel";
            this.publicTransportLabel.Size = new System.Drawing.Size(185, 16);
            this.publicTransportLabel.TabIndex = 4;
            this.publicTransportLabel.Text = "Громадський транспорт";
            // 
            // safetyLabel
            // 
            this.safetyLabel.AutoSize = true;
            this.safetyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.safetyLabel.Location = new System.Drawing.Point(473, 142);
            this.safetyLabel.Name = "safetyLabel";
            this.safetyLabel.Size = new System.Drawing.Size(177, 16);
            this.safetyLabel.TabIndex = 5;
            this.safetyLabel.Text = "Громадянська безпека";
            // 
            // travelInfoLabel
            // 
            this.travelInfoLabel.AutoSize = true;
            this.travelInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.travelInfoLabel.Location = new System.Drawing.Point(224, 307);
            this.travelInfoLabel.Name = "travelInfoLabel";
            this.travelInfoLabel.Size = new System.Drawing.Size(183, 16);
            this.travelInfoLabel.TabIndex = 6;
            this.travelInfoLabel.Text = "Туристична інформація";
            // 
            // hospitalLabel
            // 
            this.hospitalLabel.AutoSize = true;
            this.hospitalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hospitalLabel.Location = new System.Drawing.Point(525, 307);
            this.hospitalLabel.Name = "hospitalLabel";
            this.hospitalLabel.Size = new System.Drawing.Size(64, 16);
            this.hospitalLabel.TabIndex = 7;
            this.hospitalLabel.Text = "Лікарня";
            // 
            // publicTransportButton
            // 
            this.publicTransportButton.Location = new System.Drawing.Point(255, 70);
            this.publicTransportButton.Name = "publicTransportButton";
            this.publicTransportButton.Size = new System.Drawing.Size(110, 59);
            this.publicTransportButton.TabIndex = 0;
            this.publicTransportButton.Text = "button1";
            this.publicTransportButton.UseVisualStyleBackColor = true;
            this.publicTransportButton.Click += new System.EventHandler(this.publicTransportButtonClick);
            // 
            // profileButton
            // 
            this.profileButton.Location = new System.Drawing.Point(12, 12);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(95, 117);
            this.profileButton.TabIndex = 8;
            this.profileButton.Text = "button5";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButtonClick);
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileLabel.Location = new System.Drawing.Point(21, 137);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(76, 18);
            this.profileLabel.TabIndex = 9;
            this.profileLabel.Text = "Профіль";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 381);
            this.Controls.Add(this.profileLabel);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.hospitalLabel);
            this.Controls.Add(this.travelInfoLabel);
            this.Controls.Add(this.safetyLabel);
            this.Controls.Add(this.publicTransportLabel);
            this.Controls.Add(this.hospitalButton);
            this.Controls.Add(this.travelInfoButton);
            this.Controls.Add(this.safetyButton);
            this.Controls.Add(this.publicTransportButton);
            this.MaximumSize = new System.Drawing.Size(717, 441);
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(717, 441);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Misto App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem fileMenuItem;
        private System.Windows.Forms.MenuItem exitMenuItem;
        private System.Windows.Forms.MenuItem helpMenuItem;
        private System.Windows.Forms.MenuItem faqMenuItem;
        private System.Windows.Forms.MenuItem aboutDevelopersMenuItem;
        private System.Windows.Forms.Button publicTransportButton;
        private System.Windows.Forms.Button safetyButton;
        private System.Windows.Forms.Button travelInfoButton;
        private System.Windows.Forms.Button hospitalButton;
        private System.Windows.Forms.Label publicTransportLabel;
        private System.Windows.Forms.Label safetyLabel;
        private System.Windows.Forms.Label travelInfoLabel;
        private System.Windows.Forms.Label hospitalLabel;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Label profileLabel;
    }
}

