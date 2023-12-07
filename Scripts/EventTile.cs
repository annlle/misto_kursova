using kursova.Scripts.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova.Scripts
{
    public class EventTile : Tile
    {
        public Label Type { get; private set; }
        public Label LocationLabel { get; private set; }
        public PictureBox LocationLink { get; private set; }
        public Event Event { get; private set; }

        public static List<Color> dangerColors = new List<Color>
        {
            Color.FromArgb(255, 0, 255, 0),
            Color.FromArgb(255, 255, 255, 0),
            Color.FromArgb(255, 255, 165, 0),
            Color.FromArgb(255, 255, 0, 0)
        };

        public EventTile(Panel template, Label type, Label loc, PictureBox locLink, Event e)
        {
            // Копирование свойств template
            this.Size = template.Size;
            this.BackColor = template.BackColor;

            // Копирование свойств элементов
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
                BackColor = locLink.BackColor,
                Cursor = locLink.Cursor
            };
            LocationLink.Click += Event.Location.OpenLink;
            this.Controls.Add(LocationLink);
        }

        public override void PaintTile(Graphics g)
        {
            Brush brush = new SolidBrush(Color.White);

            int width = this.Width;
            int height = this.Height;
            int cornerRadius = 10;

            FillRoundedBackground(g, brush, cornerRadius * 2);

            // Настройки капсулы
            brush = GetBrushByDangerLevel(Event.DangerLevel);
            //brush = new SolidBrush(Color.Blue);
            int x = 8;
            int y = 7;
            width = 12;
            height = 46;

            FillCapsule(g, brush, x, y, width, height);
        }

        private Brush GetBrushByDangerLevel(int dangerLevel)
        {
            switch (dangerLevel)
            {
                case 0:
                    return new SolidBrush(dangerColors[0]);
                case 1:
                    return new SolidBrush(dangerColors[1]);
                case 2:
                    return new SolidBrush(dangerColors[2]);
                case 3:
                    return new SolidBrush(dangerColors[3]);
                default:
                    return new SolidBrush(Color.LightGray);
            }
        }
    }

}