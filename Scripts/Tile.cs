using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova.Scripts
{
    public abstract class Tile : Panel
    {
        public abstract void PaintTile(Graphics g);

        public void Tile_Paint(object sender, PaintEventArgs e)
        {
            Tile tile = sender as Tile;
            if (tile != null)
            {
                tile.PaintTile(e.Graphics);
            }
        }

        public void FillCapsule(Graphics g, Brush brush, int x, int y, int width, int height)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(x, y, width, width, 180, 180);
            path.AddArc(x, y + height - width, width, width, 0, 180);

            // Сама отрисовка
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillPath(brush, path);
            g.SmoothingMode = SmoothingMode.Default;
        }

        public void FillRoundedBackground(Graphics g, Brush brush, int cornerCircleDiameter)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, cornerCircleDiameter, cornerCircleDiameter, 180, 90);
            path.AddArc(Width - cornerCircleDiameter, 0, cornerCircleDiameter, cornerCircleDiameter, -90, 90);
            path.AddArc(Width - cornerCircleDiameter, Height - cornerCircleDiameter, cornerCircleDiameter, cornerCircleDiameter, 0, 90);
            path.AddArc(0, Height - cornerCircleDiameter, cornerCircleDiameter, cornerCircleDiameter, 90, 90);

            // Сама отрисовка
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillPath(brush, path);
            g.SmoothingMode = SmoothingMode.Default;
        }
    }
}
