using System;

namespace Graf.Algoritms
{
    internal class Floyd
    {
        private Graf _graf;
        public int[,] Matrix { get; }

        internal Floyd(Graf graf)
        {
            _graf = graf;
            Matrix = ConvertToMatrix.GetMatrix(_graf);
            ApplyAlgoritm();
        }

        private void ApplyAlgoritm()
        {
            for (var i = 0; i < Matrix.GetLength(0); i++)
            {
                for (var j = 0; j < Matrix.GetLength(0); j++)
                {
                    if (Matrix[i, j] == 0)
                    {
                        Matrix[i, j] = 99999999;
                    }
                }
            }
            for (var i = 0; i < Matrix.GetLength(0); i++)
            {
                Matrix[i, i] = 0;
            }
            for (var i = 0; i < Matrix.GetLength(0); i++)
            {
                for (var j = 0; j < Matrix.GetLength(0); j++)
                {
                    for (var k = 0; k < Matrix.GetLength(0); k++)
                    {
                        if (Matrix[j, k] > Matrix[j, i] + Matrix[i, k])
                        {
                            Matrix[j, k] = Matrix[j, i] + Matrix[i, k];
                        }
                    }
                }
            }
        }
    }
}
