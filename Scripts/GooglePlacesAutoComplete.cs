using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;

namespace kursova.Scripts
{
    public static class GooglePlacesAutoComplete
    {
        private static readonly string apiKey = "api_should_be_here";

        public static List<string> GetAutoCompleteResults(string input)
        {
            string autoCompleteUrl = $"https://maps.googleapis.com/maps/api/place/autocomplete/json?language=uk&components=country:UA&input={WebUtility.UrlEncode(input)}&key={apiKey}&inputtype=textquery";

            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                string json = client.DownloadString(autoCompleteUrl);
                JObject response = JObject.Parse(json);

                if (response["status"].ToString() == "OK")
                {
                    JArray predictions = (JArray)response["predictions"];

                    List<string> results = new List<string>();

                    foreach (var prediction in predictions)
                    {
                        results.Add(prediction["description"].ToString());
                    }

                    return results;
                }
            }

            return new List<string>();
        }
    }
}
