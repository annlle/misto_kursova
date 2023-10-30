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
    public partial class TravelInfoForm : Form
    {
        public TravelInfoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DniprogesForm dniprogesForm = new DniprogesForm();
            dniprogesForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KhortitsaForm khortitsaForm = new KhortitsaForm();
            khortitsaForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RainbowForm rainbowForm = new RainbowForm();
            rainbowForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SobornyForm sobornyForm = new SobornyForm();
            sobornyForm.ShowDialog();
        }
    }
}
