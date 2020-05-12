using System.Drawing;

namespace Graf.Models
{/// <summary>
 /// Модель данных которые ожидаем с формы
 /// </summary>
    public class GrafData
    {
        public Point ClicPoint { get; set; }
        public Graphics FormGraphics { get; set; }
        public bool CheckEdgeRoute { get; set; }
        public bool CheckCircle { get; set; }
        public int Weight { get; set; }
    }
}