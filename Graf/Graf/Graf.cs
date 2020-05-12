using System.Collections.Generic;

namespace Graf
{   /// <summary>
    /// ����� ��������� ����
    /// </summary>
    internal class Graf
    {
        private List<Vertex> _vertexList = new List<Vertex>();
        private List<Edge> _edgeList = new List<Edge>();
        /// <summary>
        /// ����� ���������� ������ � ����
        /// </summary>
        /// <returns>���������� ������ ���������� �������</returns>
        internal int AddVertex()
        {
            var vertex = new Vertex(_vertexList.Count);
            _vertexList.Add(vertex);
            return _vertexList.Count;
        }
        /// <summary>
        /// ����� ���������� �����
        /// </summary>
        /// <param name="start">������� �� ������� �������������� �����</param>
        /// <param name="finish">������� � ������� �������������� �����</param>
        /// <param name="weight">��� �����</param>
        /// <param name="route">true ���� ���� ��������������</param>
        internal void AddEdge(int start, int finish, int weight, bool route)
        {
            _edgeList.Add(new Edge(start, finish, weight, route));
        }
        /// <summary>
        /// ����� �������� ����� � �����
        /// </summary>
        internal void DeleteEdges()
        {
            _edgeList.Clear();
        }

        internal int GetVertexCount()
        {
            return _vertexList.Count;
        }

        internal List<Edge> GetEdgeList()
        {
            return _edgeList;
        }
    }
}