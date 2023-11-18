using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursova.Scripts
{
    public class Appointment
    {
        public Hospital Hospital { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime DateTime { get; set; }
    }
}
