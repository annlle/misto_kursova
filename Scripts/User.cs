using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursova.Scripts
{
    public class User
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public List<Appointment> Appointments = new List<Appointment> { new Appointment { Test = "Перший запис!" } };
        public static User CurrentUser { get; set; } // мы можем создавать экземпляры пользователей (объекты класса), но при этом у нас всегда есть статический текущий пользователь

        public bool TryGetUser(string mail)
        {
            // это все должно быть в цикле, который перебирает пользователей с файла
            // Сначала читается зашифрованная версия с файла, потом сразу дешифруется и заменяется в полях класса
            User userFromFile = new User { Mail = "wwI8lm6iG9p42JAhc1AQG0qicZsICD9YW1VTfDyXyTg=", Password = "fbIqlWuBmKL2TPLqnyXwJw==" }; // testmail@gmail.com : test123 (!ПРИ КЛЮЧЕ "secretKeyExample"!)
            userFromFile.Mail = Encryptor.Decrypt(userFromFile.Mail);
            userFromFile.Password = Encryptor.Decrypt(userFromFile.Password);

            if (mail == userFromFile.Mail)
            {
                this.Surname = userFromFile.Surname;
                this.Name = userFromFile.Name;
                this.Patronymic = userFromFile.Patronymic;
                this.Sex = userFromFile.Sex;
                this.Age = userFromFile.Age;
                this.Mail = userFromFile.Mail;
                this.Password = userFromFile.Password;
                this.Appointments = userFromFile.Appointments;

                return true;
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
