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
            User userFromFile = new User { Mail = "testmail@gmail.com", Password = "test123" };

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
