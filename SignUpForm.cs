using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signInForm = new SignInForm();
            signInForm.ShowDialog();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string surname = usersSurnameTextBox.Text;
            string name = usersNameTextBox.Text;
            string patronymic = usersPatronymTextBox.Text;
            string sex = usersSexComboBox.Text;
            string age = usersAgeTextBox.Text;
            string mail = usersEmailTextBox.Text;
            string password = usersPasswordTextBox.Text;
            StreamWriter writer = new StreamWriter("user.json");
            writer.WriteLine(surname);
            writer.WriteLine(name);
            writer.WriteLine(patronymic);
            writer.WriteLine(sex);
            writer.WriteLine(age);
            writer.WriteLine(mail);
            writer.WriteLine(password);
            writer.Close();
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
