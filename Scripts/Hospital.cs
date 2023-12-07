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
    public class HospitalList
    {
        public List<Hospital> Hospitals { get; set; }
    }

    public class Hospital
    {
        public string Name { get; set; }
        public string Area { get; set; }
        public List<Doctor> Doctors { get; set; }
        public Location Location { get; set; }
        public string PhoneNumber { get; set; }

        public List<Hospital> ReadHospital()
        {
            string filePath = Path.Combine("Data", "hospitals.json");

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                HospitalList listOfHospitals = JsonConvert.DeserializeObject<HospitalList>(json);

                if (listOfHospitals != null && listOfHospitals.Hospitals != null)
                {
                    for (int i = 0; i < listOfHospitals.Hospitals.Count; i++)
                    {
                        Name = listOfHospitals.Hospitals[i].Name;
                        Area = listOfHospitals.Hospitals[i].Area;

                        foreach (Doctor doctor in listOfHospitals.Hospitals[i].Doctors)
                        {
                            doctor.Name = doctor.Name;
                            doctor.Sex = doctor.Sex;
                            doctor.Specialization = doctor.Specialization;
                        }
                        Location = new Location(listOfHospitals.Hospitals[i].Location.Name);
                        PhoneNumber = listOfHospitals.Hospitals[i].PhoneNumber;
                    }

                    return listOfHospitals.Hospitals;
                }
                else
                    return null;
            }
            else
                return null;
        }
    }
}