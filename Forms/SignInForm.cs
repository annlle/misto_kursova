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
                if (usersPasswordTextBox.Text == Encryptor.Decrypt(User.Password))
                {
                    User.CurrentUser = User;

                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                }
                else
                {
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.InvalidPassword);
                }
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

        private async void usersEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            mailCheckerLabel.Text = "";

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

            if (usersEmailTextBox.Text.Length < 5) // порог длины почты (если меньше 5 символов, ничего не будет написано)
            {
                mailCheckerLabel.Text = "";
                signInButton.Enabled = false;
                return;
            }
            else if (User.TryFindUser(usersEmailTextBox.Text, out User))
            {
                mailCheckerLabel.Text = "Пошту знайдено!";
                mailCheckerLabel.ForeColor = Color.DarkGreen;
                signInButton.Enabled = true;
            }
            else
            {
                mailCheckerLabel.Text = "Пошту не знайдено!";
                mailCheckerLabel.ForeColor = Color.Red;
                signInButton.Enabled = false;
            }
        }

        private void usersEmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool ctrlPressed = (Control.ModifierKeys & Keys.Control) == Keys.Control;

            string pattern = @"^[a-zA-Z0-9.,!@#$%^&*()_+{}\[\]:;<>,.?~\\-]+$";

            if (!(ctrlPressed || Regex.IsMatch(e.KeyChar.ToString(), pattern) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SignIn();
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
                SignIn();
            }
        }

        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        private void SignInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
