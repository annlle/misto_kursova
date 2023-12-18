namespace kursova
{
    partial class FaqForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaqForm));
            this.mistoAppLabel = new System.Windows.Forms.Label();
            this.welcomeToFaqLabel = new System.Windows.Forms.Label();
            this.sourceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.faqLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mistoAppLabel
            // 
            this.mistoAppLabel.AutoSize = true;
            this.mistoAppLabel.BackColor = System.Drawing.Color.Transparent;
            this.mistoAppLabel.Font = new System.Drawing.Font("Felix Titling", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mistoAppLabel.Location = new System.Drawing.Point(104, 217);
            this.mistoAppLabel.Name = "mistoAppLabel";
            this.mistoAppLabel.Size = new System.Drawing.Size(110, 13);
            this.mistoAppLabel.TabIndex = 0;
            this.mistoAppLabel.Text = "Misto App (c) 2023";
            // 
            // welcomeToFaqLabel
            // 
            this.welcomeToFaqLabel.AutoSize = true;
            this.welcomeToFaqLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeToFaqLabel.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeToFaqLabel.Location = new System.Drawing.Point(69, 20);
            this.welcomeToFaqLabel.Name = "welcomeToFaqLabel";
            this.welcomeToFaqLabel.Size = new System.Drawing.Size(180, 19);
            this.welcomeToFaqLabel.TabIndex = 1;
            this.welcomeToFaqLabel.Text = "Welcome to FAQ !";
            // 
            // sourceLinkLabel
            // 
            this.sourceLinkLabel.AutoSize = true;
            this.sourceLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.sourceLinkLabel.Font = new System.Drawing.Font("Felix Titling", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceLinkLabel.Location = new System.Drawing.Point(115, 199);
            this.sourceLinkLabel.Name = "sourceLinkLabel";
            this.sourceLinkLabel.Size = new System.Drawing.Size(87, 13);
            this.sourceLinkLabel.TabIndex = 2;
            this.sourceLinkLabel.TabStop = true;
            this.sourceLinkLabel.Text = "Source Code";
            this.sourceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sourceLinkLabelClick);
            // 
            // faqLabel
            // 
            this.faqLabel.BackColor = System.Drawing.Color.Transparent;
            this.faqLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.faqLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.faqLabel.Location = new System.Drawing.Point(12, 54);
            this.faqLabel.Name = "faqLabel";
            this.faqLabel.Size = new System.Drawing.Size(297, 123);
            this.faqLabel.TabIndex = 3;
            this.faqLabel.Text = "Додаток, який містить різноманітну інформацію про місто, містить 4 розділи (грома" +
    "дський транспорт, громадська безпека, туристична інформація, лікарня) та головне" +
    " меню, сторінку профілю. ";
            this.faqLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FaqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(321, 239);
            this.Controls.Add(this.faqLabel);
            this.Controls.Add(this.sourceLinkLabel);
            this.Controls.Add(this.welcomeToFaqLabel);
            this.Controls.Add(this.mistoAppLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FaqForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Інфо";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mistoAppLabel;
        private System.Windows.Forms.Label welcomeToFaqLabel;
        private System.Windows.Forms.LinkLabel sourceLinkLabel;
        private System.Windows.Forms.Label faqLabel;
    }
}