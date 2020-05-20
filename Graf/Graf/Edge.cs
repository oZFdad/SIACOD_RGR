namespace Graf
{   /// <summary>
    /// ����� ����������� ����� �����
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
        /// ���������� �����
        /// </summary>
        /// <param name="startVertex">������� �� ������� �������������� �����</param>
        /// <param name="finishVertex">������� � ������� �������������� �����</param>
        /// <param name="weight">��� �����</param>
        /// <param name="route">true ���� ���� ��������������</param>
        internal Edge(int startVertex, int finishVertex, int weight, bool route)
        {
            _startVertex = startVertex;
            _finishVertex = finishVertex;
            _weight = weight;
            _route = route;
        }
    }
}