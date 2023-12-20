using kursova.Scripts.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursova.Scripts
{
    public class Hospital
    {
        public string Name { get; set; }
        public string Area { get; set; }
        public List<Doctor> Doctors { get; set; }
        public Location Location { get; set; }
        public string PhoneNumber { get; set; }

        public static List<Hospital> HospitalsList { get; set; }

        static Hospital()
        {
            try
            {
                string hospitalsFilePath = Path.Combine("Data", "hospitals.json");
                HospitalsList = new List<Hospital>();

                if (!File.Exists(hospitalsFilePath))
                {
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FileNotFound, $"Не знайдено \"{hospitalsFilePath}\"");
                }

                string json = File.ReadAllText(hospitalsFilePath);
                List<Hospital> listOfHospitals = JsonConvert.DeserializeObject<List<Hospital>>(json);

                if (listOfHospitals != null && listOfHospitals != null)
                {
                    for (int i = 0; i < listOfHospitals.Count; i++)
                    {
                        HospitalsList.Add(new Hospital
                        {
                            Name = listOfHospitals[i].Name,
                            Area = listOfHospitals[i].Area,
                            Doctors = listOfHospitals[i].Doctors,
                            Location = new Location(listOfHospitals[i].Location.Name),
                            PhoneNumber = listOfHospitals[i].PhoneNumber
                        });
                    }
                }

            }
            catch (ExceptionHandler ex)
            {
                ex.HandleError();
                Environment.Exit(1);
            }
        }
    }
}