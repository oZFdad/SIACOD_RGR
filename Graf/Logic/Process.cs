using Graf.Executors;
using Graf.Models;
using System.Collections.Generic;

namespace Graf.Logic
{    /// <summary>
     /// Класс отвечает за весь логический процесс в библиотеке
     /// </summary>
    public class Process
    {
        private MainDrawer _mainDrawer;
        private Graf _graf;
        private IMission _ex;

        public delegate void EventHandler();

        public delegate void AddEdgeEventHandler(List<EdgeForDGW> data);
        public event EventHandler algoritmComplete;
        public event AddEdgeEventHandler AddEdgeEvent;

        public Process()
        {
            _graf = new Graf();
            _mainDrawer = new MainDrawer(_graf);
        }

        public string GetResaltSearch()
        {
            return _ex.GetListWithResalts();
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
            var edgeList = new List<EdgeForDGW>();
            foreach (var edge in _graf.GetEdgeList())
            {
                edgeList.Add(new EdgeForDGW
                {
                    Start = edge.StartVertex,
                    Finish = edge.FinishVertex,
                    Weight = edge.Weight
                });
            }
            AddEdgeEvent?.Invoke(edgeList);
        }

        public void DoAlgoritm(CheckEx checkEx)
        {
            if (checkEx.RGR)
            {
                _ex = new RGR(_graf);
            }
            if (checkEx.Laba4BFS)
            {
                _ex = new Laba4BFS(_mainDrawer, _graf);
                if (_mainDrawer.GetCheckedVetex() < 0)
                {
                    return;
                }
            }
            if (checkEx.Laba4DFS)
            {
                _ex = new Laba4DFS(_mainDrawer, _graf);
                if (_mainDrawer.GetCheckedVetex() < 0)
                {
                    return;
                }
            }
            if (checkEx.Laba5)
            {
                _ex = new Laba5(_mainDrawer, _graf);
            }
            if (checkEx.Laba6)
            {
                if (!_mainDrawer.FullListForDej())
                {
                    return;
                }
                _ex = new Laba6(_mainDrawer, _graf);
            }
            _ex.DoIt();
            algoritmComplete?.Invoke();
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

        public void CheckVertex(GrafData data)
        {
            data.ForDej = true;
            _mainDrawer.IsCheckBoardCircle(data);
        }

        public void EditEdge(int start, int finish, int weight)
        {
            _graf.EditEdge(start, finish, weight);
            _mainDrawer.EditEdge(start, finish, weight);
        }
    }
}