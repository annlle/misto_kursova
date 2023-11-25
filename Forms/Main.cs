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
            FaqForm faqForm = new FaqForm();
            faqForm.ShowDialog();
        }

        private void aboutDevelopersMenuItemClick(object sender, EventArgs e)
        {
            AboutDevelopersForm aboutDevelopersForm = new AboutDevelopersForm();
            aboutDevelopersForm.ShowDialog();
        }

        private void exitMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    
        private void publicTransportButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            PublicTransportForm publicTransportForm = new PublicTransportForm();
            publicTransportForm.ShowDialog();
        }

        private void profileButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog(); 
        }

        private void safetyButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            SafetyForm safetyForm = new SafetyForm();
            safetyForm.ShowDialog();
        }

        private void travelInfoButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            TravelInfoForm travelInfoForm = new TravelInfoForm();
            travelInfoForm.ShowDialog();
        }

        private void hospitalButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            HospitalForm hospitalForm = new HospitalForm();
            hospitalForm.ShowDialog();
        }
    }

    public class ButtonAnimationData
    {
        public double CurrentZoom { get; set; }
        public CancellationTokenSource AnimationCancellation { get; set; }
    }
}
