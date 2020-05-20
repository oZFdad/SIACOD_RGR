using Graf.Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;

namespace Graf.Executors
{
    internal class LineDrawer
    {
        public int Weight
        {
            get;
        }
        private Point _startPoint;
        private Point _finishPoint;
        public int NumStartVertex { get; set; }
        public int NumFinishVertex { get; set; }

        internal LineDrawer(Point start, Point finish, int weight, int numStart, int numFinish)
        {
            _startPoint = start;
            _finishPoint = finish;
            Weight = weight;
            NumStartVertex = numStart;
            NumFinishVertex = numFinish;
        }

        internal void Draw(GrafData data)
        {
            var pen = new Pen(Color.Green);
            if (data.CheckEdgeRoute)
            {
                pen = new Pen(Color.Green, 5);
                pen.EndCap = LineCap.ArrowAnchor;
            }
            data.FormGraphics.DrawLine(pen, _startPoint, _finishPoint);
            var brushForWeight = new SolidBrush(Color.Brown);
            WriteWeight(data, brushForWeight);
        }

        internal void TimingDraw(GrafData data)
        {
            var pen = new Pen(Color.Red, 5);
            var brushForWeight = new SolidBrush(Color.Black);
            pen.EndCap = LineCap.ArrowAnchor;
            data.FormGraphics.DrawLine(pen, _startPoint, _finishPoint);
            WriteWeight(data, brushForWeight);
        }

        private void WriteWeight(GrafData data, Brush brush)
        {
            if (Weight != 30)
            {
                var point = new Point((_startPoint.X + _finishPoint.X) / 2, (_startPoint.Y + _finishPoint.Y) / 2);
                var fontFamily = new FontFamily("Comic Sans MS");
                var font = new Font(fontFamily, 16, FontStyle.Underline, GraphicsUnit.Pixel);
                data.FormGraphics.DrawString(Weight.ToString(), font, brush, point);
            }
        }
    }
}