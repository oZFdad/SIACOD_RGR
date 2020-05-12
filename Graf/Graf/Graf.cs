using System.Collections.Generic;

namespace Graf
{   /// <summary>
    /// Класс описывает Граф
    /// </summary>
    internal class Graf
    {
        private List<Vertex> _vertexList = new List<Vertex>();
        private List<Edge> _edgeList = new List<Edge>();
        /// <summary>
        /// Метод добавления вершин в граф
        /// </summary>
        /// <returns>Возвращает индекс добавленой вершины</returns>
        internal int AddVertex()
        {
            var vertex = new Vertex(_vertexList.Count);
            _vertexList.Add(vertex);
            return _vertexList.Count;
        }
        /// <summary>
        /// Метод добавления ребер
        /// </summary>
        /// <param name="start">вершина от которой прокладывается ребро</param>
        /// <param name="finish">вершина к которой прокладывается ребро</param>
        /// <param name="weight">вес ребра</param>
        /// <param name="route">true если граф ориентированый</param>
        internal void AddEdge(int start, int finish, int weight, bool route)
        {
            _edgeList.Add(new Edge(start, finish, weight, route));
        }
        /// <summary>
        /// Метод удаления ребер в графе
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