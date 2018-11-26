using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using logoblib;

namespace Graphs
{
    class GraphicTop
    {
        private Rectangle rectangle;
        private int width;
        private int height;

        public GraphicTop()
        {
            width = height = 25;
        }

        public GraphicTop(int radius)
        {
            width = height = 2*radius;
        }

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public Rectangle Rectangle { get => rectangle; set => rectangle = value; }
    }
}
