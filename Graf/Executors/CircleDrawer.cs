using System.Drawing;

namespace Graf.Executors
{
    public class CircleDrawer
    {
        private int _number;
        private Point _point;
        private int _r = 30;
        private bool _check = false;

        public Point Point
        {
            get => _point;
            set => _point = value;
        }

        public int R
        {
            get => _r;
            set => _r = value;
        }

        public bool Check
        {
            get => _check;
            set => _check = value;
        }

        public int Number
        {
            get => _number;
            set => _number = value;
        }

        public CircleDrawer(int number, Point point)
        {
            _number = number;
            _point = point;
        }
    }
}