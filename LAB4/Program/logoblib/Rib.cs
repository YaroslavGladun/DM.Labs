using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logoblib
{
    class Rib
    {
        private Top startTop;
        private Top endTop;
        private int valuePrice;

        public Rib(Top startTop, Top endTop)
        {
            this.StartTop = startTop;
            this.EndTop = endTop;
        }

        public Rib(Top startTop, Top endTop, int valuePrice)
        {
            this.StartTop = startTop;
            this.EndTop = endTop;
            this.valuePrice = valuePrice;
        }

        public Top StartTop { get => startTop; set => startTop = value; }
        public Top EndTop { get => endTop; set => endTop = value; }
        public int ValuePrice { get => valuePrice; set => valuePrice = value; }
    }
}
