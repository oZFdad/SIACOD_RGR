using System.Collections.Generic;
using Graf.Models;

namespace Graf.Executors
{
    public class MainDrawer
    {
        private List<CircleDrawer> _circleList = new List<CircleDrawer>();
        private List<LineDrawer> _lineList = new List<LineDrawer>();
        private List<CircleDrawer> _checkedVertex = new List<CircleDrawer>();
        private Graf _graf;

        public MainDrawer(Graf graf)
        {
            _graf = graf;
        }

        public bool CheckBoardCircle(GrafData data)
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
                }

                return true;
            }

            return false;
        }

        public void AddEdge(GrafData data)
        {
            var num = _graf.AddVertex();
            var vertex = new CircleDrawer(num,data.ClicPoint);
        }

        public void AddVertex(GrafData data)
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
                    _graf.AddEdge(_checkedVertex[0].Number,_checkedVertex[1].Number,data.Weight);
                    _checkedVertex.Clear();
                    return;
                }
            }
        }
    }
}