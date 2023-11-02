using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursova
{
    public partial class HospitalForm : Form
    {
        public HospitalForm()
        {
            InitializeComponent();
        }

        private void HospitalForm_Load(object sender, EventArgs e)
        {
            hospitalComboBox.Enabled = false;
            doctorComboBox.Enabled = false;
            timeComboBox.Enabled = false;
        }

        private void districtComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(districtComboBox.SelectedIndex >= 0)
            {
                hospitalComboBox.Enabled=true;
            }
            else
            {
                hospitalComboBox.Enabled=false;
                doctorComboBox.Enabled=false;
                timeComboBox.Enabled=false;
            }

        }

        private void hospitalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(hospitalComboBox.SelectedIndex >= 0)
            {
                doctorComboBox.Enabled = true;
            }
            else
            {
                doctorComboBox.Enabled = false;
                timeComboBox.Enabled = false;
            }

        }

        private void doctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doctorComboBox.SelectedIndex >= 0)
            {
                timeComboBox.Enabled = true;
            }
            else
            {
                timeComboBox.Enabled = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void timeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (timeComboBox.SelectedIndex >= 0)
            //{
            //    signButton.Enabled = true;
            //}
            //else
            //{
            //    signButton.Enabled = false;
            //}
        }
    }
}
