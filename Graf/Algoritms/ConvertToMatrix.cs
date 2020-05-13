/// <summary>
/// Конвертирование в матрицу смежности
/// </summary>
namespace Graf.Algoritms
{
    internal static class ConvertToMatrix
    {
        internal static int[,] GetMatrix(Graf graf)
        {
            var count = graf.GetVertexCount();
            var matrix = new int[count, count];

            foreach(var edge in graf.GetEdgeList())
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
