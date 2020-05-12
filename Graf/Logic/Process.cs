using Graf.Executors;
using Graf.Models;

namespace Graf.Logic
{/// <summary>
 /// Класс отвечает за весь логический процесс в библиотеке
 /// </summary>
    public class Process
    {
        private MainDrawer _mainDrawer;
        private Graf _graf;

        public Process()
        {
            _graf = new Graf();
            _mainDrawer = new MainDrawer(_graf);
        }
/// <summary>
/// Обработка события клика, выделение, рисование вершин и ребер
/// </summary>
/// <param name="data">Модель данных</param>
        public void ClickOnPainBox(GrafData data)
        {
            if (CheckBoardCircle(data))
            {
                _mainDrawer.AddEdge(data);
            }
            else
            {
                _mainDrawer.AddVertex(data);
            }
        }

        private bool CheckBoardCircle(GrafData data)
        {
            return _mainDrawer.CheckBoardCircle(data);
        }
    }
}