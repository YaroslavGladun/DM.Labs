using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logoblib
{
    class Top
    {
        private char name;

        public Top(char name)
        {
            this.name = name;
        }

        public static bool operator == (Top top1, Top top2)
        {
            return top1.name == top2.name;
        }

        public static bool operator !=(Top top1, Top top2)
        {
            return top1.name != top2.name;
        }

        public char Name { get => name; set => name = value; }
    }
}
