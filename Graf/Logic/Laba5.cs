using Graf.Executors;
using System;
using System.Linq;

namespace Graf.Logic
{
    class Laba5 : IMission
    {
        private MainDrawer _mainDrawer;
        private Graf _graf;

        public Laba5(MainDrawer mainDrawer, Graf graf)
        {
            _mainDrawer = mainDrawer;
            _graf = graf;
        }

        public void DoIt()
        {
            var helpList = new int[_graf.VertexList.Count];
            foreach (var edge in _graf.EdgesList)
            {
                helpList[edge.FitstVertex]++;
                helpList[edge.SecondVertex]++;
            }
            var counter = 0;
            foreach (var numOfVertex in helpList)
            {
                if (numOfVertex == 0)
                {
                    return "Нет Эйлерова цикла, граф несвязный";
                }
                counter += numOfVertex % 2;
            }
            var floyd = new Floyd(_graf);
            if (floyd.CheckGrafFloyd())
            {
                if (counter == 0)
                {
                    return "Есть Эйлеров цикл";
                }
                else
                {
                    return "Нет Эйлерова цикла, есть вершины с нечетной степенью";
                }
            }
            else
            {
                return "Нет Эйлерова цикла, граф несвязный";
            }
        }

        public string GetListWithResalts()
        {
            throw new NotImplementedException();
        }
    }
}
