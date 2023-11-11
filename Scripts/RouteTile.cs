using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova.Scripts
{
    public class RouteTile
    {
        public Label Number { get; private set;}
        public Label Direction { get; private set;}
        public Label Frequency { get; private set;}
        public Label Time { get; private set;}
        public PictureBox TypePicture { get; private set;}
        public Route Route { get; private set;}

        public RouteTile(Panel template, Label num, Label dir, Label freq, Label time, PictureBox typePic, Route route)
        {

        }

    }
}
