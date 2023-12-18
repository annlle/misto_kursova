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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Program.mainForm == null)
            {
                Program.mainForm = new MainForm();
            }
            Program.mainForm.Show();
        }

        private void HospitalForm_Load(object sender, EventArgs e)
        {
            appointmentDatePicker.MinDate = DateTime.Now;
            appointmentDatePicker.MaxDate = DateTime.Now.AddMonths(1);
            appointmentDatePicker.Value = DateTime.Now;

            hospitals = Hospital.HospitalsList;

            sortComboBox.SelectedIndex = 0;
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
            try
            {
                string hospitalsFilePath = Path.Combine("Data", "hospitals.json");

                if (!File.Exists(hospitalsFilePath))
                {
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FileNotFound, $"Не знайдено \"{hospitalsFilePath}\"\nЗапис не створено.");
                }

                string addressesFilePath = "Data/addresses.xml";

                if (!File.Exists(addressesFilePath))
                {
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FileNotFound, $"Не знайдено \"{addressesFilePath}\"\nЗапис не створено.");
                }

                DateTime dateTime = appointmentDatePicker.Value;

                Appointment appointment = new Appointment
                {
                    Doctor = selectedDoctor,
                    Hospital = selectedHospital,
                    DateTime = dateTime
                };

                if (appointment.Doctor != null && appointment.Hospital != null && appointment.DateTime != null)
                {
                    User.CurrentUser.AddAppoinment(appointment);
                }
            }
            catch (ExceptionHandler ex)
            {
                ex.HandleError();
            }
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hospitalsListView.Items.Clear();

            bool inverted = !(sortComboBox.Text == sortComboBox.Items[0].ToString());

            hospitals.QuickSort(hospital => hospital.Name, inverted);

            foreach (var hospital in hospitals)
            {
                if (hospital.Area == "Вознесенівський")
                {
                    hospitalsListView.Items.Add(hospital.Name);
                    hospitalsListView.Items[hospitalsListView.Items.Count - 1].SubItems.Add(hospital.Location.Name);
                    hospitalsListView.Items[hospitalsListView.Items.Count - 1].Group = hospitalsListView.Groups[0];
                }
            }

            foreach (var hospital in hospitals)
            {
                if (hospital.Area == "Дніпровський")
                {
                    hospitalsListView.Items.Add(hospital.Name);
                    hospitalsListView.Items[hospitalsListView.Items.Count - 1].SubItems.Add(hospital.Location.Name);
                    hospitalsListView.Items[hospitalsListView.Items.Count - 1].Group = hospitalsListView.Groups[1];
                }
            }

            foreach (var hospital in hospitals)
            {
                if (hospital.Area == "Заводський")
                {
                    hospitalsListView.Items.Add(hospital.Name);
                    hospitalsListView.Items[hospitalsListView.Items.Count - 1].SubItems.Add(hospital.Location.Name);
                    hospitalsListView.Items[hospitalsListView.Items.Count - 1].Group = hospitalsListView.Groups[2];
                }
            }

            foreach (var hospital in hospitals)
            {
                if (hospital.Area == "Комунарський")
                {
                    hospitalsListView.Items.Add(hospital.Name);
                    hospitalsListView.Items[hospitalsListView.Items.Count - 1].SubItems.Add(hospital.Location.Name);
                    hospitalsListView.Items[hospitalsListView.Items.Count - 1].Group = hospitalsListView.Groups[3];
                }
            }

            foreach (var hospital in hospitals)
            {
                if (hospital.Area == "Олександровський")
                {
                    hospitalsListView.Items.Add(hospital.Name);
                    hospitalsListView.Items[hospitalsListView.Items.Count - 1].SubItems.Add(hospital.Location.Name);
                    hospitalsListView.Items[hospitalsListView.Items.Count - 1].Group = hospitalsListView.Groups[4];
                }
            }

            foreach (var hospital in hospitals)
            {
                if (hospital.Area == "Хортицький")
                {
                    hospitalsListView.Items.Add(hospital.Name);
                    hospitalsListView.Items[hospitalsListView.Items.Count - 1].SubItems.Add(hospital.Location.Name);
                    hospitalsListView.Items[hospitalsListView.Items.Count - 1].Group = hospitalsListView.Groups[5];
                }
            }
        }

        private void HospitalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
