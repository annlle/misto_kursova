using kursova.Scripts;
using kursova.Scripts.Extensions;
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
    public partial class PublicTransportForm : Form
    {
        bool isForward = true;
        List<Route> routes;

        public PublicTransportForm()
        {
            InitializeComponent();
        }

        private void PublicTransportForm_Load(object sender, EventArgs e)
        {
            routePanel.VerticalScroll.SmallChange = 20;

            // Тестовый список
            routes = new List<Route>
            {
                new Route
                {
                    RouteNumber = 14,
                    TypeOfTransport = TypeOfTransport.minibus,
                    StraightDirection = true,
                    Stops = new List<string>
                    {
                        "Центральний вокзал",
                        "Площа Шевченка",
                        "Вулиця Гагаріна",
                        "Вулиця Запорізька",
                        "Вулиця Леніна",
                        "Вулиця Інженерна",
                        "Вулиця Металургів",
                        "Кінцева зупинка"
                    },
                    Time = new Tuple<string, string>("06:00", "22:30"),
                    Frequency = "Кожні 15-20 хв."
                },
                new Route
                {
                    RouteNumber = 5,
                    TypeOfTransport = TypeOfTransport.trolleybus,
                    StraightDirection = false,
                    Stops = new List<string>
                    {
                        "Площа Шевченка",
                        "Вулиця Гагаріна",
                        "Вулиця Запорізька",
                        "Вулиця Леніна",
                        "Вулиця Інженерна",
                        "Вулиця Металургів",
                        "Кінцева зупинка"
                    },
                    Time = new Tuple<string, string>("05:30", "21:45"),
                    Frequency = "Кожні 20-25 хв."
                },
                new Route
                {
                    RouteNumber = 1,
                    TypeOfTransport = TypeOfTransport.tram,
                    StraightDirection = true,
                    Stops = new List<string>
                    {
                        "Проспект Січових Слов'ян",
                        "Проспект Металургів",
                        "Вулиця Заводська",
                        "Вулиця Леніна",
                        "Вулиця Інженерна",
                        "Вулиця Гагаріна",
                        "Кінцева зупинка"
                    },
                    Time = new Tuple<string, string>("07:15", "23:00"),
                    Frequency = "Кожні 25-30 хв."
                },
                new Route
                {
                    RouteNumber = 23,
                    TypeOfTransport = TypeOfTransport.bus,
                    StraightDirection = false,
                    Stops = new List<string>
                    {
                        "Площа Шевченка",
                        "Вулиця Гагаріна",
                        "Вулиця Запорізька",
                        "Вулиця Леніна",
                        "Вулиця Інженерна",
                        "Вулиця Металургів",
                        "Кінцева зупинка"
                    },
                    Time = new Tuple<string, string>("06:45", "22:15"),
                    Frequency = "Кожні 18-20 хв."
                },
                new Route
                {
                    RouteNumber = 9,
                    TypeOfTransport = TypeOfTransport.minibus,
                    StraightDirection = true,
                    Stops = new List<string>
                    {
                        "Центральний вокзал",
                        "Площа Шевченка",
                        "Вулиця Гагаріна",
                        "Вулиця Леніна",
                        "Вулиця Інженерна",
                        "Кінцева зупинка"
                    },
                    Time = new Tuple<string, string>("07:30", "21:00"),
                    Frequency = "Кожні 15-18 хв."
                },
            };

            RenderRoutePanel();
        }

        private void RenderRoutePanel()
        {
            routePanel.Controls.Clear();

            foreach (var route in routes)
            {
                if (
                    dirNotStraightRadioButton.Checked && route.StraightDirection ||
                    dirStraightRadioButton.Checked && !route.StraightDirection ||
                    numberSearchTextBox.Text.Length > 0 && !route.RouteNumber.ToString().Contains(numberSearchTextBox.Text) ||
                    minibusRadioButton.Checked && route.TypeOfTransport != TypeOfTransport.minibus ||
                    busRadioButton.Checked && route.TypeOfTransport != TypeOfTransport.bus ||
                    trolleybusRadioButton.Checked && route.TypeOfTransport != TypeOfTransport.trolleybus ||
                    tramRadioButton.Checked && route.TypeOfTransport != TypeOfTransport.tram
                    )
                {
                    continue;
                }

                RouteTile newTile = new RouteTile(routeTileTemplate, numberTileTemplate, directionTileTemplate, frequencyTileTemplate, timeTileTemplate, PictureTileTemplate, route);
                newTile.Location = new Point(0, routePanel.Controls.Count * 65);
                newTile.Paint += RouteTile_Paint;
                newTile.Click += routeTile_Click;
                foreach (Control control in newTile.Controls)
                {
                    control.Click += routeTile_Click;
                }
                newTile.Visible = true;
                routePanel.Controls.Add(newTile);
            }
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            RenderRoutePanel();
        }

        private void Control_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void routeTile_Click(object sender, EventArgs e)
        {
            listOfStationsLabel.Text = "";

            RouteTile routeTile = sender as RouteTile;

            if (routeTile == null)
            {
                Label clickedLabel = sender as Label;
                PictureBox clickedPictureBox = sender as PictureBox;
                if (clickedLabel != null)
                {
                    routeTile = clickedLabel.Parent as RouteTile;
                }
                else if (clickedPictureBox != null)
                {
                    routeTile = clickedPictureBox.Parent as RouteTile;
                }
                else
                    return;
            }

            foreach (var stop in routeTile.Route.Stops)
            {
                listOfStationsLabel.Text += stop + '\n';
            }
        }

        private void backButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void RouteTile_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.LightGray);

            int width = routeTileTemplate.Width;
            int height = routeTileTemplate.Height;
            int cornerRadius = 10;

            GraphicsHelper.FillRoundedBackground(g, brush, width, height, cornerRadius * 2);
        }
    }
}
