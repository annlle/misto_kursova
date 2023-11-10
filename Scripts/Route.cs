using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursova.Scripts
{
    public enum TypeOfTransport
    {
        minibus,
        trolleybus,
        tram,
        bus
    }

    public class Route 
    {
        public int RouteNumber { get; set; }
        public TypeOfTransport TypeOfTransport { get; set; }
        public bool Direction { get; set; }
        public List<string> Stops { get; set; }
        public Tuple<string, string> Time { get; set; } // ���������� �� �������� ���
        public string Interval { get; set; }
    }
}
