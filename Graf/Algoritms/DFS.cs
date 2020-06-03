using System.Collections.Generic;
using System.Linq;

namespace Graf.Algoritms
{
    internal class DFS
    {
        private Graf _graf;
        private List<int> _visitedVertex = new List<int>();
        private List<Edge> _edgeList = new List<Edge>();
        private Stack<int> _stack = new Stack<int>();
        private int[,] _matrix;

        public List<int> VisitedVertex => _visitedVertex;

        public List<Edge> EdgeList => _edgeList;

        public DFS(Graf graf)
        {
            _graf = graf;
            _matrix = ConvertToMatrix.GetMatrix(_graf);
        }

        internal void ApplyAlgoritm(int root)
        {
            _stack.Push(root);
            _visitedVertex.Add(root);
            while (_stack.Count!=0)
            {
                for (var i = 0; i < _matrix.GetLength(0); i++)
                {
                    if (_matrix[_stack.Peek() - 1, i] != 0 && _visitedVertex.FirstOrDefault(v => v == i + 1) == 0)
                    {
                        Add(_stack.Peek(), i + 1);
                        i = -1;
                    }
                }
                _stack.Pop();
            }
        }

        private void Add(int peek, int i)
        {
            _stack.Push(i);
            _visitedVertex.Add(i);
            _edgeList.Add(new Edge(peek,i,0,false));
        }
    }
}