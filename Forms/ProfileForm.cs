using kursova.Scripts;
using kursova.Scripts.Extensions;
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
        Image MalePicture = Image.FromFile(Path.Combine("Data", "man.png"));
        Image FemalePicture = Image.FromFile(Path.Combine("Data", "woman.png"));
        Appointment currentAppointment;

        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            usersSurnameLabel.Text = User.CurrentUser.Surname;
            usersNameLabel.Text = User.CurrentUser.Name;
            usersPatronymLabel.Text = User.CurrentUser.Patronymic;
            usersSexLabel.Text = User.CurrentUser.Sex.ToString();
            usersAgeLabel.Text = User.CurrentUser.Age.ToString();
            usersEmailLabel.Text = User.CurrentUser.Mail;
            profilePicture.Image = User.CurrentUser.Sex == Sex.Male ? MalePicture : FemalePicture;

            List<Appointment> appointments = User.CurrentUser.Appointments;

            appointments.QuickSort();

            foreach (var appointment in appointments)
            {
                string date = appointment.DateTime.ToString();
                date = date.Remove(date.Length - 3, 3);
                string item = appointment.Hospital.Name + " - " + date;
                appointmentsListBox.Items.Add(item);
            }

            hospitalLabel.Text = "";
            doctorLabel.Text = "";
            dateLabel.Text = "";
            locationLinkPictureBox.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void appointmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hospitalLabel.Text = "";
            doctorLabel.Text = "";
            dateLabel.Text = "";
            locationLinkPictureBox.Visible = false;

            if (appointmentsListBox.SelectedItems.Count < 1)
                return;

            string[] words = appointmentsListBox.SelectedItem.ToString().Split(' ');
            string date = words[words.Count() - 2] + ' ' + words[words.Count() - 1];

            currentAppointment = User.CurrentUser.Appointments.FirstOrDefault(a => a.DateTime.ToString().Remove(date.Length, 3) == date);

            if (currentAppointment == null)
                return;

            hospitalLabel.Text = currentAppointment.Hospital.Name;
            doctorLabel.Text = currentAppointment.Doctor.Name;
            dateLabel.Text = currentAppointment.DateTime.ToString().Remove(date.Length, 3);
            locationLinkPictureBox.Visible = true;
        }

        private void locationLinkPictureBox_Click(object sender, EventArgs e)
        {
            currentAppointment.Hospital.Location.OpenLink();
        }
    }
}
