/// <summary>
/// Конвертирование в матрицу смежности
/// </summary>
namespace Graf.Algoritms
{
    internal class ConvertToMatrix
    {
        private Graf _graf;
        internal ConvertToMatrix(Graf graf)
        {
            _graf = graf;
        }

        internal int[,] GetMatrix()
        {
            var count = _graf.GetVertexCount();
            var matrix = new int[count, count];

            foreach(var edge in _graf.GetEdgeList())
            {
                if (edge.Route)
                {
                    matrix[edge.StartVertex - 1, edge.FinishVertex - 1] = edge.Weight;
                }
                else
                {
                    matrix[edge.StartVertex - 1, edge.FinishVertex - 1] = edge.Weight;
                    matrix[edge.FinishVertex - 1, edge.StartVertex - 1] = edge.Weight;
                }
            }

            return matrix;
        }
    }
}
