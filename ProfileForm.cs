using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova
{


    public partial class ProfileForm : Form
    {
        private User user = new User();
        public ProfileForm()
        {
            InitializeComponent();
            string name, surname, patronymic, sex, age, mail, password;
            StreamReader reader = new StreamReader("user.json"); //считываем инфу с примерочного файла, проверка все ли работает
            surname = reader.ReadLine();
            name = reader.ReadLine();
            patronymic = reader.ReadLine();
            sex = reader.ReadLine();
            age = reader.ReadLine();
            mail = reader.ReadLine();
            password = reader.ReadLine();
            reader.Close();
            user.setuser(surname, name, patronymic, sex, age, mail, password);
            StreamWriter wwriter = new StreamWriter("uuser.json"); //выписываем во второй проверочный файл инфу для проверки все ли норм сохранилось в 1 файл, и норм ли работают функции
            wwriter.WriteLine(user.getname());
            wwriter.Close();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
    public abstract class GetSet
    {
            public abstract string getname();
            public abstract string getsurname();
            public abstract string getpatronymic();
            public abstract string getsex();
            public abstract string getage();
            public abstract string getmail();
            public abstract void getnoted();
            public abstract void setuser(string surname, string name, string patronymic, string sex, string age, string mail, string password);
            public abstract void saveuser();
    }
    public class saved
    {
        public string doctor;
        public string time;
        public string hospital;
        public saved next;
        public saved(string doctor, string time, string hospital)
        {
            this.doctor = doctor;
            this.time = time;
            this.hospital = hospital;
            next = null;
        }
    }    
    public class User : GetSet 
    {
        private string surname, name, patronymic, sex, age, mail, password;
        private saved head;
        public User()
        {
            head = null;
        }
        public void Add(string doctor, string time, string hospital)
        {
            saved newsaved = new saved(doctor, time, hospital);
            if(head.doctor == null)
            {
                head = newsaved;
            }
            else
            {
                saved current = head;
                while(current.next != null)
                {
                    current = current.next;
                }
                current.next = newsaved;
            }
        }
        public override string getname()
        {
            return name;
        }
        public override string getsurname()
        {
            return surname;
        }
        public override string getpatronymic()
        {
            return patronymic;
        }
        public override string getsex()
        {
            return sex;
        }
        public override string getage()
        {
            return age;
        }
        public override string getmail()
        {
            return mail;
        }
        public override void setuser(string surname, string name, string patronymic, string sex, string age, string mail, string password)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.sex = sex;
            this.age = age;
            this.mail = mail;
            this.password = password;
        }
        public override void saveuser()
        {
            string surname;
            surname = this.surname;
            //реализовать сохранение инфы о юзере в файл
        }
        public override void getnoted()
        {
            saved current = head;
            while(current != null)
            {
                //реализовать добавление инфы из current в list с записями к врачу
                current = current.next;
            }
        }
    }
}
