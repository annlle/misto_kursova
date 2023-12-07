using kursova.Scripts;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova
{
    public partial class TravelInfoForm : Form
    {
        Attraction attraction;
        List<Attraction> attractions;

        public TravelInfoForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void TravelInfoForm_Load(object sender, EventArgs e)
        {
            attractions = Attraction.ReadAttraction();

            foreach (var attraction in attractions)
            {
                attractionsComboBox.Items.Add(attraction.Name);
            }

            attractionsComboBox.SelectedIndex = 0;
            attraction = attractions[0];
        }

        private void attractionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            attractionRichTextBox.Text = "";
            attractionPictureBox.Image = null;

            string attractionName = attractionsComboBox.SelectedItem.ToString();
            attraction = attractions.FirstOrDefault(a => a.Name == attractionName);

            if (attraction == null)
                return;

            attractionRichTextBox.Text = attraction.Description;
            attractionPictureBox.Image = attraction.Image;
        }

        private void locationLinkPictureBox_Click(object sender, EventArgs e)
        {
            attraction.Location.OpenLink();
        }

        private void TravelInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
