using System.Collections.Generic;

namespace Graf
{
    public class Graf
    {
        private List<Vertex> _vertexList = new List<Vertex>();
        private List<Edge> _edgeList = new List<Edge>();

        public int AddVertex()
        {
            var vertex = new Vertex(_vertexList.Count);
            _vertexList.Add(vertex);
            return _vertexList.Count;
        }

        public void AddEdge(int start, int finish, int weight)
        {
            _edgeList.Add(new Edge(start, finish, weight));
        }
    }
}