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

namespace kursova
{
    public partial class SignInForm : Form
    {
        private User User = new User { };

        private CancellationTokenSource timerCancellation;

        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if(usersPasswordTextBox.Text == User.Password)
            {
                User.CurrentUser = this.User; // выставляем текущего пользователя если пароль правильный
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Невірний пароль!", "Помилка"); // при неверном пароле, можно поменять на что-то получше
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
            await Task.Delay(1000); // время перед выводом текста о проверке почты

            if (cancellationToken.IsCancellationRequested)
                return;

            if (usersEmailTextBox.Text.Length < 5) // порог длины почты (если меньше 5 символов, ничего не будет написано)
            {
                mailCheckerLabel.Text = "";
                signInButton.Enabled = false;
                return;
            }
            else if (User.TryGetUser(usersEmailTextBox.Text))
            {
                mailCheckerLabel.Text = "Пошту знайдено!";
                mailCheckerLabel.ForeColor = Color.Green;
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
            this.Hide();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }
    }
}
