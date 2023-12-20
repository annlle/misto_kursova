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
using kursova.Scripts;
using System.Threading;
using kursova.Scripts.Extensions;
using System.Text.RegularExpressions;

namespace kursova
{
    public partial class SignInForm : Form
    {
        private User User = new User();

        private CancellationTokenSource timerCancellation;

        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignIn()
        {
            try
            {
                if (usersPasswordTextBox.Text != Encryptor.Decrypt(User.Password))
                {
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.InvalidPassword);
                    
                }
                User.CurrentUser = User;

                this.Hide();
                if (Program.mainForm == null)
                {
                    Program.mainForm = new MainForm();
                }
                Program.mainForm.Show();
            }
            catch (ExceptionHandler ex)
            {
                ex.HandleError();
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            SignIn();
        }

        private bool TextBoxesValid()
        {
            return IsEmailRegistered() && usersPasswordTextBox.Text.Length > 0;
        }

        private void UpdateSignInButtonState()
        {
            signInButton.Enabled = TextBoxesValid();
        }

        private async void usersEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            mailCheckerLabel.Text = "";

            if (timerCancellation != null && !timerCancellation.Token.IsCancellationRequested)
            {
                timerCancellation.Cancel();
            }

            timerCancellation = new CancellationTokenSource();

            await CheckMail(timerCancellation.Token);
            UpdateSignInButtonState();
        }

        private bool IsEmailRegistered()
        {
            return User.TryFindUser(usersEmailTextBox.Text, out User);
        }

        private async Task CheckMail(CancellationToken cancellationToken)
        {
            await Task.Delay(500); // время перед выводом текста о проверке почты

            if (cancellationToken.IsCancellationRequested)
                return;

            if (IsEmailRegistered())
            {
                mailCheckerLabel.Text = "Пошту знайдено!";
                mailCheckerLabel.ForeColor = Color.DarkGreen;
            }
            else if (!IsEmailRegistered() && usersEmailTextBox.Text.Length != 0)
            {
                mailCheckerLabel.Text = "Пошту не знайдено!";
                mailCheckerLabel.ForeColor = Color.Red;
            }
        }

        private void usersEmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9.@]+$";

            if (!Regex.IsMatch(e.KeyChar.ToString(), pattern) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && TextBoxesValid())
            {
                e.Handled = true;
                SignIn();
            }
        }

        private void usersPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSignInButtonState();
        }

        private void usersPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9.,!@#$%^&*()_+{}\[\]:;<>,.?~\\-]+$";
            if (!Regex.IsMatch(e.KeyChar.ToString(), pattern) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            
            if (e.KeyChar == (char)Keys.Enter && TextBoxesValid())
            {
                e.Handled = true;
                SignIn();
            }
        }

        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            if (Program.signUpForm == null)
            {
                Program.signUpForm = new SignUpForm();
            }
            Program.signUpForm.Show();
        }

        private void SignInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
