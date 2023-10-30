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
    public partial class SafetyForm : Form
    {
        public SafetyForm()
        {
            InitializeComponent();
        }

        private void SafetyForm_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

    }

    public class safetyPanel : Panel
    {
        public Label typePanelLabel { get; private set; }
        public Label levelSafetyPanelLabel { get; private set; }
        public Label locationPanelLabel { get; private set; }
    }
}
