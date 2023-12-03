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
        private User User = new User { };

        private CancellationTokenSource timerCancellation;
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
            User.WriteUser(User.CurrentUser, usersEmailTextBox.Text, usersPasswordTextBox.Text, usersSurnameTextBox.Text,
                usersNameTextBox.Text, usersPatronymTextBox.Text, maleRadioButton.Checked ? Sex.Male : Sex.Female, Convert.ToInt32(usersAgeTextBox.Text));

            User.CurrentUser.Mail = Encryptor.Decrypt(User.CurrentUser.Mail);

            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void UpdateSignUpButtonState()
        {
            signUpButton.Enabled = false;
            bool isEmailLabelValid = IsEmailValid() && !IsEmailOccupied();
            bool isPasswordLabelValid = usersPasswordTextBox.Text.Length >= 8;
            bool isSurnameLabelValid = usersSurnameTextBox.Text.Length > 0;
            bool isNameLabelValid = usersNameTextBox.Text.Length > 0;
            bool isPatronymLabelValid = usersPatronymTextBox.Text.Length > 0;
            bool isAgeLabelValid = usersAgeTextBox.Text.Length > 0;
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

            UpdateSignUpButtonState();
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

        private async Task CheckMail(CancellationToken cancellationToken)
        {
            await Task.Delay(1000); // время перед выводом текста о проверке почты

            if (cancellationToken.IsCancellationRequested)
                return;

            if (IsEmailOccupied())
            {
                passwordLabel.Location = new System.Drawing.Point(365, 132);
                usersPasswordTextBox.Location = new System.Drawing.Point(368, 156);
                passwordCheckerLabel.Location = new System.Drawing.Point(366, 178);
                mailCheckerLabel.Text = "Пошта вже зайнята!";
                mailCheckerLabel.ForeColor = Color.Red;
            }
            else if (!IsEmailValid() && usersEmailTextBox.Text.Length > 0)
            {
                passwordLabel.Location = new System.Drawing.Point(365, 147);
                usersPasswordTextBox.Location = new System.Drawing.Point(368, 171);
                passwordCheckerLabel.Location = new System.Drawing.Point(366, 193);
                mailCheckerLabel.Text = "Пошта не підходить!\nПритримуйтесь стандарту: example@email.com";
                mailCheckerLabel.ForeColor = Color.Red;
            }
        }

        private bool IsEmailOccupied()
        {
            return User.CheckUserMail(usersEmailTextBox.Text);
        }

        private bool IsEmailValid()
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(usersEmailTextBox.Text, pattern);
        }

        private async Task CheckPassword(CancellationToken cancellationToken)
        {
            await Task.Delay(1000); // время перед выводом текста о проверке пароля

            if (cancellationToken.IsCancellationRequested)
                return;

            if (usersPasswordTextBox.Text.Length > 0 && usersPasswordTextBox.Text.Length < 8)
            {
                passwordCheckerLabel.Text = "Пароль повинен бути не менше 8 символів!";
                passwordCheckerLabel.ForeColor = Color.Red;
            }
            
        }

        private void usersEmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9.@]+$";
            if (!Regex.IsMatch(e.KeyChar.ToString(), pattern) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void usersPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9.,!@#$%^&*()_+{}\[\]:;<>,.?~\\-]+$";
            if (!Regex.IsMatch(e.KeyChar.ToString(), pattern) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void usersAgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void usersSurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSignUpButtonState();
        }

        private void usersNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSignUpButtonState();
        }

        private void usersPatronymTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSignUpButtonState();
        }

        private void usersAgeTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSignUpButtonState();
        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSignUpButtonState();
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSignUpButtonState();
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
