using Graf.Algoritms;
using System;
using System.Collections.Generic;

namespace Graf.Logic
{
    internal class RGR : IMission
    {
        private Graf _graf;
        private List<string> _listNumVertex = new List<string>();


        public RGR(Graf graf)
        {
            _graf = graf;
        }

        public void DoIt()
        {
            var warhall = new Warshall(_graf);
            var matrix = warhall.Matrix;
            for(var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(0); j++)
                {
                    if (i == j && j == matrix.GetLength(0) - 1)
                    {
                        _listNumVertex.Add(Convert.ToString(i + 1));
                        break;
                    }
                    if (i == j)
                    {
                        continue;
                    }
                    if(!matrix[i, j])
                    {
                        break;
                    }
                    if (j == matrix.GetLength(0) - 1)
                    {
                        _listNumVertex.Add(Convert.ToString(i + 1));
                    }
                }
            }
        }

        public string GetListWithResalts()
        {
            if (_listNumVertex.Count == 0)
            {
                return "Корней нет";
            }

            var result = "";

            foreach(var s in _listNumVertex)
            {
                result += $"{s}, ";
            }
            var index = result.Length - 2;
            result = result.Remove(index, 2);

            if(_listNumVertex.Count == 1)
            {
                result = $"Вершина {result} является корнем графа";
            }
            else
            {
                result = $"Вершины {result} являются корнем графа";
            }

            return result;
        }
    }
}
