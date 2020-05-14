using Graf.Executors;
using System;
using System.Linq;
using Graf.Algoritms;

namespace Graf.Logic
{
    class Laba5 : IMission
    {
        private MainDrawer _mainDrawer;
        private Graf _graf;
        private string _result;

        public Laba5(MainDrawer mainDrawer, Graf graf)
        {
            _mainDrawer = mainDrawer;
            _graf = graf;
        }

        public void DoIt()
        {
            var helpList = new int[_graf.GetVertexCount()];
            foreach (var edge in _graf.GetEdgeList())
            {
                helpList[edge.StartVertex - 1]++;
                helpList[edge.FinishVertex - 1]++;
            }
            var counter = 0;
            foreach (var numOfVertex in helpList)
            {
                if (numOfVertex == 0)
                {
                    _result = "Нет Эйлерова цикла, граф несвязный";
                    return;
                }
                counter += numOfVertex % 2;
            }
            var floyd = new Floyd(_graf);
            var flag = true;
            foreach (var edge in floyd.Matrix)
            {
                if (edge > 99999)
                {
                    flag = false;
                }
            }
            if (flag)
            {
                if (counter == 0)
                {
                    _result = "Есть Эйлеров цикл";
                    return;
                }
                else
                {
                    _result = "Нет Эйлерова цикла, есть вершины с нечетной степенью";
                    return;
                }
            }
            else
            {
                _result = "Нет Эйлерова цикла, граф несвязный";
                return;
            }
        }

        public string GetListWithResalts()
        {
            return _result;
        }
    }
}
