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
using System.Xml.Linq;

namespace kursova
{
    public partial class SignInForm : Form
    {
        private string mail, password;
        private bool isMailCorrect = false;
        private bool isPasswordCorrect = false;
        public SignInForm()
        {
            InitializeComponent();
            string surname, name, patronymic, sex, age;
            StreamReader reader = new StreamReader("user.json");
            surname = reader.ReadLine();
            name = reader.ReadLine();
            patronymic = reader.ReadLine();
            sex = reader.ReadLine();
            age = reader.ReadLine();
            mail = reader.ReadLine();
            password = reader.ReadLine();
            reader.Close();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if(isPasswordCorrect && isMailCorrect)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
        }

        private void usersEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (usersEmailTextBox.Text == mail)
                isMailCorrect = true;
        }

        private void usersPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (usersPasswordTextBox.Text == password)
                isPasswordCorrect = true;
        }

        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }
    }
}
