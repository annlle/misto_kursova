using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kursova.Scripts;
using kursova.Scripts.Extensions;

namespace kursova.Scripts
{
    public class User
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public Sex Sex { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public List<Appointment> Appointments { get; private set; } = new List<Appointment>();

        private static List<User> listOfUsers;
        
        private static User currentUser;
        public static User CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                foreach (var user in listOfUsers)
                {
                    if (user.Mail == value.Mail)
                    {
                        currentUser = user;
                        break;
                    }
                }
            }
        }

        static User() // статичний конструктор
        {
            string filePath = Path.Combine("Data", "user.json");
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                listOfUsers = JsonConvert.DeserializeObject<List<User>>(json);

                if (listOfUsers == null)
                {
                    listOfUsers = new List<User>();
                }
            }
            else
            {
                listOfUsers = new List<User>();
            }
        }

        public static void SaveUsers()
        {
            string filePath = Path.Combine("Data", "user.json");
            string json = JsonConvert.SerializeObject(listOfUsers);
            File.WriteAllText(filePath, json);
        }

        public void RegisterUser()
        {
            Mail = Encryptor.Encrypt(Mail);
            Password = Encryptor.Encrypt(Password);

            if (!listOfUsers.Contains(this))
                listOfUsers.Add(this);

            CurrentUser = this;
            SaveUsers();
        }

        public void AddAppoinment(Appointment appointment)
        {
            CurrentUser.Appointments.Add(appointment);

            SaveUsers();
        }

        public void RemoveExpiredAppoinments()
        {
            for (int i = 0; i < Appointments.Count; i++)
            {
                if (Appointments[i].DateTime < DateTime.Now)
                {
                    Appointments.RemoveAt(i);
                    i--;
                }
            }

            SaveUsers();
        }

        public static bool IsUserRegistered(string mail)
        {
            return listOfUsers.Find(user => Encryptor.Decrypt(user.Mail) == mail) != default(User);
        }

        public static bool TryFindUser(string mail, out User foundUser)
        {
            foreach (var user in listOfUsers)
            {
                if (mail == Encryptor.Decrypt(user.Mail))
                {
                    foundUser = new User
                    {
                        Surname = user.Surname,
                        Name = user.Name,
                        Patronymic = user.Patronymic,
                        Sex = user.Sex,
                        Age = user.Age,
                        Mail = user.Mail,
                        Password = user.Password,
                        Appointments = user.Appointments
                    };

                    return true;
                }
            }
            foundUser = null;
            return false;
        }
    }
}
