using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova.Scripts
{
    public class EventTile : Panel
    {
        public Label Type { get; private set; }
        public Label Location { get; private set; }
        public PictureBox LocationLink { get; private set; }
        public Event Event { get; private set; }
        public EventTile(Panel template, Label type, Label loc, PictureBox locLink, Event e)
        {

        }
    }

}