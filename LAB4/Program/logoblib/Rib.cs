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

        public Rib(ref Top startTop, ref Top endTop)
        {
            this.startTop = startTop;
            this.endTop = endTop;
        }

    }
}
