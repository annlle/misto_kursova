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
        public List<Appointment> Appointments = new List<Appointment>();

        private static List<User> listOfUsers;
        public static User CurrentUser 
        { 
            get
            {
                return CurrentUser;
            }
            set
            {
                foreach (var user in listOfUsers)
                {
                    if (user.Mail == value.Mail) // дописать
                }
                CurrentUser = value;
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

        public void RegisterUser(User newUser)
        {
            if (newUser != null)
            {
                newUser.Mail = Encryptor.Encrypt(newUser.Mail);
                newUser.Password = Encryptor.Encrypt(newUser.Password);

                CurrentUser = newUser;

                listOfUsers.Add(newUser);
            }
        }

        public void WriteUserAppointments(Appointment appointment)
        {
            CurrentUser.Appointments.Add(appointment);

            SaveUsers();
        }

        public bool CheckUserMail(string mail)
        {
            if (listOfUsers == null)
                return false;

            foreach (User user in listOfUsers)
            {
                if (mail == Encryptor.Decrypt(user.Mail))
                {
                    this.Surname = user.Surname;
                    this.Name = user.Name;
                    this.Patronymic = user.Patronymic;
                    this.Sex = user.Sex;
                    this.Age = user.Age;
                    this.Mail = user.Mail;
                    this.Password = user.Password;
                    this.Appointments = user.Appointments;

                    return true;
                }
            }
            return false;
        }
    }
}
