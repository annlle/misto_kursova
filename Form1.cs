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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            FaqForm faqForm = new FaqForm();
            faqForm.ShowDialog();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            AboutDevelopersForm aboutDevelopersForm = new AboutDevelopersForm();
            aboutDevelopersForm.ShowDialog();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PublicTransportForm publicTransportForm = new PublicTransportForm();
            publicTransportForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();
        }
    }
}
