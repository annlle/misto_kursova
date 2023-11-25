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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.safetyButton.BackColor = System.Drawing.Color.White;
            this.safetyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("safetyButton.BackgroundImage")));
            this.safetyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.safetyButton.Location = new System.Drawing.Point(515, 77);
            this.safetyButton.Name = "safetyButton";
            this.safetyButton.Size = new System.Drawing.Size(131, 94);
            this.safetyButton.TabIndex = 1;
            this.safetyButton.UseVisualStyleBackColor = false;
            this.safetyButton.Click += new System.EventHandler(this.safetyButtonClick);
            // 
            // travelInfoButton
            // 
            this.travelInfoButton.BackColor = System.Drawing.Color.White;
            this.travelInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("travelInfoButton.BackgroundImage")));
            this.travelInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.travelInfoButton.Location = new System.Drawing.Point(265, 242);
            this.travelInfoButton.Name = "travelInfoButton";
            this.travelInfoButton.Size = new System.Drawing.Size(131, 94);
            this.travelInfoButton.TabIndex = 2;
            this.travelInfoButton.UseVisualStyleBackColor = false;
            this.travelInfoButton.Click += new System.EventHandler(this.travelInfoButtonClick);
            // 
            // hospitalButton
            // 
            this.hospitalButton.BackColor = System.Drawing.Color.White;
            this.hospitalButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hospitalButton.BackgroundImage")));
            this.hospitalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hospitalButton.Location = new System.Drawing.Point(515, 242);
            this.hospitalButton.Name = "hospitalButton";
            this.hospitalButton.Size = new System.Drawing.Size(131, 94);
            this.hospitalButton.TabIndex = 3;
            this.hospitalButton.UseVisualStyleBackColor = false;
            this.hospitalButton.Click += new System.EventHandler(this.hospitalButtonClick);
            // 
            // publicTransportLabel
            // 
            this.publicTransportLabel.AutoSize = true;
            this.publicTransportLabel.BackColor = System.Drawing.Color.Transparent;
            this.publicTransportLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publicTransportLabel.ForeColor = System.Drawing.Color.White;
            this.publicTransportLabel.Location = new System.Drawing.Point(243, 184);
            this.publicTransportLabel.Name = "publicTransportLabel";
            this.publicTransportLabel.Size = new System.Drawing.Size(184, 21);
            this.publicTransportLabel.TabIndex = 4;
            this.publicTransportLabel.Text = "Громадський транспорт";
            // 
            // safetyLabel
            // 
            this.safetyLabel.AutoSize = true;
            this.safetyLabel.BackColor = System.Drawing.Color.Transparent;
            this.safetyLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.safetyLabel.ForeColor = System.Drawing.Color.White;
            this.safetyLabel.Location = new System.Drawing.Point(494, 184);
            this.safetyLabel.Name = "safetyLabel";
            this.safetyLabel.Size = new System.Drawing.Size(180, 21);
            this.safetyLabel.TabIndex = 5;
            this.safetyLabel.Text = "Громадянська безпека";
            // 
            // travelInfoLabel
            // 
            this.travelInfoLabel.AutoSize = true;
            this.travelInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.travelInfoLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.travelInfoLabel.ForeColor = System.Drawing.Color.White;
            this.travelInfoLabel.Location = new System.Drawing.Point(245, 349);
            this.travelInfoLabel.Name = "travelInfoLabel";
            this.travelInfoLabel.Size = new System.Drawing.Size(181, 21);
            this.travelInfoLabel.TabIndex = 6;
            this.travelInfoLabel.Text = "Туристична інформація";
            // 
            // hospitalLabel
            // 
            this.hospitalLabel.AutoSize = true;
            this.hospitalLabel.BackColor = System.Drawing.Color.Transparent;
            this.hospitalLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hospitalLabel.ForeColor = System.Drawing.Color.White;
            this.hospitalLabel.Location = new System.Drawing.Point(546, 349);
            this.hospitalLabel.Name = "hospitalLabel";
            this.hospitalLabel.Size = new System.Drawing.Size(67, 21);
            this.hospitalLabel.TabIndex = 7;
            this.hospitalLabel.Text = "Лікарня";
            // 
            // publicTransportButton
            // 
            this.publicTransportButton.BackColor = System.Drawing.Color.White;
            this.publicTransportButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("publicTransportButton.BackgroundImage")));
            this.publicTransportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.publicTransportButton.Location = new System.Drawing.Point(265, 78);
            this.publicTransportButton.Name = "publicTransportButton";
            this.publicTransportButton.Size = new System.Drawing.Size(131, 93);
            this.publicTransportButton.TabIndex = 0;
            this.publicTransportButton.UseVisualStyleBackColor = false;
            this.publicTransportButton.Click += new System.EventHandler(this.publicTransportButtonClick);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.White;
            this.profileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profileButton.BackgroundImage")));
            this.profileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.profileButton.Location = new System.Drawing.Point(12, 12);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(165, 161);
            this.profileButton.TabIndex = 8;
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButtonClick);
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.BackColor = System.Drawing.Color.Transparent;
            this.profileLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileLabel.ForeColor = System.Drawing.Color.Transparent;
            this.profileLabel.Location = new System.Drawing.Point(56, 176);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(77, 24);
            this.profileLabel.TabIndex = 9;
            this.profileLabel.Text = "Профіль";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 433);
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
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

