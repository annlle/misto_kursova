using kursova.Scripts.Extensions;
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace kursova.Scripts
{
    public class Location
    {
        public string Name { get; set; }
        public string GoogleMapsLink { get; set; }

        public static List<Location> RandomLocationsList { get; set; }

        static Location()
        {
            try
            {
                string xmlFilePath = "Data/addresses.xml";

                if (!File.Exists(xmlFilePath))
                {
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FileNotFound, $"Не знайдено \"{xmlFilePath}\"");
                }

                XDocument xdoc = XDocument.Load(xmlFilePath);

                RandomLocationsList = (from location in xdoc.Element("Addresses").Elements("Name")
                                       select new Location((string)location)).ToList();
            }
            catch (ExceptionHandler ex)
            {
                ex.HandleError();
                Environment.Exit(1);
            }
        }

        public Location(string locationName)
        {
            List<string> autoCompleteResults = GooglePlacesAutoComplete.GetAutoCompleteResults(locationName);
            Name = autoCompleteResults.Count > 0 ? autoCompleteResults[0] : locationName;
            GoogleMapsLink = GenerateGoogleMapsLink(Name);
        }

        private string GenerateGoogleMapsLink(string locationName)
        {
            return $"https://www.google.com/maps?q={WebUtility.UrlEncode(locationName)}"; // кодування в URL формат, щоб не було помилок через спец символи
        }

        public void OpenLink()
        {
            try
            {
                Process.Start(GoogleMapsLink);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при відкритті посилання: {ex.Message}");
            }
        }

        public void OpenLink(object sender, EventArgs e)
        {
            OpenLink();
        }
    }
}
