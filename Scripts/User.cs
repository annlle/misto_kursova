using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kursova.Scripts;

namespace kursova.Scripts
{
    public class UsersList
    {
        public List<User> Users { get; set; }
    }

    public class User
    {
        private UsersList listOfUsers;
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public List<Appointment> Appointments = new List<Appointment> { new Appointment { Test = "Перший запис!" } };
        public static User CurrentUser { get; set; } // мы можем создавать экземпляры пользователей (объекты класса), но при этом у нас всегда есть статический текущий

        public UsersList ReadUser()
        {
            string filePath = Path.Combine("Data", "user_test.json");
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath); 
                listOfUsers = JsonConvert.DeserializeObject<UsersList>(json);

                if (listOfUsers != null && listOfUsers.Users != null)
                {
                    for (int i = 0; i < listOfUsers.Users.Count; i++)
                    {
                        Surname = listOfUsers.Users[i].Surname;
                        Name = listOfUsers.Users[i].Name;
                        Patronymic = listOfUsers.Users[i].Patronymic;
                        Sex = listOfUsers.Users[i].Sex;
                        Age = listOfUsers.Users[i].Age;
                        Mail = (listOfUsers.Users[i].Mail);
                        Password = listOfUsers.Users[i].Password;
                        Appointments = listOfUsers.Users[i].Appointments;
                    }

                    return listOfUsers;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public void WriteUser(User newUser, string mail, string password, string surname, string name, string patronymic, string sex, int age)
        {
            string filePath = Path.Combine("Data", "user_test.json");

            listOfUsers = ReadUser();

            newUser = new User
            {
                Mail = mail,
                Password = password,
                Surname = surname,
                Name = name,
                Patronymic = patronymic,
                Sex = sex,
                Age = Convert.ToInt32(age)
            };

            if (listOfUsers == null)
            {
                listOfUsers = new UsersList();
                listOfUsers.Users = new List<User>();
            }
            if (newUser != null)
            {
                User.CurrentUser = newUser;

                User.CurrentUser.Mail = Encryptor.Encrypt(User.CurrentUser.Mail);
                User.CurrentUser.Password = Encryptor.Encrypt(User.CurrentUser.Password);

                listOfUsers.Users.Add(newUser);

                string json = JsonConvert.SerializeObject(listOfUsers);
                File.WriteAllText(filePath, json);
            }

        }

        public bool CheckUserMail(string mail)
        {
            // Сначала читается зашифрованная версия с файла, потом сразу дешифруется и заменяется в полях класса
            // testmail@gmail.com : test123 (!ПРИ КЛЮЧЕ "secretKeyExample"!)

            UsersList listOfUsers = ReadUser();

            if (listOfUsers != null)
            {
                foreach (User user in listOfUsers.Users)
                {
                    user.Mail = Encryptor.Decrypt(user.Mail);
                    user.Password = Encryptor.Decrypt(user.Password);
                }

                foreach (User user in listOfUsers.Users)
                {
                    if (mail == user.Mail)
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
                    else
                        return false;
                }
                return false;
            }
            else
                return false;
        }

        public void AddAppointment(Appointment newAppointment) 
        {
            Appointments.Add(newAppointment);
        }
    }
}
