using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursova.Scripts
{
    enum TypeOfEvent 
    {
        fire,
        robbery,
        attack,
        vandalism
    }

    public class Event
    {
        public TypeOfEvent Event { get; set; }
        public Location Location { get; set; }
        public int DangerLevel { get; set; }
    }
}