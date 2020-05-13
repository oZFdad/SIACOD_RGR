
using System;
using System.Collections.Generic;

namespace Graf.Algoritms
{
    internal class BFS
    {
        private Graf _graf;
        private List<int> _checkList = new List<int>();
        private List<Edge> _edgeList = new List<Edge>();

        public List<int> CheckList { get => _checkList; }
        public List<Edge> EdgeList { get => _edgeList; }

        internal BFS(Graf graf)
        {
            _graf = graf;
        }

        internal void ApplyAlgoritm(int root)
        {
            _checkList.Add(root);
            var matrix = ConvertToMatrix.GetMatrix(_graf);
            var flag = 0;
            while (_checkList.Count != _graf.GetVertexCount())
            {
                for(var i = 0; i < _graf.GetVertexCount(); i++)
                {
                    if(matrix[_checkList[flag] - 1, i] > 0)
                    {
                        Add(_checkList[flag], i + 1);
                    }
                    
                }
                flag++;
            }
        }

        private void Add(int v1, int v2)
        {
            foreach(var vertex in _checkList)
            {
                if (vertex == v2)
                {
                    return;
                }
            }
            _checkList.Add(v2);
            _edgeList.Add(new Edge(v1, v2, 0, false));
        }
    }
}
