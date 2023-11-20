using kursova.Scripts;
using System;
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
            Image img = attractionPictureBox.Image;

            attractions = new List<Attraction> 
            {
                new Attraction
                {
                    Name = "Запоріжжя",
                    Description = "Запоріжжя — місто в Україні, адміністративний центр Запорізької області. \r\nЗа кількістю населення — шосте місто країни.\r\nЄ одним з найбільших адміністративних, індустріальних та культурних центрів півдня України з розвиненим машинобудуванням, чорною та кольоровою металургією, хімічною та будівельною промисловістю, річковим портом і важливим транзитним залізничним вузлом.",
                    Location = new Location("Запоріжжя"),
                    Image = img
                },
                new Attraction
                {
                    Name = "Хортиця",
                    Description = "Якійсь там острів півострів я фіг його знає, тут повинен бути опис :D",
                    Location = new Location("Хортиця"),
                    Image = img
                },
                new Attraction
                {
                    Name = "Радуга",
                    Description = "Прикольне місце, але тут повинен бути повний текст >_<",
                    Location = new Location("Запоріжжя Радуга"),
                    Image = null
                }
            };

            foreach (var attraction in attractions)
            {
                attractionsComboBox.Items.Add(attraction.Name);
            }

            attractionsComboBox.SelectedIndex = 0;
            attraction = attractions[0];
        }

        private void attractionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            attractionTextLabel.Text = "";
            attractionPictureBox.Image = null;

            string attractionName = attractionsComboBox.SelectedItem.ToString();
            attraction = attractions.FirstOrDefault(a => a.Name == attractionName);

            if (attraction == null)
                return;

            attractionTextLabel.Text = attraction.Description;
            attractionPictureBox.Image = attraction.Image;
        }

        private void locationLinkPictureBox_Click(object sender, EventArgs e)
        {
            attraction.Location.OpenLink();
        }
    }
}
