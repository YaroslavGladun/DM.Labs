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

        public static bool operator !=(Rib rib1, Rib rib2)
        {
            return !((rib1.startTop == rib2.startTop) && (rib1.endTop == rib2.endTop)) &&
                !((rib1.startTop == rib2.endTop) && (rib1.endTop == rib2.startTop));
        }

        public static bool operator ==(Rib rib1, Rib rib2)
        {
            return ((rib1.startTop == rib2.startTop) && (rib1.endTop == rib2.endTop)) ||
                ((rib1.startTop == rib2.endTop) && (rib1.endTop == rib2.startTop));
        }


        public bool checkJointTops(Rib rib2)
        {
            return (this.startTop == rib2.startTop && this.endTop != rib2.endTop) ||
                (this.endTop == rib2.endTop && this.startTop != rib2.startTop) ||
                (this.endTop == rib2.startTop && this.startTop == rib2.endTop) ||
                (this.startTop == rib2.endTop && this.endTop == rib2.startTop);
        }

        public Top StartTop { get => startTop; set => startTop = value; }
        public Top EndTop { get => endTop; set => endTop = value; }
        public int ValuePrice { get => valuePrice; set => valuePrice = value; }

        
    }
}
