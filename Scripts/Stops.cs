using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace kursova.Scripts
{
    public class Stops
    {
        public List<string> Name { get; set; }

        public Stops()
        {
            Name = new List<string>();
        }
    }

    public class StopReader
    {
        public List<Stops> ReadStop(string filePath)
        {
            List<Stops> stops = new List<Stops>();

            XDocument doc = XDocument.Load(filePath);

            stops = (from stopElement in doc.Descendants("Route") select new Stops
            {
                Name = stopElement.Elements("Name").Select(nameElement => nameElement.Value).ToList()
            }).ToList();

            return stops;
        }
    }
}
