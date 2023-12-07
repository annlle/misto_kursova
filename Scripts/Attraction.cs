using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace kursova.Scripts
{ 
    public class Attraction
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Location Location { get; set; }
        public Image Image { get; set; }

        public static List<Attraction> ReadAttraction()
        {
            string xmlFilePath = "Data/tourist-info.xml";

            XDocument xdoc = XDocument.Load(xmlFilePath);

            var attractions = from attraction in xdoc.Element("Attractions").Elements("Attraction")
                         select new Attraction
                         {
                             Name = (string)attraction.Element("Name"),
                             Description = (string)attraction.Element("Description"),
                             Location = new Location((string)attraction.Element("Location")),
                             Image = LoadImage((string)attraction.Element("Image"))
                         };

            return attractions.ToList();
        }

        private static Image LoadImage(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath))
                return Image.FromFile(imagePath);
            else
                return null;
        }

    }
}
