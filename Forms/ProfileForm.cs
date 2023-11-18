using kursova.Scripts;
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

            foreach (var appointment in User.CurrentUser.Appointments)
            {
                string item = appointment.Hospital.Name + " - " + appointment.DateTime.Day + '.' + appointment.DateTime.Month + '.' + appointment.DateTime.Year;
                appointmentsListBox.Items.Add(item);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
