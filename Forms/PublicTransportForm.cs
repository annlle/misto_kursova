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
        List<Route> routes;

        public PublicTransportForm()
        {
            InitializeComponent();
        }

        private void PublicTransportForm_Load(object sender, EventArgs e)
        {
            routePanel.VerticalScroll.SmallChange = 20;

            // Тестовый список
            StopReader stopReader = new StopReader();
            List<Stops> stops = stopReader.ReadStop("Data/stop.xml");
            routes = new List<Route>
            {
                new Route
                {
                    RouteNumber = 14,
                    TypeOfTransport = TypeOfTransport.minibus,
                    StraightDirection = true,
                    Stops = stops[0].Name,
                    Time = new Tuple<string, string>("06:00", "22:30"),
                    Frequency = "Кожні 15-20 хв."
                },
                new Route
                {
                    RouteNumber = 5,
                    TypeOfTransport = TypeOfTransport.trolleybus,
                    StraightDirection = false,
                    Stops = stops[1].Name,
                    Time = new Tuple<string, string>("05:30", "21:45"),
                    Frequency = "Кожні 20-25 хв."
                },
                new Route
                {
                    RouteNumber = 1,
                    TypeOfTransport = TypeOfTransport.tram,
                    StraightDirection = true,
                    Stops = stops[2].Name,
                    Time = new Tuple<string, string>("07:15", "23:00"),
                    Frequency = "Кожні 25-30 хв."
                },
                new Route
                {
                    RouteNumber = 23,
                    TypeOfTransport = TypeOfTransport.bus,
                    StraightDirection = false,
                    Stops = stops[3].Name,
                    Time = new Tuple<string, string>("06:45", "22:15"),
                    Frequency = "Кожні 18-20 хв."
                },
                new Route
                {
                    RouteNumber = 9,
                    TypeOfTransport = TypeOfTransport.minibus,
                    StraightDirection = true,
                    Stops = stops[4].Name,
                    Time = new Tuple<string, string>("07:30", "21:00"),
                    Frequency = "Кожні 15-18 хв."
                },
            };

            sortComboBox.SelectedIndex = 0;
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

                Tile newTile = new RouteTile(routeTileTemplate, numberTileTemplate, directionTileTemplate, frequencyTileTemplate, timeTileTemplate, PictureTileTemplate, route);
                newTile.Location = new Point(0, routePanel.Controls.Count * 65);
                newTile.Paint += newTile.Tile_Paint;
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

        private void routeTile_Click(object sender, EventArgs e)
        {
            listOfStationsListBox.Items.Clear();

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
                listOfStationsListBox.Items.Add(stop);
            }
        }

        private void backButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortComboBox.Text == sortComboBox.Items[0].ToString())
                routes.QuickSort(route => route.RouteNumber);
            else if (sortComboBox.Text == sortComboBox.Items[1].ToString())
                routes.QuickSort(route => route.RouteNumber, true);
            else
                routes.QuickSort(route => route.TypeOfTransport);

            RenderRoutePanel();
        }
    }
}
