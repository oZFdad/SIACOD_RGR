using Graf.Models;
using System.Drawing;

namespace Graf.Executors
{
    internal class CircleDrawer
    {
        private int _number;
        private Point _point;
        private int _r = 20;
        private bool _check = false;

        internal Point Point
        {
            get => _point;
            set => _point = value;
        }

        internal int R
        {
            get => _r;
            set => _r = value;
        }

        internal bool Check
        {
            get => _check;
            set => _check = value;
        }

        internal int Number
        {
            get => _number;
            set => _number = value;
        }

        internal CircleDrawer(int number, Point point)
        {
            _number = number;
            _point = point;
        }

        internal void Draw(GrafData data)
        {
            var rect = new Rectangle(_point.X - R / 2, _point.Y - R / 2, R, R);
            var pen = new Pen(Color.Red);
            if (_check)
            {
                pen = new Pen(Color.Red, 3);
            }
            data.FormGraphics.DrawEllipse(pen, rect);

            var brush = new SolidBrush(Color.Black);
            var fontFamily = new FontFamily("Comic Sans MS");
            var font = new Font(fontFamily, 12, FontStyle.Regular, GraphicsUnit.Pixel);
            data.FormGraphics.DrawString(Number.ToString(), font, brush, Point);
        }
    }
}