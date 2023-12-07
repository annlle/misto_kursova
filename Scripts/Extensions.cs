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

        private static int Partition<T, TKey>(List<T> list, Func<T, TKey> keySelector, int low, int high, bool inverted)
        {
            T pivot = list[(low + high) / 2];

            int i = low - 1;
            int j = high + 1;

            while (true)
            {
                do
                {
                    i++;
                } while ((inverted ? Comparer<TKey>.Default.Compare(keySelector(list[i]), keySelector(pivot)) > 0 : Comparer<TKey>.Default.Compare(keySelector(list[i]), keySelector(pivot)) < 0));

                do
                {
                    j--;
                } while ((inverted ? Comparer<TKey>.Default.Compare(keySelector(list[j]), keySelector(pivot)) < 0 : Comparer<TKey>.Default.Compare(keySelector(list[j]), keySelector(pivot)) > 0));

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

        private static void QuickSort<T, TKey>(List<T> list, Func<T, TKey> keySelector, int low, int high, bool inverted)
        {
            if (low < high)
            {
                int partitionIndex = Partition(list, keySelector, low, high, inverted);

                QuickSort(list, keySelector, low, partitionIndex, inverted);
                QuickSort(list, keySelector, partitionIndex + 1, high, inverted);
            }
        }

        public static void QuickSort<T, TKey>(this List<T> list, Func<T, TKey> keySelector, bool inverted = false)
        {
            QuickSort(list, keySelector, 0, list.Count - 1, inverted);
        }
    }
}
