using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursova.Scripts
{
    enum TypeOfTransport
    {
        minibus,
        trolleybus,
        tram,
        bus
    }

    public class Route 
    {
        public int RouteNumber { get; set; }
        public TypeOfTransport typeOfTransport { get; set; }
        public bool Direction { get; set; }
        public List<string> Stops = new List<string> ();
        public pair(string, string) time { get; set; }                    // початковий та кінцевий час 
        public string interval { get; set; }
    }
}
