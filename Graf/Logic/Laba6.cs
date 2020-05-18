using Graf.Executors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graf.Algoritms;

namespace Graf.Logic
{
    class Laba6 : IMission
    {
        private MainDrawer _mainDrawer;
        private Graf _graf;
        private string _result;
        

        public Laba6(MainDrawer mainDrawer, Graf graf)
        {
            _mainDrawer = mainDrawer;
            _graf = graf;
        }

        public void DoIt()
        {
            var matrix = ConvertToMatrix.GetMatrix(_graf);
            var start = _mainDrawer.GetVertexForDej() - 1;
            var finish = _mainDrawer.GetVertexForDej() - 1;
            
            var routeMatrix = new int[matrix.GetLength(0), matrix.GetLength(0)];
            
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        routeMatrix[i, j] = 9999999;
                        matrix[i, j] = 999999999;
                    }
                }
            }

            var changed = true;
            while (changed)
            {
                changed = false;
                for (var i = 0; i < matrix.GetLength(0); i++)
                {
                    for (var j = 0; j < matrix.GetLength(0); j++)
                    {
                        for (var k = 0; k < matrix.GetLength(0); k++)
                        {
                            if (matrix[i, j] > matrix[i, k] + matrix[k, j])
                            {
                                matrix[i, j] = matrix[i, k] + matrix[k, j];
                                routeMatrix[i, j] = k;
                                changed = true;
                            }
                        }
                    }
                }
            }

            var vertexList = new List<int>();
            vertexList.Add(finish + 1);
            while (finish != start)
            {
                vertexList.Add(routeMatrix[start,finish] + 1);
                finish = routeMatrix[start, finish];
            }
            vertexList.Reverse();
            

            foreach (var i in vertexList)
            {
                _result += $"{Convert.ToString(i)} ";
            }
            
            var edgeList = new List<Edge>();
            for (var i = 0; i < vertexList.Count - 1; i++)
            {
                var edge = _graf.GetEdgeList().FirstOrDefault(e =>
                    e.StartVertex == vertexList[i] && e.FinishVertex == vertexList[i + 1]);
                if (edge != null)
                {
                    edgeList.Add(edge);
                }
            }
            _mainDrawer.TimingDraw(edgeList);
        }

        public string GetListWithResalts()
        {
            return _result;
        }
    }
}
