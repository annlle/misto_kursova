using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova
{

    
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
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
            public abstract void setuser();
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
            next.doctor = null;
        }
    }    
    public class User : GetSet 
    {
        private string name, surname, patronymic, sex, age, mail;
        private saved head;
        public User()
        {
            head.doctor = null;
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
                while(current.next.doctor != null)
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
        public override void setuser()
        {
            string name="aboba";
            this.name = name;
            //реализовать добавление инфы о юзере из файла с его инфой
        }
        public override void saveuser()
        {
            string name;
            name = this.name;
            //реализовать сохранение инфы о юзере в файл
        }
        public override void getnoted()
        {
            saved current = head;
            while(current.doctor != null)
            {
                //реализовать добавление инфы из current в list с записями к врачу
                current = current.next;
            }
        }
    }
}
