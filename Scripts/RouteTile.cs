using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova.Scripts
{
    public class RouteTile : Panel
    {
        public Label Number { get; private set;}
        public Label Direction { get; private set;}
        public Label Frequency { get; private set;}
        public Label Time { get; private set;}
        public PictureBox TypePicture { get; private set;}
        public Route Route { get; private set;}

        public RouteTile(Panel template, Label num, Label dir, Label freq, Label time, PictureBox typePic, Route route)
        {
            // Копирование свойств template
            this.Size = template.Size;
            this.BackColor = template.BackColor;

            // Копирование свойств элементов
            Route = route;

            Number = new Label
            {
                Text = Route.RouteNumber.ToString(),
                Font = num.Font,
                Location = num.Location,
                Size = num.Size,
                BackColor = num.BackColor
            };
            this.Controls.Add(Number);

            Direction = new Label
            {
                Text = Route.StraightDirection == true ? "Прямий" : "Зворотній",
                Font = dir.Font,
                Location = dir.Location,
                Size = dir.Size,
                BackColor = dir.BackColor
            };
            this.Controls.Add(Direction);

            Frequency = new Label
            {
                Text = Route.Frequency,
                Font = freq.Font,
                Location = freq.Location,
                Size = freq.Size,
                BackColor = freq.BackColor
            };
            this.Controls.Add(Frequency);

            Time = new Label
            {
                Text = Route.Time.Item1 + " - " + Route.Time.Item2,
                Font = time.Font,
                Location = time.Location,
                Size = time.Size,
                BackColor = time.BackColor
            };
            this.Controls.Add(Time);

            TypePicture = new PictureBox
            {
                Image = typePic.Image,
                SizeMode = typePic.SizeMode,
                Location = typePic.Location,
                Size = typePic.Size,
                BackColor = typePic.BackColor
            };
            this.Controls.Add(TypePicture);
        }

    }
}
