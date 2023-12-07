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

            routes = Route.ReadRoutes();
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
