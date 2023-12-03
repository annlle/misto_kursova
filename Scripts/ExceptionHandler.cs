using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova.Scripts
{
    public class ExceptionHandler : Exception
    {
        public enum ErrorType
        {
            FileNotFound,
            FormNotFound,
            InvalidEmail,
            InvalidPassword,
            UnknownError
            // Буду добавлять по необходимости
        }

        public ErrorType Type { get; private set; }
        public string ErrorDetails { get; private set; }

        public ExceptionHandler(ErrorType type = ExceptionHandler.ErrorType.UnknownError, string errorDetails = "")
        {
            Type = type;
            ErrorDetails = errorDetails;
        }

        public void HandleError()
        {
            switch (Type)
            {
                case ErrorType.FileNotFound:
                    MessageBox.Show($"Помилка! Відсутній файл. {ErrorDetails}", "Помилка!");
                    break;
                case ErrorType.FormNotFound:
                    MessageBox.Show($"Помилка завантаження вікна! {ErrorDetails}", "Помилка!");
                    break;
                case ErrorType.InvalidEmail:
                    MessageBox.Show($"Помилка при введені пошти! {ErrorDetails}", "Помилка!");
                    break;
                case ErrorType.InvalidPassword:
                    MessageBox.Show($"Невірний пароль! {ErrorDetails}", "Помилка!");
                    break;
                // Буду добавлять по необходимости
                default:
                    MessageBox.Show($"Невідома помилка! {ErrorDetails}", "Помилка!");
                    break;
            }
        }
    }
}
