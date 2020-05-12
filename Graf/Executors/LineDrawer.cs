using Graf.Models;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Graf.Executors
{
    internal class LineDrawer
    {
        private int _weight;
        private Point _startPoint;
        private Point _finishPoint;

        internal LineDrawer(Point start, Point finish, int weight)
        {
            _startPoint = start;
            _finishPoint = finish;
            _weight = weight;
        }

        internal void Draw(GrafData data)
        {
            var pen = new Pen(Color.Black);
            if (data.CheckEdgeRoute)
            {
                pen.EndCap = LineCap.ArrowAnchor;
            }
            data.FormGraphics.DrawLine(pen, _startPoint, _finishPoint);
        }
    }
}