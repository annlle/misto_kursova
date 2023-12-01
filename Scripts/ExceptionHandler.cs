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
            FormNotFound
            // Буду добавлять по необходимости
        }

        public ErrorType Type { get; private set; }
        public string ErrorDetails { get; private set; }

        public ExceptionHandler(ErrorType type, string errorDetails)
        {
            Type = type;
            ErrorDetails = errorDetails;
            HandleError();
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
                // Буду добавлять по необходимости
            }
        }
    }
}
