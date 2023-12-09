using kursova.Scripts.Extensions;
using kursova.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.IO;
using System.Xml.Linq;

namespace kursova
{
    public partial class MainForm : Form
    {
        private Image[] originalImages = new Image[5];
        private ButtonAnimationData[] buttonAnimationData = new ButtonAnimationData[5];
        private float timeToZoom = 0.1f;
        private double zoomAmount = 1.1;

        public MainForm()
        {
            InitializeComponent();
            InitializeButtons();

            //Image MalePicture = Image.FromFile(Path.Combine("Data", "profileMButton.png")); ; // Provide the actual file path
            //Image FemalePicture = Image.FromFile(Path.Combine("Data", "profileFButton.png")); // Provide the actual file path

            // Set the initial background image based on the user's sex
            //profileButton.BackgroundImage = User.CurrentUser.Sex == Sex.Male ? MalePicture : FemalePicture;
        }

        private void InitializeButtons()
        {
            Button[] buttons = { publicTransportButton, safetyButton, travelInfoButton, hospitalButton, profileButton };
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].BackgroundImage = originalImages[i] = AlignImage(buttons[i]);
                buttonAnimationData[i] = new ButtonAnimationData
                {
                    CurrentZoom = 1.0,
                    AnimationCancellation = null
                };

                int index = i;

                buttons[i].MouseEnter += (sender, e) =>
                {
                    HandleMouseEnter(buttons[index], originalImages[index], buttonAnimationData[index], zoomAmount);
                };

                buttons[i].MouseLeave += (sender, e) =>
                {
                    HandleMouseLeave(buttons[index], originalImages[index], buttonAnimationData[index]);
                };
            }
        }

        private async void HandleMouseEnter(Button button, Image original, ButtonAnimationData data, double zoomAmount)
        {
            if (data.AnimationCancellation != null && !data.AnimationCancellation.Token.IsCancellationRequested)
            {
                data.AnimationCancellation.Cancel();
            }

            data.AnimationCancellation = new CancellationTokenSource();
            await ZoomControl(button, original, data, zoomAmount, timeToZoom);
        }

        private async void HandleMouseLeave(Button button, Image original, ButtonAnimationData data)
        {
            if (data.AnimationCancellation != null && !data.AnimationCancellation.Token.IsCancellationRequested)
            {
                data.AnimationCancellation.Cancel();
            }

            data.AnimationCancellation = new CancellationTokenSource();
            await ZoomControl(button, original, data, 1.0, timeToZoom);
        }

        private async Task ZoomControl(Button button, Image original, ButtonAnimationData data, double end, float timeToReachTarget)
        {
            float elapsedTime = 0f;
            float fakeProgress;
            float progress = 0f; // 0 - 1
            double start = data.CurrentZoom;

            CancellationTokenSource animationCancellation = data.AnimationCancellation;

            while (progress < 1f)
            {
                if (animationCancellation.Token.IsCancellationRequested)
                {
                    return;
                }

                elapsedTime += 0.01f;
                progress = elapsedTime / timeToReachTarget;

                fakeProgress = (float)-Math.Cos(Math.PI / 2 * (progress + 1));

                data.CurrentZoom = (end - start) * fakeProgress + start;

                button.BackgroundImage = ZoomImage(original, data.CurrentZoom);

                await Task.Delay(10);
            }

            button.BackgroundImage = ZoomImage(original, end);
            data.CurrentZoom = end;
        }

        private Image ZoomImage(Image img, double scale)
        {
            int newWidth = (int)(img.Width * scale);
            int newHeight = (int)(img.Height * scale);
            Bitmap zoomedImg = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(zoomedImg))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(img, new Rectangle(Point.Empty, zoomedImg.Size));
            }
            return zoomedImg;
        }

        private Image AlignImage(Button button)
        {
            int newWidth = (int)(button.Height * 0.8);
            int newHeight = (int)(button.Height * 0.8);
            Bitmap alignedImg = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(alignedImg))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(button.BackgroundImage, new Rectangle(Point.Empty, alignedImg.Size));
            }
            return alignedImg;
        }

        private void faqMenuItemClick(object sender, EventArgs e)
        {
            bool fileFound = true;

            try
            {
                if (!File.Exists("../../Forms/FaqForm.cs") || !File.Exists("../../Forms/FaqForm.Designer.cs") || !File.Exists("../../Forms/FaqForm.resx"))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FormNotFound, "FaqForm");
                }

                if (fileFound)
                {
                    FaqForm faqForm = new FaqForm();
                    faqForm.ShowDialog();
                }
            }
            catch (ExceptionHandler ex)
            {
                ex.HandleError();
            }
        }

        private void aboutDevelopersMenuItemClick(object sender, EventArgs e)
        {
            bool fileFound = true;

            try
            {
                if (!File.Exists("../../Forms/AboutDevelopersForm.cs") || !File.Exists("../../Forms/AboutDevelopersForm.Designer.cs") || !File.Exists("../../Forms/AboutDevelopersForm.resx"))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FormNotFound, "AboutDevelopersForm");
                }

                if (fileFound)
                {
                    AboutDevelopersForm aboutDevelopersForm = new AboutDevelopersForm();
                    aboutDevelopersForm.ShowDialog();
                }
            }
            catch (ExceptionHandler ex)
            {
                ex.HandleError();
            }
        }

        private void publicTransportButtonClick(object sender, EventArgs e)
        {
            bool fileFound = true;

            try
            {
                if (!File.Exists("../../Forms/PublicTransportForm.cs") || !File.Exists("../../Forms/PublicTransportForm.Designer.cs") || !File.Exists("../../Forms/PublicTransportForm.resx"))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FormNotFound, "PublicTransportForm");
                }
                
                string xmlFilePath = "Data/routes.xml";

                if (!File.Exists(xmlFilePath))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FileNotFound, $"Не знайдено \"{xmlFilePath}\"");
                }

                string imagesFolder = "Data";
                string[] imageFiles = { "minibus.png", "bus.png", "trolleybus.png", "tram.png" };

                foreach (string fileName in imageFiles)
                {
                    string imagePath = Path.Combine(imagesFolder, fileName);
                    if (!File.Exists(imagePath))
                    {
                        fileFound = false;
                        throw new ExceptionHandler(ExceptionHandler.ErrorType.FileNotFound, $"Не знайдено \"{fileName}\"");
                    }
                }
            }
            catch (ExceptionHandler ex)
            {
                ex.HandleError();
            }

            if (fileFound)
            {
                this.Hide();
                PublicTransportForm publicTransportForm = new PublicTransportForm();
                publicTransportForm.ShowDialog();
            }
        }

        private void profileButtonClick(object sender, EventArgs e)
        {
            bool fileFound = true;

            try
            {
                if (!File.Exists("../../Forms/ProfileForm.cs") || !File.Exists("../../Forms/ProfileForm.Designer.cs") || !File.Exists("../../Forms/ProfileForm.resx"))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FormNotFound, "ProfileForm");
                }

                string hospitalsFilePath = Path.Combine("Data", "hospitals.json");

                if (!File.Exists(hospitalsFilePath))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FileNotFound, $"Не знайдено \"{hospitalsFilePath}\"");
                }

                string addressesFilePath = "Data/addresses.xml";

                if (!File.Exists(addressesFilePath))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FileNotFound, $"Не знайдено \"{addressesFilePath}\"");
                }

                string imageManPath = "Data/man.png";
                string imageWomanPath = "Data/woman.png";

                if (!File.Exists(imageManPath) && !File.Exists(imageWomanPath))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FileNotFound, $"Не знайдено \"{imageManPath}\", \"{imageWomanPath}\" ");
                }
                else if (!File.Exists(imageManPath))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FileNotFound, $"Не знайдено \"{imageManPath}\"");
                }
                else if (!File.Exists(imageWomanPath))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FileNotFound, $"Не знайдено \"{imageWomanPath}\" ");
                }
            }
            catch (ExceptionHandler ex)
            {
                ex.HandleError();
            }

            if (fileFound)
            {
                this.Hide();
                ProfileForm profileForm = new ProfileForm();
                profileForm.ShowDialog();
            }
        }

        private void safetyButtonClick(object sender, EventArgs e)
        {
            bool fileFound = true;

            try
            {
                if (!File.Exists("../../Forms/SafetyForm.cs") || !File.Exists("../../Forms/SafetyForm.Designer.cs") || !File.Exists("../../Forms/SafetyForm.resx"))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FormNotFound, "SafetyForm");
                }
            }
            catch (ExceptionHandler ex)
            {
                ex.HandleError();
            }

            if (fileFound)
            {
                this.Hide();
                SafetyForm safetyForm = new SafetyForm();
                safetyForm.ShowDialog();
            }
        }

        private void travelInfoButtonClick(object sender, EventArgs e)
        {
            bool fileFound = true;

            try
            {
                if (!File.Exists("../../Forms/TravelInfoForm.cs") || !File.Exists("../../Forms/TravelInfoForm.Designer.cs") || !File.Exists("../../Forms/TravelInfoForm.resx"))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FormNotFound, "TravelInfoForm");
                }

                string xmlFilePath = "Data/tourist-info.xml";
                if (!File.Exists(xmlFilePath))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FileNotFound, $"Не знайдено \"{xmlFilePath}\"");
            
                }

                string imagesFolder = "Data/Tourist-images";
                string[] imageFiles = { "БШ.jpg", "ДніпроГЕС.jpg", "Райдуга.jpg", "Соборний проспект.jpg", "Фаетон.jpg", "Фонтан життя.jpg", "Хортиця.jpg" };
                foreach (string fileName in imageFiles)
                {
                    string imagePath = Path.Combine(imagesFolder, fileName);
                    if (!File.Exists(imagePath))
                    {
                        fileFound = false;
                        throw new ExceptionHandler(ExceptionHandler.ErrorType.FileNotFound, $"Не знайдено \"{fileName}\"");
                    }
                }
            }
            catch (ExceptionHandler ex)
            {
                ex.HandleError();
            }

            if (fileFound)
            {
                this.Hide();
                TravelInfoForm travelInfoForm = new TravelInfoForm();
                travelInfoForm.ShowDialog();
            }
            
        }

        private void hospitalButtonClick(object sender, EventArgs e)
        {
            bool fileFound = true;

            try
            {
                string filePath = Path.Combine("Data", "hospitals.json");

                if (!File.Exists(filePath))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FileNotFound, $"Не знайдено \"{filePath}\"");
                }

                if (!File.Exists("../../Forms/HospitalForm.cs") || !File.Exists("../../Forms/HospitalForm.Designer.cs") || !File.Exists("../../Forms/HospitalForm.resx"))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FormNotFound, "HospitalForm");
                }

                string doctorMalePath = "Data/doctor-male.png";
                string doctorFemalePath = "Data/doctor-female.png";

                if (!File.Exists(doctorMalePath) && !File.Exists(doctorFemalePath))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FileNotFound, $"Не знайдено \"{doctorMalePath}\", \"{doctorFemalePath}\" ");
                }
                else if (!File.Exists(doctorMalePath))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FileNotFound, $"Не знайдено \"{doctorMalePath}\"");
                }
                else if (!File.Exists(doctorFemalePath))
                {
                    fileFound = false;
                    throw new ExceptionHandler(ExceptionHandler.ErrorType.FileNotFound, $"Не знайдено \"{doctorFemalePath}\" ");
                }
            }
            catch (ExceptionHandler ex)
            {
                ex.HandleError();
            }

            if (fileFound)
            {
                this.Hide();
                HospitalForm hospitalForm = new HospitalForm();
                hospitalForm.ShowDialog();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

    public class ButtonAnimationData
    {
        public double CurrentZoom { get; set; }
        public CancellationTokenSource AnimationCancellation { get; set; }
    }
}
