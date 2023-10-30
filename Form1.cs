using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
}
