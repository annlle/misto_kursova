using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using Newtonsoft.Json.Linq;
using System.Net;
using dotenv;
using dotenv.net;
using System.Collections;

namespace kursova.Scripts.Extensions
{
    public enum Sex
    {
        Male,
        Female
    }

    public static class GraphicsHelper
    {
        public static void FillCapsule(Graphics g, Brush brush, int x, int y, int width, int height)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(x, y, width, width, 180, 180);
            path.AddArc(x, y + height - width, width, width, 0, 180);

            // Сама отрисовка
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillPath(brush, path);
            g.SmoothingMode = SmoothingMode.Default;
        }

        public static void FillRoundedBackground(Graphics g, Brush brush, int width, int height, int cornerCircleDiameter)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, cornerCircleDiameter, cornerCircleDiameter, 180, 90);
            path.AddArc(width - cornerCircleDiameter, 0, cornerCircleDiameter, cornerCircleDiameter, -90, 90);
            path.AddArc(width - cornerCircleDiameter, height - cornerCircleDiameter, cornerCircleDiameter, cornerCircleDiameter, 0, 90);
            path.AddArc(0, height - cornerCircleDiameter, cornerCircleDiameter, cornerCircleDiameter, 90, 90);

            // Сама отрисовка
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillPath(brush, path);
            g.SmoothingMode = SmoothingMode.Default;
        }
    }

    public static class Encryptor
    {
        private static readonly string key; // хранится локально

        static Encryptor()
        {
            DotEnv.Load();
            key = DotEnv.Read()["ENCRYPTION_KEY"];
        }

        public static string Encrypt(string input)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(input);
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        public static string Decrypt(string input)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(input)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
    }

    public static class GooglePlacesAutoComplete
    {
        private static readonly string apiKey;

        static GooglePlacesAutoComplete()
        {
            DotEnv.Load();
            apiKey = DotEnv.Read()["API_KEY"];
        }

        public static List<string> GetAutoCompleteResults(string input)
        {
            string autoCompleteUrl = $"https://maps.googleapis.com/maps/api/place/autocomplete/json?language=uk&components=country:UA&input={WebUtility.UrlEncode(input)}&key={apiKey}&inputtype=textquery";

            using (WebClient client = new WebClient())
            {
                string json;

                client.Encoding = Encoding.UTF8;
                try
                {
                    json = client.DownloadString(autoCompleteUrl);
                }
                catch (Exception ex)
                {
                    return new List<string>();
                }
                    
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

    public static class Sorter
    {
        private static void Swap<T>(List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        private static int Partition<T>(List<T> list, int low, int high, bool inverted) where T : IComparable<T>
        {
            T pivot = list[(low + high) / 2];

            int i = low - 1;
            int j = high + 1;

            while (true)
            {
                do
                {
                    i++;
                } while ((inverted ? list[i].CompareTo(pivot) > 0 : list[i].CompareTo(pivot) < 0));

                do
                {
                    j--;
                } while ((inverted ? list[j].CompareTo(pivot) < 0 : list[j].CompareTo(pivot) > 0));

                if (i < j)
                {
                    Swap(list, i, j);
                }
                else
                {
                    return j;
                }
            }
        }

        public static void QuickSort<T>(this List<T> list, bool inverted = false) where T : IComparable<T>
        {
            QuickSort(list, 0, list.Count - 1, inverted);
        }

        private static void QuickSort<T>(List<T> list, int low, int high, bool inverted) where T : IComparable<T>
        {
            if (low < high)
            {
                int partitionIndex = Partition(list, low, high, inverted);

                QuickSort(list, low, partitionIndex, inverted);
                QuickSort(list, partitionIndex + 1, high, inverted);
            }
        }
    }
}
