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
    public partial class HospitalForm : Form
    {
        public HospitalForm()
        {
            InitializeComponent();
        }

        private void HospitalForm_Load(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            comboBox2.SelectedIndex = -1;
            comboBox3.Enabled = false;
            comboBox3.SelectedIndex = -1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = true;
            comboBox3.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
