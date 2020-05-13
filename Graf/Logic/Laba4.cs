using Graf.Algoritms;
using Graf.Executors;
using System.Collections.Generic;

namespace Graf.Logic
{
    class Laba4 : IMission
    {
        private MainDrawer _mainDrawer;
        private Graf _graf;
        private List<int> _vetexNumList;

        public Laba4(MainDrawer mainDrawer, Graf graf)
        {
            _mainDrawer = mainDrawer;
            _graf = graf;
        }

        public void DoIt()
        {
            var bfs = new BFS(_graf);
            bfs.ApplyAlgoritm(_mainDrawer.GetCheckedVetex());
            _vetexNumList = bfs.CheckList;
            _mainDrawer.TimingDraw(bfs.EdgeList);
        }

        public string GetListWithResalts()
        {
            if (_vetexNumList.Count == 0)
            {
                return "Не корректные условия";
            }

            var result = "Порядок обхода: ";

            foreach (var s in _vetexNumList)
            {
                result += $"{s}, ";
            }
            var index = result.Length - 2;
            result = result.Remove(index, 2);

            return result;
        }
    }
}
