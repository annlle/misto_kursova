using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursova.Scripts
{
    public class Hospital
    {
        public string Name { get; set; }
        public List<Doctor> Doctors { get; set; }
        public Location Location { get; set; }
        public string PhoneNumber { get; set; }
    }
}
