﻿using kursova.Scripts.Extensions;
using System;
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
        public string ImageUrl { get; set; }
        public string GoogleMapsLink { get; set; }

        public Location(string locationName)
        {
            List<string> autoCompleteResults = GooglePlacesAutoComplete.GetAutoCompleteResults(locationName);
            Name = autoCompleteResults.Count > 0 ? autoCompleteResults[0] : locationName;
            GoogleMapsLink = GenerateGoogleMapsLink(locationName);
        }

        private string GenerateGoogleMapsLink(string locationName)
        {
            return $"https://www.google.com/maps?q={WebUtility.UrlEncode(locationName)}"; // кодирование в URL формат, чтобы не было ошибок из-за возможных спец символов
        }

        public void OpenLink(object sender, EventArgs e)
        {
            try
            {
                Process.Start(GoogleMapsLink);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при открытии ссылки: {ex.Message}");
            }
        }
    }
}
