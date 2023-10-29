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
    public partial class mainForm : Form
    {
        public mainForm()
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
            PublicTransportForm publicTransportForm = new PublicTransportForm();
            publicTransportForm.ShowDialog();
        }

        private void profileButtonClick(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();
            
        }

        private void safetyButtonClick(object sender, EventArgs e)
        {
            SafetyForm safetyForm = new SafetyForm();
            safetyForm.ShowDialog();
        }

        private void travelInfoButtonClick(object sender, EventArgs e)
        {
            TravelInfoForm travelInfoForm = new TravelInfoForm();
            travelInfoForm.ShowDialog();
        }

        private void hospitalButtonClick(object sender, EventArgs e)
        {
            HospitalForm hospitalForm = new HospitalForm();
            hospitalForm.ShowDialog();
        }
    }
}
