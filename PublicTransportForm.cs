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

        private void directionButtonClick(object sender, EventArgs e)
        {
            isForward = !isForward;
            UpdateButtonText();
        }
        private void UpdateButtonText()
        {
            directionButton.Text = isForward ? "Прямий" : "Зворотній";
        }

        private void backButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    public class transportInfoPanel : Panel
    {
        public PictureBox transportPanelPicture { get; private set; }
        public Label numberPanelLabel { get; private set; }
        public Label directionPanelLabel { get; private set; }
        public Label frequencyPanelLabel { get; private set; }
        public Label timePanelLabel { get; private set; }
    }
}
