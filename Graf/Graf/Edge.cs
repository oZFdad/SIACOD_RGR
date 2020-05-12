namespace Graf
{
    public class Edge
    {
        private int _startVertex;
        private int _finishVertex;
        private int _weight;

        public Edge(int startVertex, int finishVertex, int weight)
        {
            _startVertex = startVertex;
            _finishVertex = finishVertex;
            _weight = weight;
        }
    }
}