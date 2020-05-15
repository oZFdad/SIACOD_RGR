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
        private bool _drawToRyppaty;
        private List<LineDrawer> _drawForRippatyList = new List<LineDrawer>();
        private List<LineDrawer> _buferLineList = new List<LineDrawer>();
        
        private Queue<int> _listForDej = new Queue<int>();

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
                    if (data.ForDej)
                    {
                        _listForDej.Enqueue(circle.Number);
                        if (_listForDej.Count > 2)
                        {
                            _listForDej.Clear();
                            ClearChekedList();
                        }
                    }
                    return true;
                }
            }

            return false;
        }

        internal void TimingDraw(List<Edge> edgeList)
        {
            foreach(var edge in edgeList)
            {
                foreach(var line in _lineList)
                {
                    if (edge.StartVertex == line.NumStartVertex && edge.FinishVertex == line.NumFinishVertex || edge.StartVertex == line.NumFinishVertex && edge.FinishVertex == line.NumStartVertex)
                    {
                        _drawForRippatyList.Add(line);
                    }
                }
            }
            _drawToRyppaty = true;
        }

        internal void Draw(GrafData data)
        {
            if (_drawToRyppaty)
            {
                _lineList.Remove(_drawForRippatyList[0]);
                _buferLineList.Add(_drawForRippatyList[0]);
                _drawForRippatyList.RemoveAt(0);
            }
            foreach (var line in _lineList)
            {
                line.Draw(data);
            }
            foreach (var circle in _circleList)
            {
                circle.Draw(data);
            }
            foreach(var line in _buferLineList)
            {
                line.TimingDraw(data);
            }
            if (_drawToRyppaty)
            {
                if (_drawForRippatyList.Count == 0)
                {
                    _drawToRyppaty = false;
                    _lineList.AddRange(_buferLineList);
                    _buferLineList.Clear();
                    foreach (var circle in _circleList)
                    {
                        circle.Check = false;
                    }
                    _checkedVertex.Clear();
                }
            }
        }

        internal void AddVertex(GrafData data)
        {
            var num = _graf.AddVertex();
            var vertex = new CircleDrawer(num,data.ClicPoint);
            _circleList.Add(vertex);
            _checkedVertex.Clear();
            foreach (var circleDrawer in _circleList)
            {
                circleDrawer.Check = false;
            }
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
                    foreach (var line in _lineList)
                    {
                        if (data.CheckEdgeRoute)
                        {
                            if (line.NumStartVertex == _checkedVertex[0].Number &&
                                line.NumFinishVertex == _checkedVertex[1].Number)
                            {
                                return;
                            }
                        }
                        else
                        {
                            if (line.NumStartVertex == _checkedVertex[0].Number &&
                                line.NumFinishVertex == _checkedVertex[1].Number ||
                                line.NumStartVertex == _checkedVertex[1].Number &&
                                line.NumFinishVertex == _checkedVertex[0].Number)
                            {
                                return;
                            }
                        }
                    }
                    _graf.AddEdge(_checkedVertex[0].Number,_checkedVertex[1].Number,data.Weight, data.CheckEdgeRoute);
                    _lineList.Add(new LineDrawer
                        (
                        _checkedVertex[0].Point, 
                        _checkedVertex[1].Point, 
                        data.Weight, 
                        _checkedVertex[0].Number, 
                        _checkedVertex[1].Number)
                        );
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
            foreach (var circle in _circleList)
            {
                circle.Check = false;
            }
        }

        internal void ClearLineList()
        {
            _lineList.Clear();
        }

        internal int GetCheckedVetex()
        {
            if (_checkedVertex.Count == 0)
            {
                return -1;
            }
            else
            {
                return _checkedVertex[0].Number;
            }
        }

        public int GetVertexForDej()
        {
            return _listForDej.Dequeue();
        }

        public bool FullListForDej()
        {
            return _listForDej.Count == 2;
        }
    }
}