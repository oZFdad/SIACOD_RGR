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
            int point;
            var routeMatrix = new int[matrix.GetLength(0), matrix.GetLength(0)];
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                
            }
        }

        public string GetListWithResalts()
        {
            return "Ok";
            //throw new NotImplementedException();
        }
    }
}
