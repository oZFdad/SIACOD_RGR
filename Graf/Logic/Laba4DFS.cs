using System.Collections.Generic;
using Graf.Algoritms;
using Graf.Executors;

namespace Graf.Logic
{
    internal class Laba4DFS : IMission
    {
        private MainDrawer _mainDrawer;
        private Graf _graf;
        private List<int> _vetexNumList;

        public Laba4DFS(MainDrawer mainDrawer, Graf graf)
        {
            _mainDrawer = mainDrawer;
            _graf = graf;
        }
        public void DoIt()
        {
            var dfs = new DFS(_graf);
            dfs.ApplyAlgoritm(_mainDrawer.GetCheckedVetex());
            _vetexNumList = dfs.VisitedVertex;
            if (dfs.EdgeList.Count != 0)
            {
                _mainDrawer.TimingDraw(dfs.EdgeList);
            }
        }

        public string GetListWithResalts()
        {
            if (_vetexNumList.Count < 2)
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