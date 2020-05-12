namespace Graf
{   /// <summary>
    /// Класс описывает вершины графа
    /// </summary>
    internal class Vertex
    {/// <summary>
    /// Номер вершины
    /// </summary>
        private int _num;
        /// <summary>
        /// Конструктр вершин
        /// </summary>
        /// <param name="num">номер вершины</param>
        internal Vertex(int num)
        {
            _num = num;
        }
    }
}