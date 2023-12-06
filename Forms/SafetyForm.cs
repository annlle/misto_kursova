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
        List<Color> dangerColors = new List<Color>
        {
            Color.FromArgb(255, 0, 255, 0),
            Color.FromArgb(255, 255, 255, 0),
            Color.FromArgb(255, 255, 165, 0),
            Color.FromArgb(255, 255, 0, 0)
        };
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

            // этот список случайных адресов должен браться из файла
            List<Location> randomLocations = new List<Location>
            {
                new Location("Запоріжжя Чумаченка 15"),
                new Location("Запоріжжя Світла 10"),
                new Location("Запоріжжя Парамонова 8"),
                new Location("Запоріжжя Північнокільцева 25"),
                new Location("Запоріжжя Козака Бабури 3"),
                new Location("Запоріжжя Миру 14а"),
                new Location("Запоріжжя Перемоги 33"),
                new Location("Запоріжжя Бульвар Шевченка 7")
            };

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
                        dangerSectors[i].BackColor = dangerColors[i];
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
                        dangerSectors[i].BackColor = dangerColors[i];
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
                EventTile newTile = new EventTile(eventTileTemplate, typeTileTemplate, locationTileTemplate, locationLinkTileTemplate, @event);
                newTile.Location = new Point(0, eventPanel.Controls.Count * 65);
                newTile.Paint += EventTile_Paint;
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

        private void EventTile_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.White);

            int width = eventTileTemplate.Width;
            int height = eventTileTemplate.Height;
            int cornerRadius = 10;

            GraphicsHelper.FillRoundedBackground(g, brush, width, height, cornerRadius * 2);

            // Настройки капсулы
            if (sender is EventTile eventTile)
                brush = GetBrushByDangerLevel(eventTile.Event.DangerLevel);
            else
                brush = new SolidBrush(Color.Blue);
            int x = 8;
            int y = 7;
            width = 12;
            height = 46;

            GraphicsHelper.FillCapsule(g, brush, x, y, width, height);
        }

        private Brush GetBrushByDangerLevel(int dangerLevel)
        {
            switch (dangerLevel)
            {
                case 0:
                    return new SolidBrush(dangerColors[0]);
                case 1:
                    return new SolidBrush(dangerColors[1]);
                case 2:
                    return new SolidBrush(dangerColors[2]);
                case 3:
                    return new SolidBrush(dangerColors[3]);
                default:
                    return new SolidBrush(Color.LightGray);
            }
        }

        private void locationTextBox_Leave(object sender, EventArgs e)
        {
            if (!locationListBox.Bounds.Contains(new Point(Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y)))
                locationListBox.Visible = false;
        }
    }
}
