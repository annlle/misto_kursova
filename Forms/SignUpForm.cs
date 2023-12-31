﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Newtonsoft.Json;
using kursova.Scripts;
using kursova.Scripts.Extensions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace kursova
{
    public partial class SignUpForm : Form
    {
        private User User;
        private bool emailRegistered = false;

        private CancellationTokenSource timerCancellation;

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Program.signInForm == null)
            {
                Program.signInForm = new SignInForm();
            }
            Program.signInForm.Show();
        }

        private void SignUp()
        {
            if (signUpButton.Enabled)
            {
                User = new User
                {
                    Surname = usersSurnameTextBox.Text,
                    Name = usersNameTextBox.Text,
                    Patronymic = usersPatronymTextBox.Text,
                    Sex = maleRadioButton.Checked ? Sex.Male : Sex.Female,
                    Age = Convert.ToInt32(usersAgeTextBox.Text),
                    Mail = usersEmailTextBox.Text,
                    Password = usersPasswordTextBox.Text
                };

                User.RegisterUser();

                this.Hide();
                if (Program.mainForm == null)
                {
                    Program.mainForm = new MainForm();
                }
                Program.mainForm.Show();
            }

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUp();
        }

        private void UpdateSignUpButtonState()
        {
            signUpButton.Enabled = false;
            bool isEmailLabelValid = IsEmailValid() && !emailRegistered;
            bool isPasswordLabelValid = usersPasswordTextBox.Text.Length >= 8;
            bool isSurnameLabelValid = usersSurnameTextBox.Text.Length > 0;
            bool isNameLabelValid = usersNameTextBox.Text.Length > 0;
            bool isPatronymLabelValid = usersPatronymTextBox.Text.Length > 0;
            bool isAgeLabelValid = usersAgeTextBox.Text.Length > 0 && (int.TryParse(usersAgeTextBox.Text, out int age) && age >= 18);
            bool radioButtonChecked = maleRadioButton.Checked || femaleRadioButton.Checked;

            signUpButton.Enabled = isEmailLabelValid && isPasswordLabelValid && isSurnameLabelValid && isNameLabelValid && isPatronymLabelValid && isAgeLabelValid && radioButtonChecked;
        }

        private async void usersEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            mailCheckerLabel.Text = "";

            passwordLabel.Location = new System.Drawing.Point(365, 123);
            usersPasswordTextBox.Location = new System.Drawing.Point(368, 147);
            passwordCheckerLabel.Location = new System.Drawing.Point(366, 169);

            if (timerCancellation != null && !timerCancellation.Token.IsCancellationRequested)
            {
                timerCancellation.Cancel();
            }

            timerCancellation = new CancellationTokenSource();

            await CheckMail(timerCancellation.Token);
        }

        private async Task CheckMail(CancellationToken cancellationToken)
        {
            await Task.Delay(500); // время перед выводом текста о проверке почты

            if (cancellationToken.IsCancellationRequested)
                return;

            if (User.IsUserRegistered(usersEmailTextBox.Text))
            {
                passwordLabel.Location = new System.Drawing.Point(365, 132);
                usersPasswordTextBox.Location = new System.Drawing.Point(368, 156);
                passwordCheckerLabel.Location = new System.Drawing.Point(366, 178);
                mailCheckerLabel.Text = "Пошта вже зайнята!";
                mailCheckerLabel.ForeColor = Color.Red;

                emailRegistered = true;
                UpdateSignUpButtonState();
            }
            else if (!IsEmailValid() && usersEmailTextBox.Text.Length > 0)
            {
                passwordLabel.Location = new System.Drawing.Point(365, 147);
                usersPasswordTextBox.Location = new System.Drawing.Point(368, 171);
                passwordCheckerLabel.Location = new System.Drawing.Point(366, 193);
                mailCheckerLabel.Text = "Пошта не підходить!\nПритримуйтесь стандарту: example@email.com";
                mailCheckerLabel.ForeColor = Color.Red;

                emailRegistered = false;
                UpdateSignUpButtonState();
            }
        }

        private bool IsEmailValid()
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(usersEmailTextBox.Text, pattern);
        }

        private void usersEmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9.@]+$";
            if (!Regex.IsMatch(e.KeyChar.ToString(), pattern) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SignUp();
            }
        }

        private async void usersPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordCheckerLabel.Text = "";

            if (timerCancellation != null && !timerCancellation.Token.IsCancellationRequested)
            {
                timerCancellation.Cancel();
            }

            timerCancellation = new CancellationTokenSource();

            await CheckPassword(timerCancellation.Token);

            UpdateSignUpButtonState();
        }

        private async Task CheckPassword(CancellationToken cancellationToken)
        {
            await Task.Delay(500); // время перед выводом текста о проверке пароля

            if (cancellationToken.IsCancellationRequested)
                return;

            if (usersPasswordTextBox.Text.Length > 0 && usersPasswordTextBox.Text.Length < 8)
            {
                passwordCheckerLabel.Text = "Пароль повинен бути не менше 8 символів!";
                passwordCheckerLabel.ForeColor = Color.Red;
            }
        }

        private void usersPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9.,!@#$%^&*()_+{}\[\]:;<>,.?~\\-]+$";
            if (!Regex.IsMatch(e.KeyChar.ToString(), pattern) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SignUp();
            }
        }

        private void usersSurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSignUpButtonState();
        }

        private void usersSurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SignUp();
            }
        }

        private void usersNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSignUpButtonState();
        }

        private void usersNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SignUp();
            }
        }

        private void usersPatronymTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSignUpButtonState();
        }

        private void usersPatronymTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SignUp();
            }
        }

        private async void usersAgeTextBox_TextChanged(object sender, EventArgs e)
        {
            ageCheckerLabel.Text = "";

            if (timerCancellation != null && !timerCancellation.Token.IsCancellationRequested)
            {
                timerCancellation.Cancel();
            }

            timerCancellation = new CancellationTokenSource();

            await CheckAge(timerCancellation.Token);

            UpdateSignUpButtonState();

        }

        private async Task CheckAge(CancellationToken cancellationToken)
        {
            await Task.Delay(500); // время перед выводом текста о проверке возраста

            if (cancellationToken.IsCancellationRequested)
                return;

            if (int.TryParse(usersAgeTextBox.Text, out int age) && age < 18)
            {
                ageCheckerLabel.Text = "Вік не менше 18!";
                ageCheckerLabel.ForeColor = Color.Red;
            }
        }

        private async void usersAgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if (int.TryParse(usersAgeTextBox.Text + e.KeyChar, out int age) && age > 130)
            {
                e.Handled = true;
                ageCheckerLabel.Text = "Вік не більше 130!";
                ageCheckerLabel.ForeColor = Color.Red;
                await Task.Delay(3000);
                ageCheckerLabel.Text = "";
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SignUp();
            }
        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSignUpButtonState();
        }

        private void maleRadioButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SignUp();
            }
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSignUpButtonState();
        }

        private void femaleRadioButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SignUp();
            }
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
