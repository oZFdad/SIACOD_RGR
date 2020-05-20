namespace Graf
{   /// <summary>
    /// Класс описывающий ребра графа
    /// </summary>
    internal class Edge
    {
        private int _startVertex;
        public int StartVertex { get => _startVertex; }

        private int _finishVertex;
        public int FinishVertex { get => _finishVertex; }

        private int _weight;
        public int Weight { get => _weight;
            set => _weight = value;
        }

        private bool _route;
        public bool Route { get => _route; }
        /// <summary>
        /// Конструктр Ребер
        /// </summary>
        /// <param name="startVertex">Вершина от которой прокладывается ребро</param>
        /// <param name="finishVertex">Вершина к которой прокладывается ребро</param>
        /// <param name="weight">вес ребра</param>
        /// <param name="route">true если граф ориентированый</param>
        internal Edge(int startVertex, int finishVertex, int weight, bool route)
        {
            _startVertex = startVertex;
            _finishVertex = finishVertex;
            _weight = weight;
            _route = route;
        }
    }
}