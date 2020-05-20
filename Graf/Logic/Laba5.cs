using Graf.Executors;
using System.Collections.Generic;
using System.Linq;
using Graf.Algoritms;

namespace Graf.Logic
{
    class Laba5 : IMission
    {
        private MainDrawer _mainDrawer;
        private Graf _graf;
        private string _result;

        public Laba5(MainDrawer mainDrawer, Graf graf)
        {
            _mainDrawer = mainDrawer;
            _graf = graf;
        }

        public void DoIt()
        {
            var helpList = new int[_graf.GetVertexCount()];
            foreach (var edge in _graf.GetEdgeList())
            {
                helpList[edge.StartVertex - 1]++;
                helpList[edge.FinishVertex - 1]++;
            }
            var counter = 0;
            foreach (var numOfVertex in helpList)
            {
                if (numOfVertex == 0)
                {
                    _result = "Нет Эйлерова цикла, граф несвязный";
                    return;
                }
                counter += numOfVertex % 2;
            }
            var floyd = new Floyd(_graf);
            var flag = true;
            foreach (var edge in floyd.Matrix)
            {
                if (edge > 99999)
                {
                    flag = false;
                }
            }
            if (flag)
            {
                if (counter == 0)
                {
                    _result = "Есть Эйлеров цикл";
                    if (_mainDrawer.GetCheckedVetex() < 0)
                    {
                        return;
                    }
                    _mainDrawer.TimingDraw(GetEdgeList());
                    return;
                }
                else
                {
                    _result = "Нет Эйлерова цикла, есть вершины с нечетной степенью";
                    return;
                }
            }
            else
            {
                _result = "Нет Эйлерова цикла, граф несвязный";
                return;
            }
        }

        private List<Edge> GetEdgeList()
        {
            var matrix = ConvertToMatrix.GetMatrix(_graf);
            var edgeList = new List<Edge>();
            var vertexStack = new Stack<int>();
            var rootList = new List<int>();
            
            var root = _mainDrawer.GetCheckedVetex();
            vertexStack.Push(root);

            while (vertexStack.Count!=0)
            {
                var edge = _graf.GetEdgeList().FirstOrDefault(e => e.StartVertex == vertexStack.Peek() || e.FinishVertex==vertexStack.Peek());
                if (edge == null)
                {
                    rootList.Add(vertexStack.Pop());
                    continue;
                }

                if (edge.StartVertex == vertexStack.Peek())
                {
                    vertexStack.Push(edge.FinishVertex);
                }
                else
                {
                    vertexStack.Push(edge.StartVertex);
                }
                _graf.DeleteEdge(edge);
            }

            rootList.Reverse();
            for (var i = 0; i < rootList.Count - 1; i++)
            {
                edgeList.Add(new Edge(rootList[i], rootList[i+1], 0 , false));
            }

            _graf.Restore(matrix);

            return edgeList;
        }

        public string GetListWithResalts()
        {
            return _result;
        }
    }
}
