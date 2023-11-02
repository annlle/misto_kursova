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
using kursova.Scripts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            User = new User { };


            User.Mail = usersEmailTextBox.Text;
            User.Password = usersPasswordTextBox.Text;
            User.Surname = usersSurnameTextBox.Text;
            User.Name = usersNameTextBox.Text;
            User.Patronymic = usersPatronymTextBox.Text;
            User.Sex = usersSexComboBox.Text;
            User.Age = Convert.ToInt32(usersAgeTextBox.Text);

            User.CurrentUser = this.User;

            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
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
                return;
            }
            else if (User.TryGetUser(usersEmailTextBox.Text))
            {
                mailCheckerLabel.Text = "Пошта вже зайнята!";
                mailCheckerLabel.ForeColor = Color.Red;
            }
            else
            {
                mailCheckerLabel.Text = "Пошта підходить!";
                mailCheckerLabel.ForeColor = Color.Green;
            }
        }
    }
}
