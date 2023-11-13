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
            // ����������� ������� template
            this.Size = template.Size;
            this.BackColor = template.BackColor;

            // ����������� ������� ���������
            Event = e;

            Type = new Label
            {
                Text = EventTranslations.UkrainianTranslations[Event.EventType],
                Font = type.Font,
                Location = type.Location,
                Size = type.Size,
                BackColor = type.BackColor
            };
            this.Controls.Add(Type);

            LocationLabel = new Label
            {
                Text = Event.Location.Name,
                Font = loc.Font,
                Location = loc.Location,
                Size = loc.Size,
                BackColor = loc.BackColor
            };
            this.Controls.Add(LocationLabel);

            LocationLink = new PictureBox
            {
                Image = locLink.Image,
                SizeMode = locLink.SizeMode,
                Location = locLink.Location,
                Size = locLink.Size,
                BackColor = locLink.BackColor
            };
            LocationLink.Click += Event.Location.OpenLink;
            this.Controls.Add(LocationLink);
        }
    }

}