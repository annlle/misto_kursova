using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova.Scripts
{
    public class EventTile : Panel
    {
        public Label Type { get; private set; }
        public Label LocationLabel { get; private set; }
        public PictureBox LocationLink { get; private set; }
        public Event Event { get; private set; }

        public EventTile(Panel template, Label type, Label loc, PictureBox locLink, Event e)
        {
            // Копирование свойств template
            this.Size = template.Size;
            this.BackColor = template.BackColor;

            // Копирование свойств элементов
            Event = e;

            Type = new Label();
            Type.Text = EventTranslations.UkrainianTranslations[Event.EventType];
            Type.Font = type.Font;
            Type.Location = type.Location;
            Type.Size = type.Size;
            Type.BackColor = type.BackColor;
            this.Controls.Add(Type);

            LocationLabel = new Label();
            LocationLabel.Text = Event.Location.Name;
            LocationLabel.Font = loc.Font;
            LocationLabel.Location = loc.Location;
            LocationLabel.Size = loc.Size;
            LocationLabel.BackColor = loc.BackColor;
            this.Controls.Add(LocationLabel);

            LocationLink = new PictureBox();
            LocationLink.Image = locLink.Image;
            LocationLink.SizeMode = locLink.SizeMode;
            LocationLink.Location = locLink.Location;
            LocationLink.Size = locLink.Size;
            LocationLink.BackColor = locLink.BackColor;
            LocationLink.Image = locLink.Image;
            LocationLink.Click += Event.Location.OpenLink;
            this.Controls.Add(LocationLink);
        }
    }

}