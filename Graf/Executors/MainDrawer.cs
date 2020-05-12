using System;
using System.Collections.Generic;
using Graf.Models;

namespace Graf.Executors
{
    internal class MainDrawer
    {
        private List<CircleDrawer> _circleList = new List<CircleDrawer>();
        private List<LineDrawer> _lineList = new List<LineDrawer>();
        private List<CircleDrawer> _checkedVertex = new List<CircleDrawer>();
        private Graf _graf;

        internal MainDrawer(Graf graf)
        {
            _graf = graf;
        }

        internal bool IsCheckBoardCircle(GrafData data)
        {
            foreach (var circle in _circleList)
            {
                var dx = data.ClicPoint.X - circle.Point.X;
                var dy = data.ClicPoint.Y - circle.Point.Y;
                var r = circle.R;
                if (dx * dx + dy * dy < r * r)
                {
                    circle.Check = !circle.Check;
                    data.CheckCircle = !data.CheckCircle;
                    return true;
                }
            }

            return false;
        }

        internal void Draw(GrafData data)
        {
            foreach (var line in _lineList)
            {
                line.Draw(data);
            }
            foreach (var circle in _circleList)
            {
                circle.Draw(data);
            }
        }

        internal void AddVertex(GrafData data)
        {
            var num = _graf.AddVertex();
            var vertex = new CircleDrawer(num,data.ClicPoint);
            _circleList.Add(vertex);
        }

        internal void AddEdge(GrafData data)
        {
            foreach (var circle in _circleList)
            {
                if (_checkedVertex.Count == 0)
                {
                    if (circle.Check)
                    {
                        _checkedVertex.Add(circle);
                        return;
                    }
                }
                if (circle.Check && circle!=_checkedVertex[0])
                {
                    _checkedVertex.Add(circle);
                    _graf.AddEdge(_checkedVertex[0].Number,_checkedVertex[1].Number,data.Weight, data.CheckEdgeRoute);
                    _lineList.Add(new LineDrawer(_checkedVertex[0].Point,_checkedVertex[1].Point,data.Weight));
                    _checkedVertex.Clear();
                    foreach(var circle2 in _circleList)
                    {
                        circle2.Check = false;
                    }
                    return;
                }
            }
        }

        internal void ClearChekedList()
        {
            _checkedVertex.Clear();
        }

        internal void ClearLineList()
        {
            _lineList.Clear();
        }
    }
}