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
        public static SignInForm signInForm = null;
        public static SignUpForm signUpForm = null;
        public static MainForm mainForm = null;
        public static AboutDevelopersForm aboutDevelopersForm = null;
        public static FaqForm faqForm = null;
        public static HospitalForm hospitalForm = null;
        public static ProfileForm profileForm = null;
        public static PublicTransportForm publicTransportForm = null;
        public static SafetyForm safetyForm = null;
        public static TravelInfoForm travelInfoForm = null;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            signUpForm = null;
            try
            {
                string envPath = ".env";

                if (!File.Exists(envPath))
                {
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FileNotFound, "Не знайдено \".env\"");
                }
            }
            catch (ExceptionHandler ex)
            {
                ex.HandleError();
                Environment.Exit(1);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(signInForm = new SignInForm());
        }
    }
}
