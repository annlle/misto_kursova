using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using kursova.Scripts;

namespace kursova
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                string envPath = ".env";

                if (!File.Exists(envPath))
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FileNotFound, "Не знайдено \".env\"");
                
                if (!File.Exists("../../Forms/SignInForm.cs") || !File.Exists("../../Forms/SignInForm.Designer.cs") || !File.Exists("../../Forms/SignInForm.resx"))
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FormNotFound, "SignInForm");

            }
            catch (ExceptionHandler ex)
            {
                ex.HandleError();
                Environment.Exit(1);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignInForm());
        }
    }
}
