using kursova.Scripts;
using kursova.Scripts.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursova
{
    public partial class SafetyForm : Form
    {
        List<Event> events = new List<Event>();
        int totalSectors = 4;
        List<Panel> dangerSectors = new List<Panel>();
        List<Color> inactiveDangerColors = new List<Color>
        {
            Color.FromArgb(255, 200, 255, 200),
            Color.FromArgb(255, 255, 255, 200),
            Color.FromArgb(255, 255, 210, 200),
            Color.FromArgb(255, 255, 170, 170)
        };
        bool sectorSelected = false;
        int selectedSectorIndex;

        public SafetyForm()
        {
            InitializeComponent();
        }

        private void SafetyForm_Load(object sender, EventArgs e)
        {
            InitializeDangerBar();

            eventPanel.VerticalScroll.SmallChange = 20;

            // автоматичекое добавление типов ивентов из словаря
            foreach (var eventType in EventTranslations.UkrainianTranslations)
                typeComboBox.Items.Add(eventType.Value);

            // этот список случайных адресов берется из файла
            List<Location> randomLocations = Event.ReadAddress();

            Random random = new Random();

            GenerateRandomEvents(random.Next(3, 11), randomLocations);

            RenderEventPanel();
        }

        private void GenerateRandomEvents(int quantity, List<Location> randomLocations)
        {
            Random random = new Random();

            for (int i = 0; i < quantity; i++)
            {
                Event newEvent = new Event
                {
                    EventType = (EventType)Enum.ToObject(typeof(EventType), random.Next(Convert.ToInt32(EventType.Other) + 1)),
                    Location = randomLocations[random.Next(randomLocations.Count)],
                    DangerLevel = random.Next(0, 4)
                };

                events.Add(newEvent);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void InitializeDangerBar()
        {
            int sectorWidth = panelDanger.Width / totalSectors;

            for (int i = 0; i < totalSectors; i++)
            {
                Panel sector = new Panel
                {
                    Width = sectorWidth,
                    Height = panelDanger.Height,
                    Location = new Point(i * sectorWidth, 0),
                    BackColor = inactiveDangerColors[i],
                    Cursor = Cursors.Hand
                };

                sector.MouseEnter += Sector_MouseEnter;
                sector.MouseLeave += Sector_MouseLeave;
                sector.MouseClick += Sector_MouseClick;

                dangerSectors.Add(sector);
                panelDanger.Controls.Add(sector);
            }
        }

        private void Sector_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Panel currentSector)
            {
                int currentIndex = dangerSectors.IndexOf(currentSector);

                for (int i = 0; i < totalSectors; i++)
                {
                    if (i <= currentIndex)
                        dangerSectors[i].BackColor = EventTile.dangerColors[i];
                    else
                        dangerSectors[i].BackColor = Color.LightGray;
                }
            }
        }

        private void Sector_MouseLeave(object sender, EventArgs e)
        {
            if (!sectorSelected)
            {
                for (int i = 0; i < totalSectors; i++)
                {
                    dangerSectors[i].BackColor = inactiveDangerColors[i];
                }
            }
            else
            {
                for (int i = 0; i < totalSectors; i++)
                {
                    if (i <= selectedSectorIndex)
                        dangerSectors[i].BackColor = EventTile.dangerColors[i];
                    else
                        dangerSectors[i].BackColor = Color.LightGray;
                }
            }
        }

        private void Sector_MouseClick(object sender, EventArgs e)
        {
            if (sender is Panel currentSector)
            {
                if (sectorSelected && selectedSectorIndex == dangerSectors.IndexOf(currentSector))
                {
                    sectorSelected = false;
                    selectedSectorIndex = -1;

                }
                else
                {
                    sectorSelected = true;
                    selectedSectorIndex = dangerSectors.IndexOf(currentSector);
                }
            }
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            events.Add(new Event
            {
                EventType = (EventType)typeComboBox.SelectedIndex,
                Location = new Location(locationTextBox.Text),
                DangerLevel = selectedSectorIndex
            });

            RenderEventPanel();
        }

        private void RenderEventPanel()
        {
            eventPanel.Controls.Clear();

            foreach (var @event in events)
            {
                Tile newTile = new EventTile(eventTileTemplate, typeTileTemplate, locationTileTemplate, locationLinkTileTemplate, @event);
                newTile.Location = new Point(0, eventPanel.Controls.Count * 65);
                newTile.Paint += newTile.Tile_Paint;
                newTile.Visible = true;
                eventPanel.Controls.Add(newTile);
            }
        }

        private void locationTextBox_TextChanged(object sender, EventArgs e)
        {
            string input = locationTextBox.Text;
            List<string> results = GooglePlacesAutoComplete.GetAutoCompleteResults(input);

            locationListBox.Items.Clear();
            locationListBox.Items.AddRange(results.ToArray());

            locationListBox.Visible = locationListBox.Items.Count > 0;
        }

        private void locationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (locationListBox.SelectedIndex != -1)
            {
                locationTextBox.Text = locationListBox.SelectedItem.ToString();
                locationListBox.Visible = false;
            }
        }

        private void locationTextBox_Leave(object sender, EventArgs e)
        {
            if (!locationListBox.Bounds.Contains(new Point(Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y)))
                locationListBox.Visible = false;
        }
    }
}
