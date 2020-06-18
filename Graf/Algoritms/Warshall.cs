namespace Graf.Algoritms
{
    internal class Warshall
    {
        private Graf _graf;
        private int[,] _intMatrix;
        public bool[,] Matrix { get; set; }

        internal Warshall(Graf graf)
        {
            _graf = graf;
            _intMatrix = ConvertToMatrix.GetMatrix(_graf);
            ApplyAlgoritm();
        }

        private void ApplyAlgoritm()
        {
            Matrix = new bool[_intMatrix.GetLength(0), _intMatrix.GetLength(0)];
            for (var i = 0; i < _intMatrix.GetLength(0); i++)
            {
                for (var j = 0; j < _intMatrix.GetLength(0); j++)
                {
                    if (_intMatrix[i, j] != 0)
                    {
                        Matrix[i, j] = true;
                    }
                }
            }
            
            for (var i = 0; i < _intMatrix.GetLength(0); i++)
            {
                for (var j = 0; j < _intMatrix.GetLength(0); j++)
                {
                    for (var k = 0; k < _intMatrix.GetLength(0); k++)
                    {
                        if (!Matrix[j, k])
                        {
                            Matrix[j, k] = Matrix[j, i] && Matrix[i, k];
                        }
                    }
                }
            }
        }
    }
}