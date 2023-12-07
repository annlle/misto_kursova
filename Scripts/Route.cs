using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace kursova.Scripts
{
    public enum TypeOfTransport
    {
        minibus,
        bus,
        trolleybus,
        tram
    }

    public class Route 
    {
        public int RouteNumber { get; set; }
        public TypeOfTransport TypeOfTransport { get; set; }
        public bool StraightDirection { get; set; }
        public List<string> Stops { get; set; }
        public Tuple<string, string> Time { get; set; } // початковий та цінцевий час
        public string Frequency { get; set; }

        public static List<Route> ReadRoutes()
        {
            string xmlFilePath = "Data/routes.xml";

            XDocument xdoc = XDocument.Load(xmlFilePath);

            var routes = from route in xdoc.Element("Routes").Elements("Route")
                select new Route
                {
                    RouteNumber = (int)route.Element("RouteNumber"),
                    TypeOfTransport = (TypeOfTransport)Enum.Parse(typeof(TypeOfTransport), (string)route.Element("TypeOfTransport")),
                    StraightDirection = (bool)route.Element("StraightDirection"),
                    Stops = route.Element("Stops").Elements("Name").Select(stop => (string)stop).ToList(),
                    Time = new Tuple<string, string>((string)route.Element("Time").Element("StartTime"), (string)route.Element("Time").Element("EndTime")),
                    Frequency = (string)route.Element("Frequency")
                };

            return routes.ToList();
        }
    }
}
