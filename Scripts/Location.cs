using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace kursova.Scripts
{
    public class Location
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string GoogleMapsLink { get; set; }

        public Location(string locationName)
        {
            Name = locationName;
            GoogleMapsLink = GenerateGoogleMapsLink(locationName);
        }

        private string GenerateGoogleMapsLink(string locationName)
        {
            return $"https://www.google.com/maps?q={WebUtility.UrlEncode(locationName)}"; // кодирование в URL формат, чтобы не было ошибок из-за возможных спец символов
        }
    }
}
