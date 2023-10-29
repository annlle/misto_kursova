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
    public partial class FaqForm : Form
    {
        public FaqForm()
        {
            InitializeComponent();
        }

        private void sourceLinkLabelClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string projectGithubUrl = "https://github.com/annlle/misto_kursova";
            System.Diagnostics.Process.Start(projectGithubUrl);
        }
    }
}
