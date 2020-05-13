using Graf.Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;

namespace Graf.Executors
{
    internal class LineDrawer
    {
        private int _weight;
        private Point _startPoint;
        private Point _finishPoint;
        public int OrderForDraw { get; set; }
        public int NumStartVertex { get; set; }
        public int NumFinishVertex { get; set; }

        internal LineDrawer(Point start, Point finish, int weight, int numStart, int numFinish)
        {
            _startPoint = start;
            _finishPoint = finish;
            _weight = weight;
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
        }

        internal void TimingDraw(GrafData data)
        {
            var pen = new Pen(Color.Red, 5);
            pen.EndCap = LineCap.ArrowAnchor;
            data.FormGraphics.DrawLine(pen, _startPoint, _finishPoint);
        }
    }
}