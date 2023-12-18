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
            InvalidPassword,
            UnknownError
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
                    MessageBox.Show($"Помилка! Відсутній файл. {ErrorDetails}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case ErrorType.InvalidPassword:
                    MessageBox.Show($"Невірний пароль! {ErrorDetails}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show($"Невідома помилка! {ErrorDetails}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
