using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graf.Algoritms
{
    internal class Floyd
    {
        private Graf _graf;

        internal Floyd(Graf graf)
        {
            _graf = graf;
        }

        internal int[,] ApplyAlgoritm()
        {
            var algoritm = new ConvertToMatrix(_graf);
            var matrix = algoritm.GetMatrix();
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        matrix[i, j] = 99999999;
                    }
                }
            }
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, i] = 0;
            }
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(0); j++)
                {
                    for (var k = 0; k < matrix.GetLength(0); k++)
                    {
                        if (matrix[j, k] > matrix[j, i] + matrix[i, k])
                        {
                            matrix[j, k] = matrix[j, i] + matrix[i, k];
                        }
                    }
                }
            }
            return matrix;
        }
    }
}
