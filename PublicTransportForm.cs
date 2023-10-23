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
    public partial class PublicTransportForm : Form
    {
        private bool isForward = true;
        public PublicTransportForm()
        {
            InitializeComponent();
        }

        private void PublicTransportForm_Load(object sender, EventArgs e)
        {
            UpdateButtonText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isForward = !isForward;
            UpdateButtonText();
        }
        private void UpdateButtonText()
        {
            button1.Text = isForward ? "Прямий" : "Зворотній";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                button7.Enabled = true;
            }
            else
            {
                button7.Enabled = false;
            }
        }

        
    }
}
