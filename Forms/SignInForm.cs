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

        private void signInButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool fileFound = true;

                if (!File.Exists("../../Forms/Main.cs") || !File.Exists("../../Forms/Main.Designer.cs") || !File.Exists("../../Forms/Main.resx"))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FormNotFound, "Main");
                }

                if (usersPasswordTextBox.Text == Encryptor.Decrypt(User.Password))
                {
                    User.CurrentUser = User;

                    if (fileFound)
                    {
                        this.Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.ShowDialog();
                    }
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

        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool fileFound = true;

            try
            {
                if (!File.Exists("../../Forms/SignUpForm.cs") || !File.Exists("../../Forms/SignUpForm.Designer.cs") || !File.Exists("../../Forms/SignUpForm.resx"))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FormNotFound, "SignUpForm");
                }
            }
            catch (ExceptionHandler ex)
            {
                ex.HandleError();
            }

            if (fileFound)
            {
                this.Hide();
                SignUpForm signUpForm = new SignUpForm();
                signUpForm.ShowDialog();
            }
        }

        private void SignInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
