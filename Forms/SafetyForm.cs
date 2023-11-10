using kursova.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursova
{
    public partial class SafetyForm : Form
    {
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
                    BackColor = inactiveDangerColors[i]
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
                sectorSelected = true;
                selectedSectorIndex = dangerSectors.IndexOf(currentSector);
            }
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            Location loc = new Location(locationTextBox.Text);

            descriptionTextBox.Text = loc.GoogleMapsLink;
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

        private void EventPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.LightGray);

            int width = eventPanelTemplate.Width;
            int height = eventPanelTemplate.Height;
            int cornerRadius = 10;

            FillRoundedBackground(g, brush, width, height, cornerRadius * 2);

            // Настройки капсулы
            brush = new SolidBrush(Color.Red);
            int x = 8;
            int y = 7;
            width = 12;
            height = 46;

            FillCapsule(g, brush, x, y, width, height);
        }

        private void FillCapsule(Graphics g, Brush brush, int x, int y, int width, int height)
        {
            GraphicsPath path = new GraphicsPath();

            // x, y, width, height, startAngle, sweepAngle
            // x1, y1, x2, y2

            path.AddArc(x, y, width, width, 180, 180);
            //path.AddLine(x + width + 1, y + (width / 2), x + width + 1, y + height - (width / 2) + 1); // если не использовать сглаживание, чинит правую сторону капсулы
            path.AddArc(x, y + height - width, width, width, 0, 180);

            // Сама отрисовка
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillPath(brush, path);
            g.SmoothingMode = SmoothingMode.Default;
        }

        private void FillRoundedBackground(Graphics g, Brush brush, int width, int height, int cornerCircleDiameter)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, cornerCircleDiameter, cornerCircleDiameter, 180, 90);
            path.AddArc(width - cornerCircleDiameter, 0, cornerCircleDiameter, cornerCircleDiameter, -90, 90);
            path.AddArc(width - cornerCircleDiameter, height - cornerCircleDiameter, cornerCircleDiameter, cornerCircleDiameter, 0, 90);
            path.AddArc(0, height - cornerCircleDiameter, cornerCircleDiameter, cornerCircleDiameter, 90, 90);

            // Сама отрисовка
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillPath(brush, path);
            g.SmoothingMode = SmoothingMode.Default;
        }
    }

    public class safetyPanel : Panel
    {
        public Label typePanelLabel { get; private set; }
        public Label levelSafetyPanelLabel { get; private set; }
        public Label locationPanelLabel { get; private set; }
        public Label mapPanelPictureBox { get; private set; }

    }
}
