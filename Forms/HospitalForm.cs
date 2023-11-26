using kursova.Scripts;
using kursova.Scripts.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursova
{
    public partial class HospitalForm : Form
    {
        Image doctorMalePicture = Image.FromFile(Path.Combine("Data", "doctor-male.png"));
        Image doctorFemalePicture = Image.FromFile(Path.Combine("Data", "doctor-female.png"));
        List<Hospital> hospitals;
        Hospital selectedHospital;
        Doctor selectedDoctor;

        public HospitalForm()
        {
            InitializeComponent();
        }

        private void HospitalForm_Load(object sender, EventArgs e)
        {
            appointmentDatePicker.MinDate = DateTime.Now;
            appointmentDatePicker.MaxDate = DateTime.Now.AddMonths(1);
            appointmentDatePicker.Value = DateTime.Now;

            hospitals = new List<Hospital>
            {
                new Hospital
                {
                    Name = "Лікарня А",
                    Doctors = new List<Doctor>
                    {
                        new Doctor { Name = "Др. Сміт", Sex = Sex.Male, Specialization = "Кардіолог" },
                        new Doctor { Name = "Др. Джонсон", Sex = Sex.Female, Specialization = "Ортопедічний хірург" }
                    },
                    Location = new Location("Місто А"),
                    PhoneNumber = "123-456-7890"
                },
                new Hospital
                {
                    Name = "Лікарня Б",
                    Doctors = new List<Doctor>
                    {
                        new Doctor { Name = "Др. Коваль", Sex = Sex.Female, Specialization = "Педіатр" },
                        new Doctor { Name = "Др. Петренко", Sex = Sex.Male, Specialization = "Хірург" }
                    },
                    Location = new Location("Місто Б"),
                    PhoneNumber = "987-654-3210"
                },
                new Hospital
                {
                    Name = "Лікарня В",
                    Doctors = new List<Doctor>
                    {
                        new Doctor { Name = "Др. Іванова", Sex = Sex.Female, Specialization = "Офтальмолог" },
                        new Doctor { Name = "Др. Сидорова", Sex = Sex.Female, Specialization = "Терапевт" }
                    },
                    Location = new Location("Місто В"),
                    PhoneNumber = "555-123-4567"
                },
                new Hospital
                {
                    Name = "Лікарня Г",
                    Doctors = new List<Doctor>
                    {
                        new Doctor { Name = "Др. Петров", Sex = Sex.Male, Specialization = "Невролог" },
                        new Doctor { Name = "Др. Соловей", Sex = Sex.Male, Specialization = "Хірург" }
                    },
                    Location = new Location("Місто Г"),
                    PhoneNumber = "777-321-6540"
                },
                new Hospital
                {
                    Name = "Лікарня Д",
                    Doctors = new List<Doctor>
                    {
                        new Doctor { Name = "Др. Ткачук", Sex = Sex.Male, Specialization = "Гінеколог" },
                        new Doctor { Name = "Др. Шевченко", Sex = Sex.Female, Specialization = "Пульмонолог" }
                    },
                    Location = new Location("Місто Д"),
                    PhoneNumber = "333-999-8888"
                }
            };

            sortComboBox.SelectedIndex = 0;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void hospitalsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            doctorsListBox.Items.Clear();
            selectedHospital = default;
            selectedDoctor = default;
            doctorNameLabel.Text = "ПІБ Лікаря";
            specializationLabel.Text = "Спеціалізація";
            doctorPictureBox.Image = null;

            if (hospitalsListView.SelectedItems.Count < 1)
                return;

            string selectedHospitalName = hospitalsListView.SelectedItems[0].Text;
            selectedHospital = hospitals.FirstOrDefault(h => h.Name == selectedHospitalName);

            foreach (var doctor in selectedHospital.Doctors)
            {
                doctorsListBox.Items.Add(doctor.Specialization);
            }
        }

        private void doctorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            doctorNameLabel.Text = "ПІБ Лікаря";
            specializationLabel.Text = "Спеціалізація";
            doctorPictureBox.Image = null;

            if (doctorsListBox.SelectedItems.Count < 1)
                return;

            string selectedDoctorSpecialization = doctorsListBox.SelectedItems[0].ToString();
            selectedDoctor = selectedHospital.Doctors.FirstOrDefault(d => d.Specialization == selectedDoctorSpecialization);

            doctorNameLabel.Text = selectedDoctor.Name;
            specializationLabel.Text = selectedDoctor.Specialization;
            doctorPictureBox.Image = selectedDoctor.Sex == Sex.Male ? doctorMalePicture : doctorFemalePicture;
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            DateTime dateTime = appointmentDatePicker.Value;

            Appointment appointment = new Appointment
            {
                Doctor = selectedDoctor,
                Hospital = selectedHospital,
                DateTime = dateTime
            };

            User.CurrentUser.WriteUserAppointments(appointment);           
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hospitalsListView.Items.Clear();

            bool inverted = !(sortComboBox.Text == sortComboBox.Items[0].ToString());

            hospitals.QuickSort(hospital => hospital.Name, inverted);

            foreach (var hospital in hospitals)
            {
                hospitalsListView.Items.Add(hospital.Name);
                hospitalsListView.Items[hospitalsListView.Items.Count - 1].SubItems.Add(hospital.Location.Name);
                hospitalsListView.Items[hospitalsListView.Items.Count - 1].Group = hospitalsListView.Groups[0];
            }

            foreach (var hospital in hospitals)
            {
                hospitalsListView.Items.Add(hospital.Name);
                hospitalsListView.Items[hospitalsListView.Items.Count - 1].SubItems.Add(hospital.Location.Name);
                hospitalsListView.Items[hospitalsListView.Items.Count - 1].Group = hospitalsListView.Groups[1];
            }

            foreach (var hospital in hospitals)
            {
                hospitalsListView.Items.Add(hospital.Name);
                hospitalsListView.Items[hospitalsListView.Items.Count - 1].SubItems.Add(hospital.Location.Name);
                hospitalsListView.Items[hospitalsListView.Items.Count - 1].Group = hospitalsListView.Groups[2];
            }

            foreach (var hospital in hospitals)
            {
                hospitalsListView.Items.Add(hospital.Name);
                hospitalsListView.Items[hospitalsListView.Items.Count - 1].SubItems.Add(hospital.Location.Name);
                hospitalsListView.Items[hospitalsListView.Items.Count - 1].Group = hospitalsListView.Groups[3];
            }

            foreach (var hospital in hospitals)
            {
                hospitalsListView.Items.Add(hospital.Name);
                hospitalsListView.Items[hospitalsListView.Items.Count - 1].SubItems.Add(hospital.Location.Name);
                hospitalsListView.Items[hospitalsListView.Items.Count - 1].Group = hospitalsListView.Groups[4];
            }

            foreach (var hospital in hospitals)
            {
                hospitalsListView.Items.Add(hospital.Name);
                hospitalsListView.Items[hospitalsListView.Items.Count - 1].SubItems.Add(hospital.Location.Name);
                hospitalsListView.Items[hospitalsListView.Items.Count - 1].Group = hospitalsListView.Groups[5];
            }
        }
    }
}
