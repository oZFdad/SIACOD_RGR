using Graf.Algoritms;
using Graf.Executors;
using Graf.Models;

namespace Graf.Logic
{    /// <summary>
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
            if (IsCheckBoardCircle(data))
            {
                _mainDrawer.AddEdge(data);
            }
            else
            {
                _mainDrawer.AddVertex(data);
            }
        }
        /// <summary>
        /// Отрисовка графа на форме
        /// </summary>
        /// <param name="data">Модель данных</param>
        public void Draw(GrafData data)
        {
            _mainDrawer.Draw(data);
        }
        /// <summary>
        /// Проверка выбора вершины
        /// </summary>
        /// <param name="data">Модель данных</param>
        /// <returns>bool, выбрана или нет</returns>
        private bool IsCheckBoardCircle(GrafData data)
        {
            return _mainDrawer.IsCheckBoardCircle(data);
        }
        /// <summary>
        /// Очистка информации о ребра, при включении
        /// или выключении режима орграфа
        /// </summary>
        public void CheckedChangedOnCheckBoxForRoute()
        {
            _mainDrawer.ClearChekedList();
            _mainDrawer.ClearLineList();
            _graf.DeleteEdges();
        }
    }
}