using Graf.Executors;
using System.Collections.Generic;
using System.Linq;
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
            var copyMatrix = ConvertToMatrix.GetMatrix(_graf);
            var start = _mainDrawer.GetVertexForDej() - 1;
            var finish = _mainDrawer.GetVertexForDej() - 1;
            
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        matrix[i, j] = 999999999;
                        copyMatrix[i, j] = 999999999;
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
                                changed = true;
                            }
                        }
                    }
                }
            }
            
            _result = matrix[start, finish].ToString();
            
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, i] = 0;
            }

            var vertexList = new List<int>();

            var s = matrix[start, finish];
            while (s > 0)
            {
                for (var i = 0; i < copyMatrix.GetLength(0); i++)
                {
                    if (copyMatrix[i, finish] < 10000)
                    {
                        if (s - copyMatrix[i, finish] == matrix[start, i])
                        {
                            s -= copyMatrix[i, finish];
                            vertexList.Add(finish + 1);
                            finish = i;
                            break;
                        }
                    }
                }
            }

            vertexList.Add(start + 1);
            vertexList.Reverse();

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
